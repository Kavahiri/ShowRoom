using Microsoft.SqlServer.Server;
using System.Data.SqlTypes;
using System.Text.RegularExpressions;


namespace CLRPhone
{
    public static class CLRPhone
    {
        [SqlFunction (IsDeterministic =true)]
        public static SqlBoolean IsMatch(SqlString str, SqlString pattern)
        {
            var regex = new Regex(pattern.ToString());
            return (SqlBoolean)regex.IsMatch(str.ToString());
        }
    }
}
