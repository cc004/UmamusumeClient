namespace Umamusume.Model
{
    public sealed class PreSingleModeIndexResponse : ResponseCommon
    {
        public class CommonResponse
        {
            public SingleModeFriendSupportCard friend_support_card_data;
            
            public SingleModeSuccessionTrainedChara succession_trained_chara_data;
            public CommonResponse()
            {
            }
        }
        
        public CommonResponse data;
        public PreSingleModeIndexResponse()
        {
        }
    }
}