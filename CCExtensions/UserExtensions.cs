using System.Collections.Generic;
using System.Linq;
using CCDomain;

namespace CCExtensions
{
    public static class UserExtensions
    {
        public static int SaveOrUpdate(this IEnumerable<User> users, int userId, string userCC)
        {
            //sanity check to make sure CC is valid
            userCC = userCC.ObfuscateCC();

            // user id should be a unique primary key
            var user = users.Where((user) => userId == user.Id).FirstOrDefault();

            if (user != null)
            {
                if (user.CC != userCC)
                {
                    user.CC = userCC;
                    return 1;
                    //in a real world example we would commit the change, ie DbContext.SaveChanges();
                }
            }
            return 0;
        }
    }
}
