namespace Umamusume.Model
{

    public sealed class TutorialTeamEditRequest : RequestBase<TutorialTeamEditResponse>
    {


        public TeamStadiumTeamData[] team_data_array;



        public int? team_evaluation_point;






        public TutorialTeamEditRequest()
        {
        }
    }
}
