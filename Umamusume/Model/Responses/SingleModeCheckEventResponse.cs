

namespace Umamusume.Model
{

	public sealed class SingleModeCheckEventResponse : ResponseCommon
	{

		public class CommonResponse
		{


			public SingleModeChara chara_info;



			public NotUpParameterInfo not_up_parameter_info;



			public SingleModeHomeInfo home_info;



			public SingleModeEventInfo[] unchecked_event_array;



			public SuccessionEffectedFactor[] event_effected_factor_array;



			public SingleModeRaceCondition[] race_condition_array;



			public SingleRaceStartInfo race_start_info;



			public CommonResponse()
			{
			}
		}



		public CommonResponse data;



		public SingleModeCheckEventResponse()
		{
		}
	}
}
