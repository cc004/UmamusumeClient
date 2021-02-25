

namespace Umamusume.Model
{

	public sealed class MissionReceiveResponse : ResponseCommon
	{

		public class CommonResponse
		{


			public RewardSummaryInfo reward_summary_info;



			public UserMission[] updated_mission_array;



			public CommonResponse()
			{
			}
		}



		public CommonResponse data;



		public MissionReceiveResponse()
		{
		}
	}
}
