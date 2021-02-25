using System;



namespace Umamusume.Model
{

	public sealed class PaymentCancelRequest : RequestBase<PaymentCancelResponse>
	{


		public PaymentStartParam payment;



		


		public PaymentCancelRequest()
		{
		}
	}
}
