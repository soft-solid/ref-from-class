using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac;
using BadCodeTestApp.Commands.FileCommands;
using BadCodeTestApp.Commands;
//using Autofac.Features.ResolveAnything;

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
            return builder.Build();
            
        }

    }
}
