namespace CollectionView.EmptyViewBug.Pages;

using CommunityToolkit.Maui.Alerts;

public partial class CollectionViewInGridEmptyViewTemplateDummyBehaviorWithHeight : ContentPage
{
    public CollectionViewInGridEmptyViewTemplateDummyBehaviorWithHeight()
    {
        InitializeComponent();
    }

    private void Button_Clicked(object sender, EventArgs e)
    {
        Toast.Make("Button").Show();
    }
}