using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using DataBinding_VM_CS.Models;
using System.ComponentModel;

namespace DataBinding_VM_CS.ViewModels
{
    public class clsMainPageVM: INotifyPropertyChanged
    {
        private clsPersona _personaSeleccionada;
        private ObservableCollection<clsPersona> _listado;

        public event PropertyChangedEventHandler PropertyChanged;

        public clsPersona personaSeleccionada
        {
            get
            {
                return _personaSeleccionada;
            }
            set
            {
                _personaSeleccionada = value;
                OnPropertyChanged("personaSeleccionada"); //Poner el mismo nombre que en el public
            }
        }
        public ObservableCollection<clsPersona> listado
        {
            get
            {
                return _listado;
            }            
        }
        public clsMainPageVM()
        {
            clsListado lista = new clsListado();
            _listado = lista.getListadoPersonas();
        }
        protected void OnPropertyChanged(string name)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(name));
            }
        }

    }
}
