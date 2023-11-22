using ESP32_SERVER.ViewModels;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESP32_SERVER;
public partial class App
{
    private IServiceProvider _serviceProvider;

    public static IServiceProvider Services
    {
        get
        {
            IServiceProvider serviceProvider = ((App)Current)._serviceProvider
                ?? throw new InvalidOperationException("The service provider is not initialized");
            return serviceProvider;
        }
    }

    private static IServiceProvider ConfigureServices()
    {
        var provider = new ServiceCollection()
            //.AddSingleton<IPrefixMaker, EnglishPrefixMaker>()
            //.AddSingleton<IPrefixMaker, FrenchPrefixMaker>()
            .AddTransient<MainPageViewModel>()
            .BuildServiceProvider(true);

        return provider;
    }
}
