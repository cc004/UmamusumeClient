namespace Umamusume.Model
{

    public sealed class LoginRequest : RequestBase<LoginResponse>
    {


        protected override string Url => "/load/index";


        public LoginRequest()
        {
        }
    }
}
