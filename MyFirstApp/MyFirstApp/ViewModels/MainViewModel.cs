using System.ComponentModel.Design;
using MyFirstApp.ViewModels.Base;

namespace MyFirstApp.ViewModels
{
    public class MainViewModel : BaseViewModel
    {
        private int m_myAge = 30;

        private string m_text;
        private int m_yourAge;

        public int YourAge
        {
            get => m_yourAge;
            set
            {
                SetProperty(ref m_yourAge, value);
                if (m_yourAge > m_myAge)
                {
                    Text = "You are older than me :(";
                }
                else if (m_yourAge == m_myAge)
                {
                    Text = "You are as old as me :D";
                }
                else
                {
                    Text = "You are younger than me :(";
                }
                
                Text = m_yourAge > m_myAge ? "You are older than me :(" : "You are younger than me :D";
            }
        }

        public string Text
        {
            get => m_text;
            set => SetProperty(ref m_text, value);
        }
    }
}