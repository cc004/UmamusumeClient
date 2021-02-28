namespace Umamusume.Model
{

    public sealed class TeamStadiumTeamEditRequest : RequestBase<TeamStadiumTeamEditResponse>
    {


        public TeamStadiumTeamData[] team_data_array;



        public int? team_evaluation_point;






        public TeamStadiumTeamEditRequest()
        {
        }
    }
}
