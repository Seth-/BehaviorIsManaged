

// Generated on 09/23/2012 22:27:11
using System;
using System.Collections.Generic;
using System.Linq;
using BiM.Core.IO;

namespace BiM.Protocol.Types
{
    public class UpdateMountBoost
    {
        public const short Id = 356;
        public virtual short TypeId
        {
            get { return Id; }
        }
        
        public sbyte type;
        
        public UpdateMountBoost()
        {
        }
        
        public UpdateMountBoost(sbyte type)
        {
            this.type = type;
        }
        
        public virtual void Serialize(IDataWriter writer)
        {
            writer.WriteSByte(type);
        }
        
        public virtual void Deserialize(IDataReader reader)
        {
            type = reader.ReadSByte();
        }
        
    }
    
}