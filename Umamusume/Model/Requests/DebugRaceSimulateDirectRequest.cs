using System;



namespace Umamusume.Model
{

	public sealed class DebugRaceSimulateDirectRequest : RequestBase<DebugRaceSimulateDirectResponse>
	{


		public string simulator_version;



		public string simulate_resource_version;



		public string simulate_data;



		


		public DebugRaceSimulateDirectRequest()
		{
		}
	}
}
