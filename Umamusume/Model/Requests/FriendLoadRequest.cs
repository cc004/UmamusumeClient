namespace Umamusume.Model
{

    public sealed class FriendLoadRequest : RequestBase<FriendLoadResponse>
    {


        protected override string Url => "/friend/index";


        public FriendLoadRequest()
        {
        }
    }
}
