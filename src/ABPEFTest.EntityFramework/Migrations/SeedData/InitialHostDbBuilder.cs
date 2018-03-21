using ABPEFTest.EntityFramework;
using EntityFramework.DynamicFilters;

namespace ABPEFTest.Migrations.SeedData
{
    public class InitialHostDbBuilder
    {
        private readonly ABPEFTestDbContext _context;

        public InitialHostDbBuilder(ABPEFTestDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            _context.DisableAllFilters();

            new DefaultEditionsCreator(_context).Create();
            new DefaultLanguagesCreator(_context).Create();
            new HostRoleAndUserCreator(_context).Create();
            new DefaultSettingsCreator(_context).Create();
            new DefaultAutomotiveCreator(_context).Create();
        }
    }
}
