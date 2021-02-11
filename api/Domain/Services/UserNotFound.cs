using System;

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
