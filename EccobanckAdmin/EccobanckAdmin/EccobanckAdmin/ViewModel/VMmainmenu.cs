using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using EccobanckAdmin.View.Config;

namespace EccobanckAdmin.ViewModel
{
    internal class VMmainmenu : BaseViewModel
    {
        #region VARIABLES
        string identificacion;
        #endregion
        #region CONSTRUCTOR
        public VMmainmenu(INavigation navigation)
        {
            Navigation = navigation;
            Navegarmenuconfigcommand = new Command(async() => await NavegarMenuConfig());
        }
        #endregion
        #region OBJETOS
        public string Identificacion
        {
            get { return identificacion; }
            set { SetValue(ref identificacion, value); }
        }
        #endregion
        #region PROCESOS
        private async Task NavegarMenuConfig()
        {
            await Navigation.PushAsync(new MenuConfig());
        }
        #endregion
        #region COMANDOS
        public Command Navegarmenuconfigcommand { get; set; }
        #endregion
    }
}
