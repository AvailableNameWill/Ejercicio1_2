using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.Security;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Ejercicio1_2
{
    public partial class MainPage : ContentPage
    {
        public MainPage(){
            InitializeComponent();
        }

        async void btnSendInfo_Clicked(object sender, EventArgs e) {
            if (!String.IsNullOrEmpty(txtName.Text) || !String.IsNullOrWhiteSpace(txtName.Text) ||
                !String.IsNullOrEmpty(txtSecName.Text) || !String.IsNullOrWhiteSpace(txtSecName.Text) ||
                !String.IsNullOrEmpty(txtAge.Text) || !String.IsNullOrWhiteSpace(txtAge.Text) ||
                !String.IsNullOrEmpty(txtEmail.Text) || !String.IsNullOrWhiteSpace(txtEmail.Text))
            {
                string _name = txtName.Text;
                string _secName = txtSecName.Text;
                int _age = Convert.ToInt32(txtAge.Text);
                string _email = txtEmail.Text;
                var persona = new Persona {
                    name = _name, sec_Name = _secName, age = _age, email = _email
                };
                var dataPage = new DataPage();
                dataPage.BindingContext = persona;
                await Navigation.PushAsync(dataPage);
            }
            else Console.WriteLine("vacio");
        }

        private void clean(){
            
        }
    }
}
