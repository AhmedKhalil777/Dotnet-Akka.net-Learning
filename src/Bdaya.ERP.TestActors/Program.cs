using Akka.Actor;
using Akka.DI.Core;
using Akka.DI.Extensions.DependencyInjection;
using Bdaya.ERP.TestActors.Actors;
using Bdaya.ERP.TestActors.Contracts;
using Bdaya.ERP.TestActors.Repositories;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Threading;

namespace Bdaya.ERP.TestActors
{
    class Program
    {
        static void Main(string[] args)
        {
            var serviceCollection = new ServiceCollection();
            serviceCollection.AddSingleton<IEmailNotification, EmailNotification>();
            serviceCollection.AddSingleton<NotificationActor>();
            var serviceProvider =  serviceCollection.BuildServiceProvider();
            var actorSystem = ActorSystem.Create("My-Test-Actor");
            actorSystem.UseServiceProvider(serviceProvider);
            var actor = actorSystem.ActorOf(actorSystem.DI().Props<NotificationActor>());
            actor.Tell("Hello I am a notification actor");

            Thread.Sleep(5000);
            actorSystem.Stop(actor);

            Thread.Sleep(5000);

        }
    }
}
