using System;



namespace Umamusume.Model
{

	public sealed class TrainedCharaRemoveRequest : RequestBase<TrainedCharaRemoveResponse>
	{


		public int[] trained_chara_id_array;



		


		public TrainedCharaRemoveRequest()
		{
		}
	}
}
