using System;



namespace Umamusume.Model
{

	public sealed class DebugSingleModeStoryDirectRequest : RequestBase<DebugSingleModeStoryDirectResponse>
	{


		public int? event_contents_id;



		public int? card_id;



		public int? choice_number;



		


		public DebugSingleModeStoryDirectRequest()
		{
		}
	}
}
