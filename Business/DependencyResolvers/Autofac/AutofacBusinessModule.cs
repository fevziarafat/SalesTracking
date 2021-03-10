using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac;
using Autofac.Extras.DynamicProxy;
using Business.Abstract;
using Business.Concrete;
using Castle.DynamicProxy;
using Core.Utilities.Interceptors;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;

namespace Business.DependencyResolvers.Autofac
{
    public class AutofacBusinessModule:Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<DealerManager>().As<IDealerService>().SingleInstance();
            builder.RegisterType<EfDealerDal>().As<IDealerDal>().SingleInstance();

            builder.RegisterType<PacketManager>().As<IPacketService>().SingleInstance();
            builder.RegisterType<EfPacketDal>().As<IPacketDal>().SingleInstance();

            builder.RegisterType<StatusManager>().As<IStatusService>().SingleInstance();
            builder.RegisterType<EfStatusDal>().As<IStatusDal>().SingleInstance();

            builder.RegisterType<UserManager>().As<IUserService>().SingleInstance();
            builder.RegisterType<EfUserDal>().As<IUserDal>().SingleInstance();


            var assembly = System.Reflection.Assembly.GetExecutingAssembly();

            builder.RegisterAssemblyTypes(assembly).AsImplementedInterfaces()
                .EnableInterfaceInterceptors(new ProxyGenerationOptions()
                {
                    Selector = new AspectInterceptorSelector()
                }).SingleInstance();

        }
    }
}
