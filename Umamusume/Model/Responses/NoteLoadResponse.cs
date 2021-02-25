

namespace Umamusume.Model
{

	public sealed class NoteLoadResponse : ResponseCommon
	{

		public class CommonResponse
		{


			public DisplayRewardInfo[] reward_info_array;



			public int? before_directory_level;



			public int? rank_score;



			public int[] release_card_array;



			public DirectoryScoreSummary score_summary;



			public CommonResponse()
			{
			}
		}



		public CommonResponse data;



		public NoteLoadResponse()
		{
		}
	}
}
