using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Akka.Actor;

namespace NeoHub.BlockTools
{
    public class BlockPersister: UntypedActor
    {
        private IActorRef blockchain;
        private string net;

        public BlockPersister(IActorRef blockchain, string net)
        {
            this.blockchain = blockchain;
            this.net = net;
        }

        protected override void OnReceive(object message)
        {
            Console.WriteLine("...");
        }

        public static Props Props(IActorRef blockchain, string net) =>
            Akka.Actor.Props.Create(() => new BlockPersister(blockchain, net));
    }
}
