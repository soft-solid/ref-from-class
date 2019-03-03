using Autofac;
using BadCodeTestApp.Commands.FileCommands;
using BadCodeTestApp.Commands;

namespace BadCodeTestApp
{
    static class ContainerIoC
    {
        //ContainerBuilder Conteiner;
        public static IContainer GetContainerIoC()
        {
            //регистрация всех
            //var builder = new ContainerBuilder();
            //builder.RegisterAssemblyTypes(typeof(Program).Assembly).As<ICommand>();

            ContainerBuilder builder = new ContainerBuilder();
            builder.RegisterType<Search>().Named<ICommand>("search");
            builder.RegisterType<SearchByExt>().Named<ICommand>("cs_search");
            builder.RegisterType<Create>().Named<ICommand>("create_txt");
            builder.RegisterType<Delete>().Named<ICommand>("remove_txt");
            return builder.Build();
            
        }

    }
}
