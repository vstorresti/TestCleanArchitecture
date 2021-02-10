using System;
using System.Runtime.Serialization;

namespace api.Domain.Services
{
    [Serializable]
    public class UserEmptyId : Exception
    {
        public UserEmptyId(string message) :
            base(message)
        {
        }
    }
}
