using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonDataManagement
{
   public class PersonManagement
    {
        public static List<Member> PeopleList;
        // Adda a person detail into a List
        public  void AddPerson()
        {
            PeopleList = new List<Member>();

            //List to store person details
            PeopleList.Add(new Member(2, "Krithick", "Tamilnadu", 15));
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

        //Retrieving the record where age is between 13-18
        public List<string> PersonDataBetweenAge13And18()
        {
            Console.WriteLine("Retriving the record where age is between 13-18");
            List<Member> list1 = PeopleList.FindAll(person1 => person1.age < 18 && person1.age > 13);
            List<string> recordList1 = DisplayMembers(list1);
            return recordList1;
        }
       //Compute Average
       public double AverageAgeRecord()
        {
            double averageAge = PeopleList.Average(person => person.age);
            Console.WriteLine("Average age value is : {0} ", Math.Round(averageAge, 3));
            return Math.Round(averageAge, 3);
        }
        //Search given name
        public string SearchingSpecificName(string personName)
        {
            try
            {
                var person = PeopleList.Find(person => person.name.Equals(personName));
                if (personName != null && person == null)
                {
                    Console.WriteLine("Person does not Exist!");
                    return "Not Found";
                }
                if (person.name == personName)
                {
                    Console.WriteLine("Found Person SSN : {0} Name ; {1} Address : {2}; Age : {3}  ", person.SSN, person.name, person.address, person.age);
                    return "Found";
                }

                throw new ArgumentNullException("");

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return ex.Message;
            }
        }
        //Skip records less than 60
        public List<string> SkipRecordLessThan60()
        {
            try
            {
                var list = PeopleList.FindAll(person => person.age > 60);
                if (list != null)
                {
                    Console.WriteLine("\n-----Record which age is greater than 60-----");
                    List<string> recordList = DisplayMembers(list);
                    return recordList;
                }
                else
                {
                    Console.WriteLine("No data available ");
                    throw new ArgumentNullException("");
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return default;
            }
        }
        //displays details
        public List<string> DisplayMembers(List<Member> peopleList)
        {
            
            List<string> memberRecord = new List<string>();
            foreach (Member member in peopleList)
            {
                Console.WriteLine("SSN: {0} Name: {1} Address: {2} Age: {3}  ", member.SSN, member.name, member.address, member.age);
                memberRecord.Add(member.name);
            }
            return memberRecord;
        }
     
    }
}
