namespace ChurchNodes.Langs.PowerFx
{
    using Microsoft.PowerFx;
    using Microsoft.PowerFx.Core;
    using Microsoft.PowerFx.Intellisense;
    using System;
    using System.Web;

    public class PowerFxScopeFactory : IPowerFxScopeFactory
    {
        private RecalcEngine recalcEngine;

        // Ensure that we're getting the same engine used by intellisense (LSP) and evaluation.
        public PowerFxScopeFactory(RecalcEngine recalcEngine)
        {
            this.recalcEngine = recalcEngine;
        }

        // Uri is passed in from the front-end and specifies which formula bar. 
        // Returns an object that provides intellisense support. 
        public IPowerFxScope GetOrCreateInstance(string documentUri)
        {
            // The host could pass in additional information in the Uri here to help 
            // initialize a formula bar or distinguish between multiple formula bars. 

            // The context is additional symbols passed by the host.             
            var uriObj = new Uri(documentUri);
            var contextJson = HttpUtility.ParseQueryString(uriObj.Query).Get("context");
            if (contextJson == null)
            {
                contextJson = "{}";
            }

            var scope = RecalcEngineScope.FromJson(recalcEngine, contextJson);
            return scope;
        }
    }
}
