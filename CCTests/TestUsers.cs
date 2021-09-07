using System.Collections.Generic;
using CCDomain;

namespace UserTests
{
    static class TestUsers
    {
        public static IEnumerable<User> CreateMockUsers() => new List<User>(){
                new User(2, "1234567890123456", "Bob"),
                new User(5, "0987737737377773", "John"),
                new User(4, "4242342342342424", "Alan"),
                new User(5, "2342424324242432", "Susan")
                };

    }
}
