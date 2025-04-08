using System.ComponentModel;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using ModelContextProtocol.Server;
using StarwarsMCP;

var builder = Host.CreateEmptyApplicationBuilder (settings: null);

builder.Services
	.AddMcpServer ()
	.WithStdioServerTransport ()
	.WithToolsFromAssembly ();

builder.Services.AddSingleton<StarwarsService> ();

await builder.Build ().RunAsync ();