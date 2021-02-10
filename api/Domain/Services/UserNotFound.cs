using System;
using System.Runtime.Serialization;

namespace api.Domain.Services
{
    [Serializable]
    public class UserNotFound : Exception
    {
        public UserNotFound(string message) :
            base(message)
        {
        }
    }
}
