﻿using BlazorPrettyCode;
using BlazorTypography;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection;
using SamplePages;
using System.Threading.Tasks;

namespace Sample
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);

            //Configure Services
            builder.Services.AddBaseAddressHttpClient();
            builder.Services.AddTypography();
            builder.Services.AddBlazorPrettyCode(config =>
            {
                config.ShowLineNumbers = true;
                config.DefaultTheme = "SolarizedLight";
            });

            //End Configure Services

            builder.RootComponents.Add<App>("app");

            await builder.Build().RunAsync();
        }
    }
}
