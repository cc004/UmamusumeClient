using System;



namespace Umamusume.Model
{

	public sealed class PaymentStartRequest : RequestBase<PaymentStartResponse>
	{


		public PaymentStartParam payment;



		public int? isalertagree;



		public int? isalertactive;



		


		public PaymentStartRequest()
		{
		}
	}
}
