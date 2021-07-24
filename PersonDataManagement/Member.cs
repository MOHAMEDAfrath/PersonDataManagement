using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonDataManagement
{
    class Member
    {
        public int SSN;
        public string name;
        public string address;
        public int age;
        public Member(int id, string name, string address, int age)
        {
            this.SSN = id;
            this.name = name;
            this.address = address;
            this.age = age;
        }
    }
}
