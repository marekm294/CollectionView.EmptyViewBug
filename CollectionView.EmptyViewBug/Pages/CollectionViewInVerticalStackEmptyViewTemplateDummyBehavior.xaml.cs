namespace CollectionView.EmptyViewBug.Pages;

using CommunityToolkit.Maui.Alerts;

public partial class CollectionViewInVerticalStackEmptyViewTemplateDummyBehavior : ContentPage
{
    public CollectionViewInVerticalStackEmptyViewTemplateDummyBehavior()
    {
        InitializeComponent();
    }

    private void Button_Clicked(object sender, EventArgs e)
    {
        Toast.Make("Button").Show();
    }
}