using System;



namespace Umamusume.Model
{

	public sealed class DataLinkPublishTransitionCodeRequest : RequestBase<DataLinkPublishTransitionCodeResponse>
	{


		public string password;


        protected override string Url => "/account/public_transition_code";



        public DataLinkPublishTransitionCodeRequest()
		{
		}
	}
}
