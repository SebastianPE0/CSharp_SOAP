using CSharp_Soap;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using SoapCore;

var builder = WebApplication.CreateBuilder(args);

// Agregar SoapCore al contenedor de servicios
builder.Services.AddSoapCore();
builder.Services.AddSingleton<IWebhookService, WebhookService>();

var app = builder.Build();

// Configurar los endpoints SOAP utilizando IApplicationBuilder
app.UseRouting();

// Configura el servicio SOAP en la ruta '/WebhookService'
app.UseEndpoints(endpoints =>
{
    endpoints.UseSoapEndpoint<IWebhookService>("/WebhookService", new SoapEncoderOptions(), SoapSerializer.XmlSerializer);
});

app.Run();
