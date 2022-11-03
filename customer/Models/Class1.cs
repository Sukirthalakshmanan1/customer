using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Helpers;

namespace customer.Models
{
    [TestFixture]
    public class customer_support_class
    {
        [TestCase(1)]
        public void Userinfo_test(int id)
        {
            customerEntities db = new customerEntities();
            var found = db.UserInfoes.ToList();

            Assert.AreEqual(id, found[0].UserId);

            Console.WriteLine("Validation success");

        }
        [TestCase("abcd123")]
       // [TestCase("suki123")]
        public void Userinfo_test1(string p)
        {
            customerEntities db = new customerEntities();
            var found = db.UserInfoes.ToList();

            Assert.AreEqual(p, found[0].passwords.ToString());
            Console.WriteLine("Validation success");

        }
        Validation v = new Validation();
        [TestCase(1, "suki123@gmail.com")]
        public void Userinfo_test2(int uid, string s)
        {

            v.check(uid, s);
        }



    }
}