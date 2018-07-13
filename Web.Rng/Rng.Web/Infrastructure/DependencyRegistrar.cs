using Autofac;
using Microsoft.EntityFrameworkCore;
using Nop.Data;
using Rng.Core.Caching;
using Rng.Core.Data;
using Rng.Core.Infrastructure.DependencyManagement;
using Rng.Data;
using Rng.Services.Test;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rng.Web.Infrastructure
{
    public class DependencyRegistrar: IDependencyRegistrar
    {
        public virtual ContainerBuilder Register(ContainerBuilder builder)
        {
            //repositories
            builder.RegisterGeneric(typeof(EfRepository<>)).As(typeof(IRepository<>)).InstancePerLifetimeScope();

            builder.RegisterType<MemoryCacheManager>().As<IStaticCacheManager>().SingleInstance();

            //services
            builder.RegisterType<TestService>().As<ITestService>().InstancePerLifetimeScope();

           // builder.Register<IDbContext>(c => new DbContext()).InstancePerLifetimeScope();

            return builder;
        }
    }
}
