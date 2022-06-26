namespace Umamusume.Model
{

    public sealed class ToolGetPreDownloadResourceVersionRequest : RequestBase<ToolGetPreDownloadResourceVersionResponse>
    {
        protected override string Url => "/tool/get_pre_download_resource_version";


        public ToolGetPreDownloadResourceVersionRequest()
        {
        }
    }
}
