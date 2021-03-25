namespace Umamusume.Model
{

    public sealed class SingleModeRentalInfoRequest : RequestBase<SingleModeRentalInfoResponse>
    {

        protected override string Url => "/single_mode/rental_info";



        public SingleModeRentalInfoRequest()
        {
        }
    }
}
