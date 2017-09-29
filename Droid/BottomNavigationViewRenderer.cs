using System;
using Android.Support.Design.Widget;
using Xamarin.Forms.Platform.Android;
using Xamarin.Forms;
using KnowDiabetes;
using KnowDiabetes.Droid;

[assembly: ExportRenderer(typeof(BottomNavigation), typeof(BottomNavigationViewRenderer))]
namespace KnowDiabetes.Droid
{
    public class BottomNavigationViewRenderer : ViewRenderer<BottomNavigation,BottomNavigationView>
    {
        public BottomNavigationViewRenderer()
        {
        }

        protected override void OnElementChanged(ElementChangedEventArgs<BottomNavigation> e)
        {
            base.OnElementChanged(e);

			if (e.OldElement != null || this.Element == null)
				return;
            
            var botm = Inflate(Forms.Context, Resource.Layout.BottomNavigationLayout,null).FindViewById<BottomNavigationView>(Resource.Id.bottom_navigation);

            botm.NavigationItemSelected += BottomNavigation_NavigationItemSelected;

            SetNativeControl(botm);

        }

        private void BottomNavigation_NavigationItemSelected(object sender, BottomNavigationView.NavigationItemSelectedEventArgs e)
        {
           
        }
    }
}
