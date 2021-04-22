using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Json;
using System.Text;

namespace MarketplaceLogicLibrary
{
    public class JsonUserDataManager : IUserDataManager
    {
        private string _dataFilePath;
        public JsonUserDataManager (string dataFilePath)
        {
            _dataFilePath = dataFilePath;
        }
        public IEnumerable<User> ReadAllUsers()
        {
            using (FileStream fileStream = new FileStream(_dataFilePath, FileMode.Open))
            {
                DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(IEnumerable<User>));
                return serializer.ReadObject(fileStream) as IEnumerable<User>;
            }
        }

        public void SaveUsers(IEnumerable<User> users)
        {
            using (FileStream fileStream = new FileStream(_dataFilePath, FileMode.Create))
            {
                DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(IEnumerable<User>));
                serializer.WriteObject(fileStream, users);
            }
        }
    }
}
