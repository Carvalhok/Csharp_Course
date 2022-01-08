using System;
using System.Collections.Generic;
using System.Text;

namespace InternetRegister.Entities
{
    class User
    {
        public string Name { get; set; }
        public DateTime Instant { get; set; }

        public User(string name, DateTime instant)
        {
            Name = name;
            Instant = instant;
        }

        public override int GetHashCode()
        {
            return Name.GetHashCode();
        }
        public override bool Equals(object obj)
        {
            if (!(obj is User))
                throw new ArgumentException();

            User other = obj as User;
            return Name.Equals(other.Name);
        }
    }
}
