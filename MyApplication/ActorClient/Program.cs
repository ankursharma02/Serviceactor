
using System;
using System.Threading.Tasks;
using Microsoft.ServiceFabric.Actors;
using Microsoft.ServiceFabric.Actors.Client;
using HelloWord.Interfaces;


namespace ActorClient
{
    class Program
    {
        static void Main(string[] args)
        {
            IHelloWord actor = ActorProxy.Create<IHelloWord>(ActorId.CreateRandom(), new Uri("fabric:/MyApplication/HelloWordActorService"));
            Task<string> retval = actor.GetHelloWordAsync();
            Console.Write(retval.Result);
            Console.ReadLine();
        }
    }
}
