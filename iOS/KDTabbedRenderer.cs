using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UIKit;
using Foundation;
using Xamarin.Forms.Platform.iOS;
using Xamarin.Forms;
using KnowDiabetes;


[assembly: ExportRenderer(typeof(TabbedPage), typeof(CustomTabbedRenderer))]
namespace KnowDiabetes
{
	public class CustomTabbedRenderer : TabbedRenderer
	{

        private IPageController PageController => Element as IPageController;

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();

			//	
		}


		public override void ViewWillAppear(bool animated)
		{

			base.ViewWillAppear(animated);

			foreach (UIViewController viewController in base.ViewControllers)
			{
				viewController.TabBarItem.ImageInsets = new UIEdgeInsets(6, 0, -6, 0);
			}
          
           // TabBar.Translucent = true;          			
			
		}

        public override void ViewDidLayoutSubviews()
        {
            base.ViewDidLayoutSubviews();

          

          //  PageController.ContainerArea = new Rectangle(0, 0, View.Frame.Width, View.Frame.Height);

        }



	}
}