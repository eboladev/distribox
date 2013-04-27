﻿namespace Distribox.Network
{
    /// <summary>
    /// Message of propagating peer list.
    /// </summary>
    internal class PeerListMessage : ProtocolMessage
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Distribox.Network.PeerListMessage"/> class.
        /// </summary>
        /// <param name="list">List.</param>
        /// <param name="port">Port.</param>
        public PeerListMessage(PeerList list, int port) : base(port)
        {
            this.List = list;
            this.Type = MessageType.PeerListMessage;
        }

        /// <summary>
        /// Gets the peer list.
        /// </summary>
        /// <value>The list.</value>
        public PeerList List { get; set; }

        /// <summary>
        /// Accept the specified visitor and peer.
        /// </summary>
        /// <param name="visitor">Visitor.</param>
        /// <param name="peer">Peer.</param>
        public override void Accept(AntiEntropyProtocol visitor, Peer peer)
        {
            visitor.Process(this, peer);
        }
    }
}