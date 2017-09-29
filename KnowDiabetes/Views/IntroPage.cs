using System;
using FFImageLoading.Forms;
using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration.iOSSpecific;

namespace KnowDiabetes.Views
{
    public class IntroPage : ContentPage
    {

        public const string detail = "Diabetes is a disease in which the body is unable to properly use and store glucose (a form of sugar). Glucose backs up in the bloodstream — causing one’s blood glucose (sometimes referred to as blood sugar) to rise too high.\n\nThere are two major types of diabetes. In type 1 (fomerly called juvenile-onset or insulin-dependent) diabetes, the body completely stops producing any insulin, a hormone that enables the body to use glucose found in foods for energy. People with type 1 diabetes must take daily insulin injections to survive. This form of diabetes usually develops in children or young adults, but can occur at any age. Type 2 (formerly called adult-onset or non insulin-dependent) diabetes results when the body doesn’t produce enough insulin and/or is unable to use insulin properly (insulin resistance). This form of diabetes usually occurs in people who are over 40, overweight, and have a family history of diabetes, although today it is increasingly occurring in younger people, particularly adolescents.";

        public const string detail2 = "People with diabetes frequently experience certain symptoms. These include:\n\n1) being very thirsty\n2) frequent urination\n3) weight loss\n4) increased hunger\n5) blurry vision\n6) irritability\n7) tingling or numbness in the hands or feet\n8) frequent skin, bladder or gum infections\n9) wounds that don't heal\n10) extreme unexplained fatigue\n\nIn some cases, there are no symptoms — this happens at times with type 2 diabetes. In this case, people can live for months, even years without knowing they have the disease. This form of diabetes comes on so gradually that symptoms may not even be recognized.";

        public const string detail3 = "Type 1 diabetes (formerly called juvenile-onset or insulin-dependent diabetes), accounts for 5 to 10 out of 100 people who have diabetes. In type 1 diabetes, the body's immune system destroys the cells that release insulin, eventually eliminating insulin production from the body. Without insulin, cells cannot absorb sugar (glucose), which they need to produce energy.\n\nType 2 diabetes (formerly called adult-onset or non-insulin-dependent diabetes) can develop at any age. It most commonly becomes apparent during adulthood. But type 2 diabetes in children is rising. Type 2 diabetes accounts for the vast majority of people who have diabetes-90 to 95 out of 100 people. In type 2 diabetes, the body isn't able to use insulin the right way. This is called insulin resistance. As type 2 diabetes gets worse, the pancreas may make less and less insulin. This is called insulin deficiency.";

        public const string detail4 = "How are they alike?\n\nBoth types of diabetes greatly increase a person's risk for a range of serious complications. Although monitoring and managing the disease can prevent complications, diabetes remains the leading cause of blindness and kidney failure. It also continues to be a critical risk factor for heart disease, stroke, and foot or leg amputations.";

