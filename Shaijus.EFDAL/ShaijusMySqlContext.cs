using MySql.Data.EntityFramework;
using System.Data.Entity;

namespace Shaijus.EFDAL
{
    [DbConfigurationType(typeof(MySqlEFConfiguration))]
    public class ShaijusMySqlContext:ShaijusContext
    {
    }
}
