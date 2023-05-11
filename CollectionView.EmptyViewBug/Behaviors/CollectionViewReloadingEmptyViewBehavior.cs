namespace CollectionView.EmptyViewBug.Behaviors;

using Microsoft.Maui.Controls;
using System.Collections;

internal sealed class CollectionViewReloadingEmptyViewBehavior : Behavior<CollectionView>
{
    protected override void OnAttachedTo(CollectionView collectionView)
    {
        base.OnAttachedTo(collectionView);
        collectionView.PropertyChanged += Bindable_PropertyChanged;
    }

    protected override void OnDetachingFrom(BindableObject bindable)
    {
        base.OnDetachingFrom(bindable);
        bindable.PropertyChanged -= Bindable_PropertyChanged;
    }

    private void Bindable_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
    {
        var collectionView = (CollectionView)sender;

        if (e.PropertyName == CollectionView.WidthProperty.PropertyName)
        {
            if (collectionView.Width > 0 && Helper.IsEnumerableNullOrEmpty(collectionView.ItemsSource))
            {
                var emptyViewTemplate = collectionView.EmptyViewTemplate;
                collectionView.EmptyViewTemplate = null;
                if (emptyViewTemplate is not null)
                {
                    // windows is hit multiple times and epty view is visible even without height
                    collectionView.EmptyView = emptyViewTemplate.CreateContent();
                }

                //var emptyView = collectionView.EmptyView;
                //collectionView.EmptyView = null;
                //collectionView.EmptyView = emptyView;
            }
        }
    }
}

public static class Helper
{
    public static bool IsEnumerableNullOrEmpty(this IEnumerable enumerable)
    {
        return !enumerable?.GetEnumerator().MoveNext() ?? true;
    }
}