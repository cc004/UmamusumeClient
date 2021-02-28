using System;



namespace Umamusume.Model
{

	public sealed class FriendSearchRequest : RequestBase<FriendSearchResponse>
	{


		public int? friend_viewer_id;



		protected override string Url => "/friend/search";


        public FriendSearchRequest()
		{
		}
	}
}
