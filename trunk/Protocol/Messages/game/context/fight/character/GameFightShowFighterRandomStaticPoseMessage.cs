// File generated by 'DofusProtocolBuilder.exe v1.0.0.0'
// From 'GameFightShowFighterRandomStaticPoseMessage.xml' the '27/06/2012 15:55:01'
using System;
using BiM.Core.IO;

namespace BiM.Protocol.Messages
{
	public class GameFightShowFighterRandomStaticPoseMessage : GameFightShowFighterMessage
	{
		public const uint Id = 6218;
		public override uint MessageId
		{
			get
			{
				return 6218;
			}
		}
		
		
		public GameFightShowFighterRandomStaticPoseMessage()
		{
		}
		
		public GameFightShowFighterRandomStaticPoseMessage(Types.GameFightFighterInformations informations)
			 : base(informations)
		{
		}
		
		public override void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
		}
		
		public override void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
		}
	}
}