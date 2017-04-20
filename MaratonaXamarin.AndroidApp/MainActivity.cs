using Android.App;
using Android.Widget;
using Android.OS;
using MaratonaXamarin.Shared;
using System;
using System.Linq;

namespace MaratonaXamarin.AndroidApp
{
    [Activity(Label = "MaratonaXamarin.AndroidApp", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView (Resource.Layout.Main);

            var button = this.FindViewById<Button>(Resource.Id.btnCarregar);
            var listview = this.FindViewById<ListView>(Resource.Id.lvwItems);

            button.Click += async (sender, e) =>
            {
                try
                {
                    var api = new UserApi();

                    var users = await api.ListAsync(new Developer
                    {
                        Id = Guid.NewGuid().ToString(),
                        Name = "Angelo",
                        Email = "angelo@angelo.com",
                        State = "SP",
                        City = "Carapicuiba"
                    });

                    listview.Adapter = new ArrayAdapter(this, Android.Resource.Layout.SimpleListItemSingleChoice,
                        users.OrderBy(y => y.Name).Select(x => $"{x.Id} { x.Name}").ToArray());
                }
                catch(Exception ex)
                {
                    string s = ex.Message;
                }
            };
        }
    }
}

