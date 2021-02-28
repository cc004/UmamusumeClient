namespace Umamusume.Model
{

    public sealed class UserChangeSexRequest : RequestBase<UserChangeSexResponse>
    {


        public int? sex;




        protected override string Url => "/user/change_sex";


        public UserChangeSexRequest()
        {
        }
    }
}
