using Bdaya.ERP.TestActors.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bdaya.ERP.TestActors.Repositories
{
    public class EmailNotification : IEmailNotification

    {
        public string Message { get; set; }

        public void Send(string messaage)
        {
            Console.WriteLine($"Email Message = {messaage}");
        }
    }
}
