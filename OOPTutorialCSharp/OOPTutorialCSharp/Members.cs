using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPTutorialCSharp
{
    class Members
    {
        //private fields
        private string memberName;
        private string jobTitle;
        private int salary = 900;

        //public
        public int age;

        //properties - expose jotTitle safety, start with capital letter
        public string JobTitle
        {
            get => jobTitle;
            set => jobTitle=value;
        }

        //public Method member
        public void Introducing(bool isFriend)
        {
            if (isFriend)
            {
                SharingPrivateInfo();
            }
            else
            {
                Console.WriteLine("Hi my name is {0}, my job title is {1} and my age is", memberName, jobTitle, age);
            }
            return;
        }

        private void SharingPrivateInfo()
        {
            Console.WriteLine("Hi my salary is {0}",salary);
            return;
        }

        //member constructor

        public Members()
        {
            Console.WriteLine("Object created");
        }

        public Members(string memberName, string jobTitle, int age, int salary)
        {
            this.JobTitle = jobTitle;
            this.memberName = memberName;
            this.age = age;
            this.salary = salary;
        }

        //destructor\finalazer DO NOT CREATE EMPTY FINALAZER
        ~Members()
        {
            //clean up statemend
            //Console.WriteLine("Decontruct member");
            //show in output in visual studio not in console
            System.Diagnostics.Debug.WriteLine("Decontruct member!!!"); 
        }
    }
}
