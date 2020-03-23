namespace FileEncryptor.Presentation.Console.DependencyInjection
{
    using FileEncryptor.Application.DependencyInjection;
    using FileEncryptor.Presentation.Console.Adapters;
    using FileEncryptor.Presentation.Console.Adapters.Implementations;
    using Microsoft.Extensions.DependencyInjection;

    public static class Container
    {
        internal static ServiceProvider Build()
        {
            var collection = new ServiceCollection();
            collection.SetupApplication();
            collection.SetupConsole();
            var serviceProvider = collection.BuildServiceProvider();
            return serviceProvider;
        }

        private static IServiceCollection SetupConsole(this IServiceCollection services)
        {
            return services
                .AddSingleton<IUserAccessOperationTypeToEncryptionTypeDtoAdapter, UserAccessOperationTypeToEncryptionTypeDtoAdapter>()
                .AddSingleton<IUserConsoleInputViewModelToNewFileDtoAdapter, UserConsoleInputViewModelToNewFileDtoAdapter>()
                .AddSingleton<IUserOperationTypeToFileReaderTypeDtoAdapter, UserOperationTypeToFileReaderTypeDtoAdapter>();
        }
    }
}
