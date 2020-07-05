using ShopCart.EntityFramework;
using EntityFramework.DynamicFilters;

namespace ShopCart.Migrations.SeedData
{
    public class InitialHostDbBuilder
    {
        private readonly ShopCartDbContext _context;

        public InitialHostDbBuilder(ShopCartDbContext context)
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
        }
    }
}
