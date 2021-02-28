namespace Umamusume.Model
{

    public sealed class SupportCardChangeLockRequest : RequestBase<SupportCardChangeLockResponse>
    {


        public int? support_card_id;



        public int? lock_flag;






        public SupportCardChangeLockRequest()
        {
        }
    }
}
