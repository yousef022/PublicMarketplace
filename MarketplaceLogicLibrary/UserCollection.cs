using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace MarketplaceLogicLibrary
{
    public class UserCollection
    {
        private ObservableCollection<User> _users = new ObservableCollection<User>();
        public ReadOnlyObservableCollection<User> Users => new ReadOnlyObservableCollection<User>(_users);
        

        //Add Users


        //Save

        //Read

    }
}
