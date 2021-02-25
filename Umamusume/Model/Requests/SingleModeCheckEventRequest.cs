using System;



namespace Umamusume.Model
{

	public sealed class SingleModeCheckEventRequest : RequestBase<SingleModeCheckEventResponse>
	{


		public int? event_id;



		public int? chara_id;



		public int? choice_number;



		


		public SingleModeCheckEventRequest()
		{
		}
	}
}
