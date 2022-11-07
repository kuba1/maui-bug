namespace MauiApp2
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            blazorWebView.BlazorWebViewInitializing += BlazorWebView_BlazorWebViewInitializing;
        }

        private void BlazorWebView_BlazorWebViewInitializing(object sender, Microsoft.AspNetCore.Components.WebView.BlazorWebViewInitializingEventArgs e)
        {
#if WINDOWS
            e.UserDataFolder = "C:/Temp/TestFolder";
#endif
        }
    }
}
