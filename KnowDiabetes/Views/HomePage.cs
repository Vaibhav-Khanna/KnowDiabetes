using System;

using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration.iOSSpecific;

namespace KnowDiabetes.Views
{
    public class HomePage : TabbedPage
    {
        public HomePage()
        {
            Children.Add(new IntroPage() {  Icon = "openbook.png" });
            Children.Add(new PrecautionDietPage() { Icon = "apple.png" });
            Children.Add(new SupportPage() { Icon = "stethoscope.png" });

#if __IOS__

            BarTextColor = App.Tab_Background_Color;

            Xamarin.Forms.NavigationPage.SetHasNavigationBar(this, false);
#endif

#if __ANDROID__

            BarTextColor = Color.White;

            Xamarin.Forms.NavigationPage.SetHasNavigationBar(this, false);
#endif

		}
    }
}

