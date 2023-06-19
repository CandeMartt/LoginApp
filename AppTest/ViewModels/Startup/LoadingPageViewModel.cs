using AppTest.Controls;
using AppTest.Models;
using AppTest.Views.Dashboard;
using AppTest.Views.Startup;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppTest.ViewModels.Startup
{
    public class LoadingPageViewModel
    {
        public LoadingPageViewModel()
        {
            CheckUserLoginDetails();
        }

        private async void CheckUserLoginDetails()
        {
            string userDetailsStr = Preferences.Get(nameof(App.UserDetails), "");
            if(string.IsNullOrEmpty(userDetailsStr))
            {
                // navigate to login Page
                await Shell.Current.GoToAsync($"//{nameof(LoginPage)}");
            }
            else 
            {
                var userInfo = JsonConvert.DeserializeObject<UserBasicInfo>(userDetailsStr);
                App.UserDetails = userInfo;
                await AppConstant.AddFlyoutMenusDetails();
            }
        }
    }
}
