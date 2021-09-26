using Autofac;
using Mediator.Interfaces;
using Mediator.Models;
using System;

namespace Mediator_
{
    class Program
    {
        static void Main(string[] args)
        {
            var builder = new ContainerBuilder();
            builder.RegisterAssemblyTypes(AppDomain.CurrentDomain.GetAssemblies())
                .AsClosedTypesOf(typeof(IMediator<,>)).AsImplementedInterfaces();

            var container = builder.Build();
            var mediator = container.Resolve<IMediator<Command, Response>>();
            var result = mediator.Handle(new Command());

            var mediator2 = container.Resolve<IMediator<Command, string>>();
            var result2 = mediator2.Handle(new Command());
        }
    }
}
