using System;



namespace Umamusume.Model
{

	public sealed class SingleModeExecCommandRequest : RequestBase<SingleModeExecCommandResponse>
	{


		public int? command_type;



		public int? command_id;



		public int? command_group_id;



		public int? select_id;



		


		public SingleModeExecCommandRequest()
		{
		}
	}
}
