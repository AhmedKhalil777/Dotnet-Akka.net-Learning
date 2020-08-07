using Akka.Actor;
using Bdaya.ERP.TestActors.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bdaya.ERP.TestActors.Actors
{
    public class NotificationActor : UntypedActor
    {
        private readonly IEmailNotification _service;
        public NotificationActor(IEmailNotification service)
        {
            _service = service;
        }
        // Actor Recieving message
        protected override void OnReceive(object message)=>_service.Send(message?.ToString());
       
        // Actor Starting
        protected override void PreStart() => Console.WriteLine("Actor Started");

        // Actor finishing
        protected override void PostStop() => Console.WriteLine("Actord Ended");
    }
}
