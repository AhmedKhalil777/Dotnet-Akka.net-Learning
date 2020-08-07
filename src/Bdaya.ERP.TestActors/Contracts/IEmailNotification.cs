using System;
using System.Collections.Generic;
using System.Security.Principal;
using System.Text;

namespace Bdaya.ERP.TestActors.Contracts
{
    public interface IEmailNotification
    {
        public string Message { get; set; }
        void Send(string messaage);
    }
}
