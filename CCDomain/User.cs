using System;

namespace CCDomain
{
    public class User
    {
        private readonly int _id;
        private readonly string _name;
        private string _cc;

        public int Id => _id;
        public string CC
        {
            get => _cc;
            set => _cc = value;
        }
        public string Name => _name;
        public User(int id, string cc, string name)
        {
            _id = id;
            _cc = cc;
            _name = name;
        }

    }
}
