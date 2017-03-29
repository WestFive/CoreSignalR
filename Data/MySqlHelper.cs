using Data.TheDbContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Data
{
    public class MySqlHelper
    {
        public static void GetList()
        {
            using (var db = new UserContext())
            {
                db.Add(new User { NAME = "eee", AGE = "22" });
                db.SaveChanges();

                User s = db.Find<User>(2);
                db.SaveChanges();

                List<User> users = db.User.Where(x => x.ID < 10).OrderBy(x => x.ID).ToList();
                db.SaveChanges();

            }
        }

    }
}
