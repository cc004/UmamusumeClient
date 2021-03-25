namespace Umamusume.Model
{

    public sealed class SupportCardDeckChangePartyRequest : RequestBase<SupportCardDeckChangePartyResponse>
    {

        protected override string Url => "/support_card_deck/change_party";
        public UserSupportCardDeckForUpdateParty[] support_card_deck_array;






        public SupportCardDeckChangePartyRequest()
        {
        }
    }
}
