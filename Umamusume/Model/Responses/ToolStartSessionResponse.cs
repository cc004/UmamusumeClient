

namespace Umamusume.Model
{

	public sealed class ToolStartSessionResponse : ResponseCommon
	{

		public class CommonResponse
		{


			public bool is_tutorial;



			public string resource_version;



			public bool attest;



			public string nonce;



			public bool terms_updated;



			public string auth_key;



			public CommonResponse()
			{
			}
		}



		public CommonResponse data;



		public ToolStartSessionResponse()
		{
		}
	}
}
