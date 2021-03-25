namespace Umamusume.Model
{

    public sealed class RecoveryTrainerPointRequest : RequestBase<RecoveryTrainerPointResponse>
    {

        protected override string Url => "/user/recovery_trainer_point";
        
        public int? count;



        public int? client_own_num;






        public RecoveryTrainerPointRequest()
        {
        }
    }
}
