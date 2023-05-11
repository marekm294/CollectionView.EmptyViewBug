namespace CollectionView.EmptyViewBug.Pages;

using CommunityToolkit.Maui.Alerts;

public partial class CollectionViewInVerticalStackEmptyViewTemplateDummyBehaviorWithHeight : ContentPage
{
    public CollectionViewInVerticalStackEmptyViewTemplateDummyBehaviorWithHeight()
    {
        InitializeComponent();
    }

    private void Button_Clicked(object sender, EventArgs e)
    {
        Toast.Make("Button").Show();
    }
}