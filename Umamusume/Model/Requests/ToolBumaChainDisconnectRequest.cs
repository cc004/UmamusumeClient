using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Umamusume.Model.Requests
{
    public sealed class ToolBumaChainDisconnectResponse : ResponseCommon
    {

    }

    public sealed class ToolBumaChainDisconnectRequest : RequestBase<ToolBumaChainDisconnectResponse>
    {
        protected override string Url => "/tool/buma_chain_disconnect";
    }
}
