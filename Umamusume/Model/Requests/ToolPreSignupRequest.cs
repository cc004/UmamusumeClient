using System;



namespace Umamusume.Model
{

	public sealed class ToolPreSignupRequest : RequestBase<ToolPreSignupResponse>
	{
		protected override string Url => "/tool/pre_signup";

        


		public ToolPreSignupRequest()
		{
		}
	}
}
