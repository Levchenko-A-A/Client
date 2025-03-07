using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClientProject.Model;


namespace ClientProject.ViewModel
{
    internal class ClientViewModel: BaseViewModel
    {
        public ObservableCollection<ClientProject.Model.Client> Clients { get; set; }

        public ClientViewModel()
        {
            ClientProject.Model.Client
        }
    }
}
