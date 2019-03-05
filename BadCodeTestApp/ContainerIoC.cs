using Autofac;
using BadCodeTestApp.Commands.FileCommands;
using BadCodeTestApp.Commands;
using System.Linq;
using System;

namespace BadCodeTestApp
{
    static class ContainerIoC
    {
        public static IContainer GetContainerIoC()
        {
            ContainerBuilder builder = new ContainerBuilder();
            builder.RegisterType<Search>().Named<ICommand>("search");
            //builder.RegisterType<SearchByExt>().Named<ICommand>("search_by_ext"); //кажется излишним, с его ф-цияим справится Search
            builder.RegisterType<Create>().Named<ICommand>("create_txt");
            builder.RegisterType<Delete>().Named<ICommand>("remove_txt");
            return builder.Build();
        }

        /// <summary>
        /// Верификация комманды.
        /// </summary>
        /// <param name="container">контейнер с зарегистрированными, именованными членами</param>
        /// <param name="command">имя комманды</param>
        /// <returns>наличие элемента в контейнере</returns>
        public static bool SearchRegisteredCommand(IContainer container, string command)
        {
            return container.IsRegisteredWithName<ICommand>(command);
        }
    }
}
