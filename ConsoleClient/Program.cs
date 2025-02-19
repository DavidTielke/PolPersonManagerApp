using DavidTielke.PMA.Data.DataStoring;
using DavidTielke.PMA.Data.FileStoring;
using DavidTielke.PMA.Logic.PersonManagement;
using Mappings;
using Microsoft.Extensions.DependencyInjection;

namespace DavidTielke.PMA.UI.ConsoleClient
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var serviceCollection = new ServiceCollectionFactory().Create();

            serviceCollection.AddTransient<IPersonDisplayCommands, PersonDisplayCommands>();

            var provider = serviceCollection.BuildServiceProvider();

            var displayCommands = provider.GetRequiredService<IPersonDisplayCommands>();

            displayCommands.DisplayAllAdults();
            displayCommands.DisplayAllChildren();
        }
    }
}
