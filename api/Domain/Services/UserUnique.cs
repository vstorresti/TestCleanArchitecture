using System;

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
