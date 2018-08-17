namespace AutofacRpGame
{
    using Autofac;
    using AutofacRpGame.Pokemon;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    public class Container
    {
        private ContainerBuilder containerBuilder;
        public IContainer FactContainer;

        public Container()
        {
            containerBuilder = new ContainerBuilder();
            containerBuilder.RegisterType<Charmander>().As<IFirePokemon>();
            FactContainer = containerBuilder.Build();
        }
    }
}
