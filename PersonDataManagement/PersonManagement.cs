using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonDataManagement
{
   public class PersonManagement
    {
       public static List<Member> PeopleList = new List<Member>();
        // Adda a person detail into a List
        public  void AddPerson()
        {
            //List to store person details
           
            PeopleList.Add(new Member(2, "Krithick", "Tamilnadu", 18));
            PeopleList.Add(new Member(1, "Dhanush", "Bangalore", 19));
            PeopleList.Add(new Member(8, "Ajay", "Punjab", 25));
            PeopleList.Add(new Member(21, "Kiran", "Bihar", 74));
            PeopleList.Add(new Member(5, "Yuvanesh", "Kerala", 35));
            PeopleList.Add(new Member(4, "Raju", "Banglore", 22));
            DisplayMembers(PeopleList);

        }
        //retrieves the top two person detail from the list whose age is less tha 60;
        public List<string> PersonAgeLessThan60()
        {
            Console.WriteLine("Retriving the top 2 person from list whose age is less than 60");
            List<Member> list = PeopleList.FindAll(person => person.age < 60).OrderBy(x => x.age).Take(2).ToList();
            List<string> recordList = DisplayMembers(list);
            return recordList;
        }
        //displays details
        public List<string> DisplayMembers(List<Member> peopleList)
        {
            List<string> personRecord = new List<string>();
            foreach (Member member in peopleList)
            {
                Console.WriteLine("SSN: {0} Name: {1} Address: {2} Age: {3}  ", member.SSN, member.name, member.address, member.age);
                personRecord.Add(member.name);
            }
            return personRecord;
        }
    }
}
