using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace MarketplaceLogicLibrary
{
    /// <summary>
    //[Hanin] Manages a collection of users
    /// </summary>
    public class UserCollection
    {
        
        private ObservableCollection<User> _users = new ObservableCollection<User>();
        /// <summary>
        /// A read-only collection that holds User objects
        /// </summary>
        public ReadOnlyObservableCollection<User> Users => new ReadOnlyObservableCollection<User>(_users);
        

        /// <summary>
        /// Adds users to the collection Users
        /// </summary>
        public void AddUser (User user)
        {
            if (_users.Contains(user))
                throw new Exception("User already exists");
            _users.Add(user);
        }

        /// <summary>
        /// Saves the collection of users
        /// </summary>
        /// <param name="dataManager"></param>
        public void SaveUsers(IUserDataManager dataManager)
        {
            dataManager.SaveUsers(_users);
        }

        /// <summary>
        /// Reads saves data from the Json file
        /// </summary>
        /// <param name="dataManager"></param>
        public void ReadAllUsers(IUserDataManager dataManager)
        {
            IEnumerable<User> users = dataManager.ReadAllUsers();
            foreach (User user in users)
            {
                AddUser(user);
            }
        }

    }
}
