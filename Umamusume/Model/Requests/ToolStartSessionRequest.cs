using System;



namespace Umamusume.Model
{

	public sealed class ToolStartSessionRequest : RequestBase<ToolStartSessionResponse>
	{


		protected override string Url => "/tool/start_session";


        public ToolStartSessionRequest()
		{
		}
	}
}
