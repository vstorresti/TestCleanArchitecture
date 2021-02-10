using System;
using System.Runtime.Serialization;

namespace api.Domain.Services
{
    [Serializable]
    public class UserUnique : Exception
    {
        public UserUnique(string message) :
            base(message)
        {
        }
    }
}
