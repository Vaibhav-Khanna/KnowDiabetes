using System;
using FFImageLoading.Forms;
using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration.iOSSpecific;

namespace KnowDiabetes.Views
{
    public class PrecautionDietPage : ContentPage
    {


        public const string detail = "There are certain things that everyone who has diabetes, whether type 1 or type 2, needs to do to be healthy. They need to have a meal (eating) plan. They need to pay attention to how much physical activity they engage in, because physical activity can help the body use insulin better so it can convert glucose into energy for cells. Everyone with type 1 diabetes, and some people with type 2 diabetes, also need to take insulin injections. Some people with type 2 diabetes take pills called \"oral agents\" which help their bodies produce more insulin and/or use the insulin it is producing better. Some people with type 2 diabetes can manage their disease without medication by appropriate meal planning and adequate physical activity.\n\nEveryone who has diabetes should be seen at least once every six months by a diabetes specialist (an endocrinologist or a diabetologist). He or she should also be seen periodically by other members of a diabetes treatment team, including a diabetes nurse educator, and a dietitian who will help develop a meal plan for the individual. Ideally, one should also see an exercise physiologist for help in developing a physical activity plan, and, perhaps, a social worker, psychologist or other mental health professional for help with the stresses and challenges of living with a chronic disease. Everyone who has diabetes should have regular eye exams (once a year) by an ophthalmologist to make sure that any eye problems associated with diabetes are caught early and treated before they become serious.\n\nAlso, people with diabetes need to learn how to monitor their blood glucose. Daily testing will help determine how well their meal plan, activity plan, and medication are working to keep blood glucose levels in a normal range.";

        public const string detail2 = "Maybe someday. Type 2 diabetes is the most common type of diabetes, yet we still do not understand it completely. Recent research does suggest, however, that there are some things one can do to prevent this form of diabetes. Studies show that lifestyle changes can prevent or delay the onset of type 2 diabetes in those adults who are at high risk of getting the disease. Modest weight loss (5-10% of body weight) and modest physical activity (30 minutes a day) are recommended goals.";

        public const string detail3 = "Recommended foods\n\nMake your calories count with these nutritious foods:\n\nHealthy carbohydrates. During digestion, sugars (simple carbohydrates) and starches (complex carbohydrates) break down into blood glucose. Focus on the healthiest carbohydrates, such as fruits, vegetables, whole grains, legumes (beans, peas and lentils) and low-fat dairy products.\nFiber-rich foods. Dietary fiber includes all parts of plant foods that your body can't digest or absorb. Fiber moderates how your body digests and helps control blood sugar levels. Foods high in fiber include vegetables, fruits, nuts, legumes (beans, peas and lentils), whole-wheat flour and wheat bran.\nHeart-healthy fish. Eat heart-healthy fish at least twice a week. Fish can be a good alternative to high-fat meats. For example, cod, tuna and halibut have less total fat, saturated fat and cholesterol than do meat and poultry. Fish such as salmon, mackerel, tuna, sardines and bluefish are rich in omega-3 fatty acids, which promote heart health by lowering blood fats called triglycerides.\n\nAvoid fried fish and fish with high levels of mercury, such as tilefish, swordfish and king mackerel.\n\n\"Good\" fats. Foods containing monounsaturated and polyunsaturated fats can help lower your cholesterol levels. These include avocados, almonds, pecans, walnuts, olives, and canola, olive and peanut oils. But don't overdo it, as all fats are high in calories.\nFoods to avoid\n\nDiabetes increases your risk of heart disease and stroke by accelerating the development of clogged and hardened arteries. Foods containing the following can work against your goal of a heart-healthy diet.\n\nSaturated fats. High-fat dairy products and animal proteins such as beef, hot dogs, sausage and bacon contain saturated fats.\nTrans fats. These types of fats are found in processed snacks, baked goods, shortening and stick margarines. Avoid these items.\nCholesterol. Sources of cholesterol include high-fat dairy products and high-fat animal proteins, egg yolks, liver, and other organ meats. Aim for no more than 200 milligrams (mg) of cholesterol a day.\nSodium. Aim for less than 2,300 mg of sodium a day. However, if you also have hypertension, you should aim for less than 1,500 mg of sodium a day.";

        public const string detail4 = "Diet details\n\nA diabetes diet is based on eating three meals a day at regular times. This helps your body better use the insulin it produces or gets through a medication.\n\nA registered dietitian can help you put together a diet based on your health goals, tastes and lifestyle. He or she can also talk with you about how to improve your eating habits, for example, by choosing portion sizes that suit the needs for your size and level of activity.";


		public PrecautionDietPage()
        {
			
            var lb_heading = new Label() { Text = "Precautions" + Environment.NewLine+  "& Diet", Margin = new Thickness(15, 15, 0, 0), TextColor = Color.Black, FontFamily = "Helvetica-Bold", FontAttributes = FontAttributes.Bold, FontSize = 34 };

			var lb_Q1 = new Label
			{
				Text = "Can diabetes be prevented?",
				Margin = new Thickness(15, 10, 15, 0),
				FontSize = 20,
				FontAttributes = FontAttributes.Bold,
				FontFamily = "Helvetica-Bold"
			};


			var lb_detail = new Label
			{
				Text = detail2,
				Margin = new Thickness(15, 0, 15, 0),
				FontSize = 18
			};


			var lb_Q2 = new Label
			{
				Text = "How is diabetes treated?",
				Margin = new Thickness(15, 10, 15, 0),
				FontSize = 20,
				FontAttributes = FontAttributes.Bold,
				FontFamily = "Helvetica-Bold"
			};

			var lb_detail2 = new Label
			{
				Text = detail,
				Margin = new Thickness(15, 0, 15, 0),
				FontSize = 18
			};

			var lb_Q3 = new Label
			{
				Text = "Diabetes diet: Create your healthy-eating plan",
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
                        Content = new StackLayout { Padding = new Thickness(0,0,0,30), Children = { lb_heading, boxview_line, lb_Q1, lb_detail, lb_Q2, lb_detail2, lb_Q3, lb_detail3  }, Orientation = StackOrientation.Vertical },
						Orientation = ScrollOrientation.Vertical }
				}
			};
#endif



#if __ANDROID__

         

			var boxview_line = new BoxView { HorizontalOptions = LayoutOptions.Start, Margin = new Thickness(15, 0, 0, 0), HeightRequest = 0.5, WidthRequest = App.Width * 0.85, Color = Color.LightGray };

			var bottm = new BottomNavigation() { HorizontalOptions = LayoutOptions.FillAndExpand, VerticalOptions = LayoutOptions.End, Margin = 0 };


			Content = new StackLayout
			{
				Orientation = StackOrientation.Vertical,
				Padding = 0,
				Margin = 0,
				Spacing = 0,
				Children = {  new ScrollView
			{
                        Content = new StackLayout { Padding = new Thickness(0,0,0,30), Children = { lb_heading, boxview_line, lb_Q1, lb_detail, lb_Q2, lb_detail2, lb_Q3, lb_detail3 , bottm  }, Orientation = StackOrientation.Vertical },
						Orientation = ScrollOrientation.Vertical }
				}
			};

#endif


		}
    }
}

