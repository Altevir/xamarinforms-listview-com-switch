using AppRTC.ViewModel;
using ListViewSwitch.Model;
using System;
using System.Collections.ObjectModel;

namespace ListViewSwitch.ViewModel
{
    public class ClienteViewModel : BaseViewModel
    {
        public ClienteViewModel()
        {
            LoadClientesAsync();
        }

        private ObservableCollection<Cliente> _clientes;
        public ObservableCollection<Cliente> Clientes
        {
            get { return _clientes; }
            set
            {
                SetProperty(ref _clientes, value);
            }
        }

        void LoadClientesAsync()
        {
            Clientes = new ObservableCollection<Cliente>();
            Clientes.Add(new Cliente() { Id = Guid.NewGuid().ToString() });
            Clientes.Add(new Cliente() { Id = Guid.NewGuid().ToString() });
            Clientes.Add(new Cliente() { Id = Guid.NewGuid().ToString() });
        }
    }
}
