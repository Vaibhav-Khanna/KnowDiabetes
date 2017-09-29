using System;

using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration.iOSSpecific;

namespace KnowDiabetes.Views
{
    public class SupportPage : ContentPage
    {
        public SupportPage()
        {
            
			var lb_heading = new Label() { Text = "Support", Margin = new Thickness(15, 15, 0, 0), TextColor = Color.Black, FontFamily = "Helvetica-Bold", FontAttributes = FontAttributes.Bold, FontSize = 34 };

#if __IOS__

			var boxview = new BoxView { HorizontalOptions = LayoutOptions.FillAndExpand, HeightRequest = 20, Color = App.Tab_Background_Color };

			//boxview.On<Xamarin.Forms.PlatformConfiguration.iOS>().UseBlurEffect(BlurEffectStyle.Light);

			var boxview_line = new BoxView { HorizontalOptions = LayoutOptions.Start, Margin = new Thickness(15, 0, 0, 0), HeightRequest = 0.5, WidthRequest = App.Width * 0.85, Color = Color.LightGray };

			Content = new StackLayout
			{
				Orientation = StackOrientation.Vertical,
				Padding = 0,
				Margin = 0,
				Spacing = 0,
				Children = { boxview, new ScrollView
			{
                        Content = new StackLayout { Padding = 0, Children = { lb_heading,boxview_line }, Orientation = StackOrientation.Vertical },
						Orientation = ScrollOrientation.Vertical }
				}
			};
#endif



#if __ANDROID__


            var boxview_line = new BoxView { HorizontalOptions = LayoutOptions.Start, Margin = new Thickness(15, 0, 0, 0), HeightRequest = 0.5, WidthRequest = App.Width * 0.85, Color = Color.LightGray, VerticalOptions = LayoutOptions.Start };

         
			Content = new StackLayout
			{
				Orientation = StackOrientation.Vertical,
				Padding = 0,
				Margin = 0,
				Spacing = 0,
				Children = {  new ScrollView
			{
                        Content = new StackLayout { Padding = 0, VerticalOptions = LayoutOptions.FillAndExpand, Children = { lb_heading,boxview_line  }, Orientation = StackOrientation.Vertical },
						Orientation = ScrollOrientation.Vertical }
				}
			};

#endif


		}
    }
}

