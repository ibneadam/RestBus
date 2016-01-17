using System.Collections.Generic;
using System.Net.Http;
namespace RestBus.Common.Amqp
{
    public interface IMessageMapper
    {
        ExchangeConfiguration GetExchangeConfig();
        string GetServiceName(HttpRequestMessage request);
        string GetRoutingKey(HttpRequestMessage request);
        IDictionary<string, object> GetHeaders(HttpRequestMessage request);
    }
}
