using System;



namespace Umamusume.Model
{

	public sealed class ChangeNameRequest : RequestBase<ChangeNameResponse>
	{


		public string name;



		protected override string Url => "/user/change_name";


        public ChangeNameRequest()
		{
		}
	}
}
