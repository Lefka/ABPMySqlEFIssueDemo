using System.Linq;
using ABPEFTest.EntityFramework;
using ABPEFTest.MultiTenancy;

namespace ABPEFTest.Migrations.SeedData
{
    public class DefaultTenantCreator
    {
        private readonly ABPEFTestDbContext _context;

        public DefaultTenantCreator(ABPEFTestDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            CreateUserAndRoles();
        }

        private void CreateUserAndRoles()
        {
            //Default tenant

            var defaultTenant = _context.Tenants.FirstOrDefault(t => t.TenancyName == Tenant.DefaultTenantName);
            if (defaultTenant == null)
            {
                _context.Tenants.Add(new Tenant {TenancyName = Tenant.DefaultTenantName, Name = Tenant.DefaultTenantName});
                _context.SaveChanges();
            }
        }
    }
}
