using System;



namespace Umamusume.Model
{

    public abstract class RequestBase<TResponseType> : RequestCommon where TResponseType : ResponseCommon
    {
        public string GetFullUrl(string apiroot)
        {
            return apiroot + Url;
        }

        protected virtual string Url => throw new NotImplementedException("apiurl not set");
        protected RequestBase()
        {
        }
    }
}
