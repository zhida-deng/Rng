using Rng.Core.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rng.Core.Domain;
namespace Rng.Services.Test
{
     public class TestService : ITestService
    {
        #region Fields

        private readonly IRepository<Rng.Core.Domain.Test> _testRepository;


        #endregion

        #region Ctor

        /// <summary>
        /// Ctor
        /// </summary>
        /// <param name="affiliateRepository">Affiliate repository</param>
        /// <param name="orderRepository">Order repository</param>
        /// <param name="eventPublisher">Event published</param>
        public TestService(IRepository<Rng.Core.Domain.Test> testRepository)
        {
            this._testRepository = testRepository;
          
        }

        #endregion

        #region Methods

        /// <summary>
        /// Gets an affiliate by affiliate identifier
        /// </summary>
        /// <param name="affiliateId">Affiliate identifier</param>
        /// <returns>Affiliate</returns>
        public virtual Rng.Core.Domain.Test GetById(int id)
        {
            if (id == 0)
                return null;
            return new Rng.Core.Domain.Test() { age = 1, Id = 1, name = "Dageeeee" };
            return _testRepository.GetById(id);
        }



        /// <summary>
        /// Marks affiliate as deleted 
        /// </summary>
        /// <param name="affiliate">Affiliate</param>
        public virtual void Delete(Rng.Core.Domain.Test test)
        {
            if (test == null)
                throw new ArgumentNullException(nameof(test));

            _testRepository.Delete(test);

        }

        /// <summary>
        /// Inserts an affiliate
        /// </summary>
        /// <param name="affiliate">Affiliate</param>
        public virtual void Insert(Rng.Core.Domain.Test test)
        {
            if (test == null)
                throw new ArgumentNullException(nameof(test));

            _testRepository.Insert(test);

        }

        /// <summary>
        /// Updates the affiliate
        /// </summary>
        /// <param name="affiliate">Affiliate</param>
        public virtual void Update(Rng.Core.Domain.Test test)
        {
            if (test == null)
                throw new ArgumentNullException(nameof(test));

            _testRepository.Update(test);

        }

        #endregion
    }
}
