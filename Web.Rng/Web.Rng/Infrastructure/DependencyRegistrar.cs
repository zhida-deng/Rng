using Rng.Core.Infrastructure.DependencyManagement;
using Rng.Core.Infrastructure;
using Autofac;
using Nop.Data;
using Rng.Core.Data;
using Rng.Core.Caching;
using Rng.Services.Test;

namespace Web.Rng.Infrastructure
{
    public  class DependencyRegistrar: IDependencyRegistrar
    {
        public virtual void Register(ContainerBuilder builder, ITypeFinder typeFinder)
        {

            //repositories
            builder.RegisterGeneric(typeof(EfRepository<>)).As(typeof(IRepository<>)).InstancePerLifetimeScope();

            builder.RegisterType<MemoryCacheManager>().As<IStaticCacheManager>().SingleInstance();
            //services
            builder.RegisterType<TestService>().As<ITestService>().InstancePerLifetimeScope();


        }

        /// <summary>
        /// Gets order of this dependency registrar implementation
        /// </summary>
        public int Order
        {
            get { return 2; }
        }
    }
}
