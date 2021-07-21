using System;

namespace UBSI_Ops.server.Exceptions
{
    public class LoginException : Exception
    {
        public LoginException(string message) : base(message)
        {
        }

        public static LoginException CredentialsMismatch() =>
            new LoginException("CredentialsMismatch");

        public static LoginException AccountDeactivated() =>
            new LoginException("AccountDeactivated");
    }
}
