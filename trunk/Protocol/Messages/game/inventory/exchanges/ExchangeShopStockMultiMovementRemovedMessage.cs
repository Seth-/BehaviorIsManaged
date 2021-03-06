

// Generated on 09/23/2012 22:27:01
using System;
using System.Collections.Generic;
using System.Linq;
using BiM.Protocol.Types;
using BiM.Core.IO;
using BiM.Core.Network;

namespace BiM.Protocol.Messages
{
    public class ExchangeShopStockMultiMovementRemovedMessage : NetworkMessage
    {
        public const uint Id = 6037;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public int[] objectIdList;
        
        public ExchangeShopStockMultiMovementRemovedMessage()
        {
        }
        
        public ExchangeShopStockMultiMovementRemovedMessage(int[] objectIdList)
        {
            this.objectIdList = objectIdList;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteUShort((ushort)objectIdList.Length);
            foreach (var entry in objectIdList)
            {
                 writer.WriteInt(entry);
            }
        }
        
        public override void Deserialize(IDataReader reader)
        {
            var limit = reader.ReadUShort();
            objectIdList = new int[limit];
            for (int i = 0; i < limit; i++)
            {
                 objectIdList[i] = reader.ReadInt();
            }
        }
        
    }
    
}