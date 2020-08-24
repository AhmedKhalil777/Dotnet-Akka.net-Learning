using Akka.Actor;
using Akka.DI.Core;
using Bdaya.ERP.TestActors.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bdaya.ERP.TestActors.Actors
{
    public class NotificationActor : UntypedActor
    {
        private readonly IEmailNotification _service;
        private readonly IActorRef _childActor;
        public NotificationActor(IEmailNotification service)
        {
            _service = service;
            _childActor = Context.ActorOf(Context.System.DI().Props<TextNotificationActor>());
        }
        // Actor Recieving message
        protected override void OnReceive(object message)
        {
            _service.Send(message?.ToString());
            _childActor.Tell(message);
        }
       
        // Actor Starting
        protected override void PreStart() => Console.WriteLine("Actor Started");

        // Actor finishing
        protected override void PostStop() => Console.WriteLine("Actord Ended");
    }
}
