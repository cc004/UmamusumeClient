

namespace Umamusume.Model
{

	public sealed class DebugRaceSimulateResponse : ResponseCommon
	{

		public class CommonResponse
		{


			public string race_scenario;



			public RaceSimulateResult[] result_array;



			public TeamStadiumResultTeam result_team;



			public CommonResponse()
			{
			}
		}



		public CommonResponse data;



		public DebugRaceSimulateResponse()
		{
		}
	}
}
