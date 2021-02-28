namespace Umamusume.Model
{

    public sealed class PresentHistoryRequest : RequestBase<PresentHistoryResponse>
    {


        public int[] category_filter_type;



        public int? offset;



        public int? limit;



        public bool is_asc;






        public PresentHistoryRequest()
        {
        }
    }
}
