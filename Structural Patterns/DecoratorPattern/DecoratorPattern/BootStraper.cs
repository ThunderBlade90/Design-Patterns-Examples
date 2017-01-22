using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Castle.Windsor;
using Castle.MicroKernel.Registration;

namespace DecoratorPattern
{
    public static class BootStraper
    {
        public static IWindsorContainer Container;

        public static void Boot()
        {
            Container = new WindsorContainer();

            Container.Register(
                    Component.For<Pizza>().ImplementedBy<LoggerPizzaDecorator>(),
                    Component.For<Pizza>().ImplementedBy<HamDecorator>(),
                    Component.For<Pizza>().ImplementedBy<ChampignonsDecorator>(),
                    Component.For<Pizza>().ImplementedBy<CheeseDecorator>(),
                    Component.For<Pizza>().ImplementedBy<LargePizza>()
                );

            Pizza p = Container.Resolve<Pizza>();
            var name = p.GetName();
        }
    }
}
