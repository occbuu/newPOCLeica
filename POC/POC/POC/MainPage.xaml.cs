using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace POC
{
	public partial class MainPage : ContentPage
	{
        Label lblStatus;
        Editor txtDescription;

        public MainPage()
        {
            InitializeComponent();

            Label header = new Label
            {
                Text = "Status: ",
                HorizontalOptions = LayoutOptions.Start
            };
            lblStatus = new Label
            {
                Text = "Not Connect",
                HorizontalOptions = LayoutOptions.CenterAndExpand
            };

            Button button = new Button
            {
                Text = "Connect",
                Font = Font.SystemFontOfSize(NamedSize.Large),
                BorderWidth = 1,
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.CenterAndExpand
            };
            button.Clicked += OnConnectClicked;

            txtDescription = new Editor
            {
                Text = "Multi text",
                HorizontalOptions = LayoutOptions.Center
            };

            this.Padding = new Thickness(10, Device.OnPlatform(20, 0, 0), 10, 5);

            // Build the page.
            this.Content = new StackLayout
            {
                Children =
                {
                    header,
                    lblStatus,
                    button,
                    txtDescription
                }
            };
        }

        void OnConnectClicked(object sender, EventArgs e)
        {
            lblStatus.Text = "Connected";
            txtDescription.Text = "Click 1";
        }

    }
}
