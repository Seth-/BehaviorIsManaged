

// Generated on 09/23/2012 22:27:05
using System;
using System.Collections.Generic;
using System.Linq;
using BiM.Protocol.Types;
using BiM.Core.IO;
using BiM.Core.Network;

namespace BiM.Protocol.Messages
{
    public class PrismFightJoinLeaveRequestMessage : NetworkMessage
    {
        public const uint Id = 5843;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public bool join;
        
        public PrismFightJoinLeaveRequestMessage()
        {
        }
        
        public PrismFightJoinLeaveRequestMessage(bool join)
        {
            this.join = join;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteBoolean(join);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            join = reader.ReadBoolean();
        }
        
    }
    
}