using Android.App;
using Android.Widget;
using Android.OS;
using Android.Content;
using Android.Views.InputMethods;

namespace POCAndroid
{
    [Activity(Label = "POCAndroid", MainLauncher = true)]
    public class MainActivity : Activity
    {
        InputMethodManager imm;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            imm = (InputMethodManager)GetSystemService(Context.InputMethodService);

            var btnConnect = FindViewById<Button>(Resource.Id.btnConnect);
            var txtStatus = FindViewById<EditText>(Resource.Id.txtStatus);
            var txtDesciption = FindViewById<EditText>(Resource.Id.txtDesciption);

            btnConnect.Click += (sender, e) =>
            {
                txtStatus.Text = "Conneted";
                txtDesciption.Text = "123";
            };
        }
    }
}

