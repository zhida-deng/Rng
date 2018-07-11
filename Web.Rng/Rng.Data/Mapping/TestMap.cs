using Rng.Core.Domain;
namespace Rng.Data.Mapping
{
     public class TestMap : RngEntityTypeConfiguration<Test>
    {
        public TestMap()
        {
            this.ToTable("Affiliate");
            this.HasKey(a => a.Id);
        }
    }
}
