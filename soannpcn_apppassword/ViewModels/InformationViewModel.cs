using soannpcn_apppassword.Models;
using soannpcn_apppassword.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace soannpcn_apppassword.ViewModels
{
    public class InformationViewModel : BaseViewModel
    {
        public PasswordService PasswordService;
        public ObservableCollection<Data> DataApp { get; }

        public Command LoadAppCommand { get; set; }

        public InformationViewModel()
        {
            Title = "Information";

            PasswordService = new PasswordService();
            DataApp = new ObservableCollection<Data>();
            LoadAppCommand = new Command(async () => await ExecuteLoadAppCommand());


        }

        async Task ExecuteLoadAppCommand()
        {
            IsBusy = false;

            try
            {
                DataApp.Clear();
                var data = await PasswordService.GetAppAsync(true);
                foreach (var dat in data)
                {
                    DataApp.Add(dat);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
            finally
            {
                IsBusy = false;
            }
        }

        public async void GetAllapps()
        {
            var datapp = await PasswordService.GetAppAsync();

            foreach (var dat in DataApp)
            {
                DataApp.Add(dat);
               
            }
        }

    }

    
}
