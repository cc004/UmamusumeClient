using System;



namespace Umamusume.Model
{

	public sealed class DataLinkPublishTransitionCodeRequest : RequestBase<DataLinkPublishTransitionCodeResponse>
	{


		public string password;


        protected override string Url => "/account/publish_transition_code";



        public DataLinkPublishTransitionCodeRequest()
		{
		}
	}
}
