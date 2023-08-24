namespace abstraction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //SuperChef super = new SuperChef();
            //super.Country();


            /*
             * Encapsulation
            Person person = new Person("MUmbarak", "Basit",2010 );
            person.FullName();
            person.CalcAge();
            */

        }



        /*
         * Encapsulation
         * 
        class Person
        {
            private string LastName { get; set; }
            private string FirstName { get; set; }
            private int YearOfBirth { get; set; }



            public Person(string lastName, string firstName, int yearOfBirth)
            {
                LastName = lastName;
                FirstName = firstName;
                YearOfBirth = yearOfBirth;
            }

            public void FullName()
            {
                Console.WriteLine($"The firstname is {FirstName} and the lastname is {LastName}.");
            }

            public void CalcAge()
            {
                int currentYear = 2023;
                int age = currentYear - YearOfBirth;
                Console.WriteLine($"The age is {age}");
            }


        }
        */


        /*
         * Abstraction 
         * 
        abstract class Chef
        {
            public abstract void Country();
            public void MakeSpecialDishes()
            {
                Console.WriteLine($"Make Special Dishes: Rice");
            }
        }


        class SuperChef : Chef
        {
            public override void Country()
            {
                Console.WriteLine("I am a superchef from nigeria");
            }
        }

        */
        
    }
}