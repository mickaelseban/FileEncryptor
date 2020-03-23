namespace FileEncryptor.Application.DependencyInjection
{
    using FileEncryptor.Application.Bridge.Encryption;
    using FileEncryptor.Application.Bridge.Encryption.Implementations;
    using FileEncryptor.Application.Bridge.Readers;
    using FileEncryptor.Application.Bridge.Readers.Implementations;
    using FileEncryptor.Application.Builders;
    using FileEncryptor.Application.Builders.Implementations;
    using FileEncryptor.Application.Factories;
    using FileEncryptor.Application.Factories.Implementations;
    using FileEncryptor.Application.Services;
    using FileEncryptor.Application.Services.Implementations;
    using Microsoft.Extensions.DependencyInjection;

    public static class Container
    {
        public static IServiceCollection SetupApplication(this IServiceCollection services)
        {
            return services
                .AddSingleton<IUserAccessService, UserAccessService>()
                .AddSingleton<IFilesService, FilesService>()
                .AddSingleton<IFileBuilder, FileBuilder>()
                .AddSingleton<IFileReaderFactory, FileReaderFactory>()
                .AddSingleton<IEncryptionFactory, EncryptionFactory>()

                .AddSingleton<IEncryption, NoEncryption>()
                .AddSingleton<IEncryption, ReverseEncryption>()
                .AddSingleton<IFileReader, TextFileReader>()
                .AddSingleton<IFileReader, XmlFileReader>()
                .AddSingleton<IFileReader, JsonFileReader>();
        }
    }
}
