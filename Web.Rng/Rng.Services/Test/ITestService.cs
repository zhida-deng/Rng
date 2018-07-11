using System;

using Rng.Core.Domain;
namespace Rng.Services.Test
{
    public interface ITestService
    {
        Rng.Core.Domain.Test GetAffiliateById(int id);
        void Delete(Rng.Core.Domain.Test test);
        void Insert(Rng.Core.Domain.Test test);
        void Update(Rng.Core.Domain.Test test);
    }
}
