using Microsoft.PowerFx;
using Microsoft.PowerFx.Core;
using Microsoft.PowerFx.LanguageServerProtocol;
using Microsoft.PowerFx.Types;
using System.Text.Json;

namespace ChurchNodes.Langs.PowerFx
{
    public class PowerFxService
    {
        private IPowerFxScopeFactory scopeFactory;
        private RecalcEngine recalcEngine;
        private LanguageServer languageServer;
        private List<string> sendToClientData;

        public PowerFxService(RecalcEngine recalcEngine, IPowerFxScopeFactory scopeFactory)
        {
            this.scopeFactory = scopeFactory;
            this.recalcEngine = recalcEngine;

            this.sendToClientData = new List<string>();
            this.languageServer = new LanguageServer((string data) => sendToClientData.Add(data), scopeFactory);
        }

        public object Eval<TBody>(TBody body)
        {
            languageServer.OnDataReceived(JsonSerializer.Serialize(body));
            return sendToClientData.ToArray();
        }

        public (string result, string error) Eval<TBody>(string expression, TBody body)
        {
            string input = default;
            if (body is string)
                input = (string)(object)body;
            else
                input = JsonSerializer.Serialize(body);

            var parameters = (RecordValue)FormulaValue.FromJson(input);
            var result = recalcEngine.Eval(expression, parameters);

            var resultString = PowerFxHelper.TestToString(result);

            return (resultString, null);
        }
    }
}
