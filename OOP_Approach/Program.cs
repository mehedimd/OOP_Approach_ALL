using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Approach
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("INPUTS\n======");
                Console.Write("\nID: ");
                string id = Console.ReadLine();
                Console.Write("First Name: ");
                string firstName = Console.ReadLine();
                Console.Write("Last Name: ");
                string lasttName = Console.ReadLine();
                Console.Write("Date of Birth (mm/dd/yyyy): ");
                DateTime birthDate = Convert.ToDateTime(Console.ReadLine());
                Console.Write("Joining Date (mm/dd/yyyy): ");
                DateTime joiningDate = Convert.ToDateTime(Console.ReadLine());
                Console.WriteLine("\nDESIGNATIONS:\n============\n1. GM\n2. DGM\n3. AGM\n4. SM\n5. Manager\n6. Executive\n7. Assistant");
                Console.Write("\nInput any one serial number of the designations given above: ");
                int desigCode = Int32.Parse(Console.ReadLine());

                Employee anEmployee = new Employee(id, firstName, lasttName, birthDate, joiningDate, desigCode);
                Console.Write("\nGive roles of the employee (Seperate by comma[,]): ");
                string[] roles = anEmployee.GetRole(Console.ReadLine());

                Console.WriteLine("\n\nOUTPUTS\n=======");
                Console.WriteLine("\nEmployee ID: " + anEmployee.ID + "\nName: " + anEmployee.GetFullName() + "\nDate of Birth: " + anEmployee.BirthDate.ToShortDateString() + "\nJoining Date: " + anEmployee.JoiningDate.ToShortDateString() + "\nDesignation: " + anEmployee.Designation + "\nAge: " + anEmployee.GetAge() + "\n\nRole plays:\n==========");
                for (int i = 0; i < roles.Length; i++)
                {
                    Console.WriteLine((i + 1).ToString() + ". " + roles[i].Trim());
                }
                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

    }
}
    public enum Designation
    {
        GM = 1,
        DGM = 2,
        AGM = 3,
        SM = 4,
        Manager = 5,
        Executive = 6,
        Assistant = 7
    }

    interface IRole
    {
        string[] GetRole(string role);
    }
    public abstract class Person
    {
        internal string firstName = string.Empty;
        internal string lastName = string.Empty;
        internal DateTime birthDate;
        public abstract string FirstName { get; set; }
        public abstract string LastName { get; set; }
        public abstract DateTime BirthDate { get; set; }
        public abstract string GetFullName();
        public abstract string GetAge();
    }

    public sealed class Employee : Person, IRole
    {
        public string ID { get; set; }
        public override string FirstName { get => firstName; set => firstName = value; }
        public override string LastName { get => lastName; set => lastName = value; }
        public override DateTime BirthDate { get => birthDate; set => birthDate = value; }
        public DateTime JoiningDate { get; set; }
        public string Designation { get; set; }

        public Employee(string id, string firstName, string lastName, DateTime birthDate, DateTime joiningDate, int desig)
        {
            this.ID = id;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.BirthDate = birthDate;
            this.JoiningDate = joiningDate;
            this.Designation = Enum.GetName(typeof(Designation), desig);
        }

        public override string GetAge()
        {
            TimeSpan age = DateTime.Now - BirthDate;
            int years = age.Days / 365;
            int months = (age.Days - years * 365) / 30;
            int days = (age.Days - years * 365 - months * 30);
            return years.ToString() + " years " + months.ToString() + " months " + days.ToString() + " days.";
        }

        public override string GetFullName()
        {
            return FirstName + " " + LastName;
        }

        public string[] GetRole(string role)
        {
            string[] roles = role.Split(',');
            return roles;
        }
    }



