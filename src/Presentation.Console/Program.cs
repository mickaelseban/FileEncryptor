namespace FileEncryptor.Presentation.Console
{
    using FileEncryptor.Application.Dto;
    using FileEncryptor.Application.Model.User.Enums;
    using FileEncryptor.Application.Services;
    using FileEncryptor.Presentation.Console.Adapters;
    using FileEncryptor.Presentation.Console.DependencyInjection;
    using FileEncryptor.Presentation.Console.Utils;
    using FileEncryptor.Presentation.Console.ViewModel;
    using Microsoft.Extensions.DependencyInjection;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public static class Program
    {
        private static void Main()
        {
            ServiceProvider sp = Container.Build();

            IFilesService filesService = sp.GetService<IFilesService>();
            IUserAccessService userAccessService = sp.GetService<IUserAccessService>();
            IUserConsoleInputViewModelToNewFileDtoAdapter adapterViewModelToNewFileDto = sp.GetService<IUserConsoleInputViewModelToNewFileDtoAdapter>();

            try
            {
                Console.WriteLine(" ######## Welcome to File Reader ######## ");
                Console.WriteLine(" ######################################## ");
                Console.WriteLine(Environment.NewLine);

                UserConsoleInputViewModel viewModel = new UserConsoleInputViewModel();

                ReadInputOption<UserOperationType>(viewModel.Operation, "operation", UserAccess.AvailableUserOperations());
                ReadInputOption<UserAccessOperationType>(viewModel.AccessOperation, "access operation", UserAccess.AvailableUserAccessOperations());

                ReadUserInputs(viewModel);

                NewFileDto dto = adapterViewModelToNewFileDto.Adapt(viewModel);

                string fileContent = filesService.ReadNewFile(dto);

                Console.WriteLine(fileContent);
                Console.ReadKey();
            }
            finally
            {
                sp.Dispose();
            }
        }

        private static T ReadInputOption<T>(T typeResult, string desc, Dictionary<int, string> dictionary) where T : Enum
        {
            Console.WriteLine($"#### List of available of {desc}s \n");

            string selected;

            foreach (var keyPair in dictionary)
            {
                Console.WriteLine($" {keyPair.Value} -- Option: {keyPair.Key}");
            }

            Console.WriteLine();

            do
            {
                Console.WriteLine($" ## write your {desc}, please ## ");
                selected = Console.ReadLine();
            }
            while (!dictionary.ContainsKey(Convert.ToInt32(selected)));

            int result = Convert.ToInt32(selected);

            Console.WriteLine($"You selected: {dictionary.First(k => k.Key == result).Value} \n");

            return (T)Enum.ToObject(typeof(T), result);
        }

        private static void ReadUserInputs(UserConsoleInputViewModel viewModel)
        {
            Console.WriteLine($"## Write the file full path, please \n");
            viewModel.FileName = Console.ReadLine();
        }
    }
}
