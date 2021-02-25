

namespace Umamusume.Model
{

	public sealed class SingleModeExecCommandResponse : ResponseCommon
	{

		public class CommonResponse
		{


			public SingleModeChara chara_info;



			public SingleModeRaceCondition[] race_condition_array;



			public NotUpParameterInfo not_up_parameter_info;



			public SingleModeHomeInfo home_info;



			public SingleModeCommandResult command_result;



			public SingleModeEventInfo[] unchecked_event_array;



			public CommonResponse()
			{
			}
		}



		public CommonResponse data;



		public SingleModeExecCommandResponse()
		{
		}
	}
}
