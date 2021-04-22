using System;
using System.Collections.Generic;
using System.Text;

namespace MarketplaceLogicLibrary
{
    /// <summary>
    /// [Hanin] Interface for user data manager
    /// </summary>
    public interface IUserDataManager
    {
        void SaveUsers(IEnumerable<User> users);

        IEnumerable<User> ReadAllUsers();
    }
}
