// File generated by 'DofusProtocolBuilder.exe v1.0.0.0'
// From 'ShortcutObjectItem.xml' the '27/06/2012 15:55:17'
using System;
using BiM.Core.IO;

namespace BiM.Protocol.Types
{
	public class ShortcutObjectItem : ShortcutObject
	{
		public const uint Id = 371;
		public override short TypeId
		{
			get
			{
				return 371;
			}
		}
		
		public int itemUID;
		public int itemGID;
		
		public ShortcutObjectItem()
		{
		}
		
		public ShortcutObjectItem(int slot, int itemUID, int itemGID)
			 : base(slot)
		{
			this.itemUID = itemUID;
			this.itemGID = itemGID;
		}
		
		public override void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteInt(itemUID);
			writer.WriteInt(itemGID);
		}
		
		public override void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			itemUID = reader.ReadInt();
			itemGID = reader.ReadInt();
		}
	}
}