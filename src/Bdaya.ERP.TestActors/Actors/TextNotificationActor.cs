using Akka.Actor;
using System;

namespace Bdaya.ERP.TestActors.Actors
{
    public class TextNotificationActor : UntypedActor
    {
        protected override void OnReceive(object message) => Console.WriteLine($"Sent Message is = {message}");
        protected override void PreStart() => Console.WriteLine("Listner Actor Started");
        protected override void PostStop() => Console.WriteLine("Listner Actor Stoped");
       
    }

}
