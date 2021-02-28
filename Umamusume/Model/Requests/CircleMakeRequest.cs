namespace Umamusume.Model
{

    public sealed class CircleMakeRequest : RequestBase<CircleMakeResponse>
    {


        public string name;



        public string comment;



        public int? join_style;



        public int? policy;






        public CircleMakeRequest()
        {
        }
    }
}
