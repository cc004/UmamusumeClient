namespace Umamusume.Model
{

    public sealed class PresentIndexRequest : RequestBase<PresentIndexResponse>
    {


        public int? time_filter_type;



        public int[] category_filter_type;



        public int? offset;



        public int? limit;



        public bool is_asc;






        public PresentIndexRequest()
        {
        }
    }
}
