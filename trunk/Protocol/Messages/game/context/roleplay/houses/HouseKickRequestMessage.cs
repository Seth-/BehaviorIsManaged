// File generated by 'DofusProtocolBuilder.exe v1.0.0.0'
// From 'HouseKickRequestMessage.xml' the '27/06/2012 15:55:02'
using System;
using BiM.Core.IO;

namespace BiM.Protocol.Messages
{
	public class HouseKickRequestMessage : NetworkMessage
	{
		public const uint Id = 5698;
		public override uint MessageId
		{
			get
			{
				return 5698;
			}
		}
		
		public int id;
		
		public HouseKickRequestMessage()
		{
		}
		
		public HouseKickRequestMessage(int id)
		{
			this.id = id;
		}
		
		public override void Serialize(IDataWriter writer)
		{
			writer.WriteInt(id);
		}
		
		public override void Deserialize(IDataReader reader)
		{
			id = reader.ReadInt();
			if ( id < 0 )
			{
				throw new Exception("Forbidden value on id = " + id + ", it doesn't respect the following condition : id < 0");
			}
		}
	}
}