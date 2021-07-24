using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonDataManagement
{
    class PersonManagement
    {
        // Adda a person detail into a List
        public static void AddPerson()
        {
            //List to store person details
            List<Member> PeopleList = new List<Member>();
            PeopleList.Add(new Member(2, "Krithick", "Tamilnadu", 18));
            PeopleList.Add(new Member(1, "Dhanush", "Bangalore", 19));
            PeopleList.Add(new Member(8, "Ajay", "Punjab", 25));
            PeopleList.Add(new Member(21, "Kiran", "Bihar", 74));
            PeopleList.Add(new Member(5, "Yuvanesh", "Kerala", 35));
            PeopleList.Add(new Member(4, "Raju", "Banglore", 22));
            DisplayMembers(PeopleList);

        }
        //displays details
        public static void DisplayMembers(List<Member> peopleList)
        {
            foreach (Member member in peopleList)
            {
                Console.WriteLine("SSN: {0} Name: {1} Address: {2} Age: {3}  ", member.SSN, member.name, member.address, member.age);
            }
        }
    }
}
