using System;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using System.Windows.Input;
using MCPRactice.Views;
using Xamarin.Forms;

namespace MCPRactice.ViewModels
{
    public class MainViewModel : BaseViewModel
    {
        public ICommand SubscribeCommand { get; set; }
        public ICommand SecondPageNavCommand { get; set; }
         

        public ObservableCollection<string> Messages { get; set; }
         
        public MainViewModel(INavigation navigation) : base(navigation)
        {
            Navigation = navigation;
            SubscribeCommand = new Command(OnSubscribeCommand);
            Messages = new ObservableCollection<string>();
            SecondPageNavCommand = new Command(async () => await OnNavSegondPage());
        }

        private async Task OnNavSegondPage( )
        {
            await Navigation.PushAsync(new SecondPage());
        }

        private void OnSubscribeCommand()
        {
            MessagingCenter.Subscribe<Page, DateTime>(this,"tick",(p,dt)=>
            {
                Messages.Add($"Message reviced at {dt}");
            });
        } 
    }
}
