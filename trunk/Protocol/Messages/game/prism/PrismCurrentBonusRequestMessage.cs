

// Generated on 09/23/2012 22:27:04
using System;
using System.Collections.Generic;
using System.Linq;
using BiM.Protocol.Types;
using BiM.Core.IO;
using BiM.Core.Network;

namespace BiM.Protocol.Messages
{
    public class PrismCurrentBonusRequestMessage : NetworkMessage
    {
        public const uint Id = 5840;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        
        public PrismCurrentBonusRequestMessage()
        {
        }
        
        
        public override void Serialize(IDataWriter writer)
        {
        }
        
        public override void Deserialize(IDataReader reader)
        {
        }
        
    }
    
}