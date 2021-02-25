using System;



namespace Umamusume.Model
{

	public sealed class CircleConditionalSearchRequest : RequestBase<CircleConditionalSearchResponse>
	{


		public string keyword;



		public int? join_style;



		public int? policy;



		public int? member_num;



		


		public CircleConditionalSearchRequest()
		{
		}
	}
}
