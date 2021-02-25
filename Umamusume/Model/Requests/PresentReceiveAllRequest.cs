using System;



namespace Umamusume.Model
{

	public sealed class PresentReceiveAllRequest : RequestBase<PresentReceiveAllResponse>
	{


		public int? time_filter_type;



		public int[] category_filter_type;



		public bool is_asc;




		protected override string Url => "/present/receive_all";


		public PresentReceiveAllRequest()
		{
		}
	}
}
