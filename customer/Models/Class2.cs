using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace customer.Models
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