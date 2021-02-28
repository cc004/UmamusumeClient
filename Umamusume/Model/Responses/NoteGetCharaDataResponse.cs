

namespace Umamusume.Model
{

    public sealed class NoteGetCharaDataResponse : ResponseCommon
    {

        public class CommonResponse
        {


            public NoteDataForDisplay[] voice_data_array;



            public int? dress_id;



            public int? mini_dress_id;



            public CommonResponse()
            {
            }
        }



        public CommonResponse data;



        public NoteGetCharaDataResponse()
        {
        }
    }
}
