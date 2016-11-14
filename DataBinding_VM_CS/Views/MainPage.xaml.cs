using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// La plantilla de elemento Página en blanco está documentada en http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace DataBinding_VM_CS
{
    /// <summary>
    /// Página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        //Para que se guarden los cambios
        private void saveChanges(object sender, RoutedEventArgs e)
        {
            this.myName.GetBindingExpression(TextBox.TextProperty).UpdateSource();
            this.mySurname.GetBindingExpression(TextBox.TextProperty).UpdateSource();
            this.myAge.GetBindingExpression(TextBox.TextProperty).UpdateSource();
            this.myTlfn.GetBindingExpression(TextBox.TextProperty).UpdateSource();
            this.myAddress.GetBindingExpression(TextBox.TextProperty).UpdateSource();
        }
    }
}
