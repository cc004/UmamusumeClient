namespace Umamusume.Model
{

    public sealed class TrainedCharaChangeLockRequest : RequestBase<TrainedCharaChangeLockResponse>
    {


        public int? trained_chara_id;



        public int? lock_flag;






        public TrainedCharaChangeLockRequest()
        {
        }
    }
}
