

namespace Umamusume.Model
{

	public sealed class ToolPreSignupResponse : ResponseCommon
	{

		public class CommonResponse
		{


			public string nonce;



			public bool attest;



			public CommonResponse()
			{
			}
		}



		public CommonResponse data;



		public ToolPreSignupResponse()
		{
		}
	}
}
