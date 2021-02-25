using System;



namespace Umamusume.Model
{

	public sealed class DataLinkChainBySocialAccountRequest : RequestBase<DataLinkChainBySocialAccountResponse>
	{


		public int? chain_type;



		public string openid;



		public int? openid_type;



		


		public DataLinkChainBySocialAccountRequest()
		{
		}
	}
}
