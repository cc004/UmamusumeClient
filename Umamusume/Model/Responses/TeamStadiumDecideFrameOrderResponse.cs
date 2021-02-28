

namespace Umamusume.Model
{

    public sealed class TeamStadiumDecideFrameOrderResponse : ResponseCommon
    {

        public class CommonResponse
        {


            public TeamStadiumFrameOrder[] frame_order_info_array;



            public TeamStadiumTeamData[] user_team_data_array_copy;



            public TrainedChara[] user_trained_chara_array_copy;



            public TeamStadiumOpponent opponent_info_copy;



            public TrainedChara[] opponent_chara_info_array_latest_copy;



            public int? winning_reward_guarantee_status;



            public CommonResponse()
            {
            }
        }



        public CommonResponse data;



        public TeamStadiumDecideFrameOrderResponse()
        {
        }
    }
}
