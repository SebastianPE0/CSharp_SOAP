namespace CSharp_Soap
{
    using System;
    using System.ServiceModel;
    using SoapCore;
    using Microsoft.AspNetCore.Mvc;

    [ServiceContract]
    public interface IWebhookService
    {
        [OperationContract]
        string HandleWebhook(string message);
    }

    public class WebhookService : IWebhookService
    {
        public string HandleWebhook(string message)
        {
            return $"Received message: {"Hello_WORLD"}";
        }
    }
}