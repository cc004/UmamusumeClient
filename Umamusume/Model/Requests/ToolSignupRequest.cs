using System;



namespace Umamusume.Model
{

	public sealed class ToolSignupRequest : RequestBase<ToolSignupResponse>
	{


		public string credential;



		public int? error_code;



		public string error_message;



		protected override string Url => "/tool/signup";


        public ToolSignupRequest()
		{
		}
	}
}
