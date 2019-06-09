using System.ComponentModel.Design;
using System.Windows.Input;
using MyFirstApp.ViewModels.Base;
using Xamarin.Forms;

namespace MyFirstApp.ViewModels
{
    public class MainViewModel : BaseViewModel
    {
        public MainViewModel()
        {
            OneOverFourCommand = new Command(() => YourAge = (int)(MaximumAge * 0.25D));
            TwoOverFourCommand = new Command(() => YourAge = (int)(MaximumAge * 0.5D));
            ThreeOverFourCommand = new Command(() => YourAge = (int)(MaximumAge * 0.75D));
            FourOverFourCommand = new Command(() => YourAge = MaximumAge * 1);
        }
        private int m_myAge = 30;

        private string m_text;
        private int m_yourAge;
        private string m_icon;

        public int YourAge
        {
            get => m_yourAge;
            set
            {
                SetProperty(ref m_yourAge, value);
                if (m_yourAge > m_myAge)
                {
                    Text = "You are older than me";
                    Icon = "\uf1f7";
                }
                else if (m_yourAge == m_myAge)
                {
                    Text = "You are as old as me";
                    Icon = "\ufc4f";
                }
                else
                {
                    Text = "You are younger than me";
                    Icon = "\uf1f4";
                }
            }
        }

        public string Text
        {
            get => m_text;
            set => SetProperty(ref m_text, value);
        }

        public string Icon
        {
            get => m_icon;
            set => SetProperty(ref m_icon, value);
        }

        public ICommand OneOverFourCommand { get; }

        public ICommand TwoOverFourCommand { get; }

        public ICommand ThreeOverFourCommand { get; }

        public ICommand FourOverFourCommand { get; }

        public int MaximumAge { get; } = 132;
    }
}