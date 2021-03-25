namespace Umamusume.Model
{

    public sealed class FriendFollowRequest : RequestBase<FriendFollowResponse>
    {
        protected override string Url => "/friend/follow";

        public int? friend_viewer_id;






        public FriendFollowRequest()
        {
        }
    }
}
