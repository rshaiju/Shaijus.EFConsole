using Shaijus.EFDAL.Migrations;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;

namespace Shaijus.EFDAL
{
    public class CheckAndMigrateDatabaseToLatestVersion:MigrateDatabaseToLatestVersion<ShaijusContext,Configuration>
    {
        private bool _pendingMigrations;

        public override void InitializeDatabase(ShaijusContext context)
        {
            var migrator = new DbMigrator(new Configuration());
            //_pendingMigrations = migrator.GetPendingMigrations().Any();

            //if (_pendingMigrations)
            {
                base.InitializeDatabase(context);
            }
            
        }
    }
}