        public IntroPage()
        {

            var lb_heading = new Label()
            {
                Text = "Know Diabetes",
                Margin = new Thickness(15, 15, 0, 0),
                TextColor = Color.Black,
                FontFamily = "Helvetica-Bold",
                FontAttributes = FontAttributes.Bold,
                FontSize = 34
            };

          
            var img_head = new CachedImage()
			{
				//Source = "https://s3-us-west-2.amazonaws.com/vaibhavkhanna/493x335_type2_diabetes_rmq.jpg",
                Source = "http://img.webmd.com/dtmcms/live/webmd/consumer_assets/site_images/article_thumbnails/quizzes/type2_diabetes_rmq/493x335_type2_diabetes_rmq.jpg",
				HorizontalOptions = LayoutOptions.FillAndExpand,
				VerticalOptions = LayoutOptions.StartAndExpand,
                BitmapOptimizations = true,
                Margin = new Thickness(0,20,0,0),
                DownsampleToViewSize = true, WidthRequest = App.Width, HeightRequest = 200, Aspect = Aspect.AspectFill
			};

			var lb_Q1 = new Label
			{
				Text = "What is diabetes ?",
				Margin = new Thickness(15, 10, 15, 0),
				FontAttributes = FontAttributes.Bold,
                FontSize = 20, FontFamily = "Helvetica-Bold"
			};

			var lb_detail = new Label
			{
				Text = detail,
				Margin = new Thickness(15, 0, 15, 0),
				FontSize = 18
			};


			var lb_Q2 = new Label
			{
				Text = "How do people know if they have diabetes?",
				Margin = new Thickness(15, 10, 15, 0),
				FontSize = 20,
				FontAttributes = FontAttributes.Bold,
				FontFamily = "Helvetica-Bold"
			};

			var lb_detail2 = new Label
			{
				Text = detail2,
				Margin = new Thickness(15, 0, 15, 0),
				FontSize = 18
			};

			var lb_Q3 = new Label
			{
				Text = "Differences Between Type 1 and 2",
				Margin = new Thickness(15, 10, 15, 0),
				FontSize = 20,
				FontAttributes = FontAttributes.Bold,
				FontFamily = "Helvetica-Bold"
			};

			var lb_detail3 = new Label
			{
                Text = detail3 + Environment.NewLine + detail4,
				Margin = new Thickness(15, 0, 15, 0),
				FontSize = 18
			};

			var img_info = new CachedImage()
			{
				Source = "http://www.infographicspedia.com/wp-content/uploads/2014/04/2007-Diabetes-Mellitus-Facts-That-Caught-You-Surprised-infographic.jpg",
				HorizontalOptions = LayoutOptions.FillAndExpand,
				VerticalOptions = LayoutOptions.StartAndExpand,
				BitmapOptimizations = true,
				Margin = new Thickness(0, 10, 0, 0),
				WidthRequest = App.Width,
				DownsampleToViewSize = true
			};


#if __IOS__

            var boxview = new BoxView { HorizontalOptions = LayoutOptions.FillAndExpand, HeightRequest = 20, Color = App.Tab_Background_Color };

           // boxview.On<Xamarin.Forms.PlatformConfiguration.iOS>().UseBlurEffect(BlurEffectStyle.Light);

            var boxview_line = new BoxView { HorizontalOptions = LayoutOptions.Start, Margin = new Thickness(15,0,0,0), HeightRequest = 0.5 , WidthRequest = App.Width*0.85, Color = Color.LightGray };

			Content = new StackLayout
            { Orientation = StackOrientation.Vertical,Padding =0, Margin = 0, Spacing = 0,
                Children = { boxview, new ScrollView
            {
                        Content = new StackLayout { Padding = new Thickness(0,0,0,30), Spacing = 10, Children = { lb_heading, boxview_line,  img_head, lb_Q1, lb_detail,lb_Q2,lb_detail2,lb_Q3,lb_detail3,img_info }, Orientation = StackOrientation.Vertical },
                        Orientation = ScrollOrientation.Vertical }
                }
            };
#endif


#if __ANDROID__

          

			var boxview_line = new BoxView { HorizontalOptions = LayoutOptions.Start, Margin = new Thickness(15, 0, 0, 0), HeightRequest = 0.5, WidthRequest = App.Width * 0.85, Color = Color.LightGray };

			Content = new StackLayout
			{
				Orientation = StackOrientation.Vertical,
				Padding = 0,
				Margin = 0,
				Spacing = 0,
				Children = {  new ScrollView
			{
						Content = new StackLayout { Padding = new Thickness(0,0,0,30), Spacing = 10, Children = { lb_heading, boxview_line,  img_head, lb_Q1, lb_detail,lb_Q2,lb_detail2,lb_Q3,lb_detail3,img_info }, Orientation = StackOrientation.Vertical },
						Orientation = ScrollOrientation.Vertical }
				}
			};
#endif

		}
    }
}

