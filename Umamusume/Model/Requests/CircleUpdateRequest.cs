namespace Umamusume.Model
{

    public sealed class CircleUpdateRequest : RequestBase<CircleUpdateResponse>
    {


        public string name;



        public string comment;



        public int? join_conditions;



        public int? join_style;



        public int? policy;






        public CircleUpdateRequest()
        {
        }
    }
}
