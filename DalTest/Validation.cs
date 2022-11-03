using customer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DalTest
{
    public class Validation
    {
        customerEntities db = new customerEntities();
        public bool check(int uid, string s)
        {
            bool ans = false;
            var found = db.UserInfoes.ToList();
            if (found[0].UserId == uid && found[0].Email == s)
            {
                ans = true;
            }
            return ans;
        }

    }
}
