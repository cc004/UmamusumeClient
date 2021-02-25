

namespace Umamusume.Model
{

	public sealed class DataLinkChainBySocialAccountResponse : ResponseCommon
	{

		public class CommonResponse
		{


			public string social_account_id;



			public int? social_account_type;



			public string auth_key;



			public CommonResponse()
			{
			}
		}



		public CommonResponse data;



		public DataLinkChainBySocialAccountResponse()
		{
		}
	}
}
