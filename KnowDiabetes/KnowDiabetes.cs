using System;
using KnowDiabetes.Views;
using Xamarin.Forms;

namespace KnowDiabetes
{
    public class App : Application
    {
        
        public static Color Tab_Background_Color = Color.FromRgb(33, 150, 243);

        public static Color Tab_Text_Color = Color.White;

        public static Color Page_Background_Color = Color.FromRgb(240, 240, 240);

        public static double Height { get; set; }

        public static double Width { get; set; }

        public App()
        {

            // The root page of your application
            var content = new HomePage
            {
                Title = "Know Diabetes"
            };

            MainPage = new NavigationPage(content) { };

#if __IOS__
            (MainPage as NavigationPage).BarTextColor = Color.White;
            (MainPage as NavigationPage).BarBackgroundColor = Tab_Background_Color;
#endif

#if __ANDROID__
            (MainPage as NavigationPage).BarTextColor = Color.White;
#endif

		}

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }

    }
}
