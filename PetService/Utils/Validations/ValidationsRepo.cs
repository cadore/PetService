using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetService.Utils.Validations
{
    public class ValidationsRepo
    {
        public static bool UniqueCPF(string table, string column, object value)
        {
            bool flag = false;
            try
            {
                string sql = "SELECT COUNT(id) FROM ";
                sql += String.Format("{0} WHERE {1}='{2}'", table, column, value);
                string s = PetRepo.GetInstance().ExecuteScalar<string>(sql);
                Console.WriteLine(sql);
                Console.WriteLine(s);
                if (s.Equals(DBNull.Value) || String.IsNullOrEmpty(s))
                    flag = true;
                else
                    if (Convert.ToInt32(s) > 0)
                        flag = false;
                    else
                        flag = true;

                return flag;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex.InnerException);
            }
        }
    }
}
