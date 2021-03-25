namespace Umamusume.Model
{

    public sealed class FriendUnFollowRequest : RequestBase<FriendUnFollowResponse>
    {
        protected override string Url => "/friend/un_follow";

        public int? friend_viewer_id;






        public FriendUnFollowRequest()
        {
        }
    }
}
