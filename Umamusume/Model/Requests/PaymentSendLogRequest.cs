namespace Umamusume.Model
{

    public sealed class PaymentSendLogRequest : RequestBase<PaymentSendLogResponse>
    {


        public int? log_key;



        public string log_message;






        public PaymentSendLogRequest()
        {
        }
    }
}
