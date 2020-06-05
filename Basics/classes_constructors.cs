using System;

namespace Scratch2name
{
    class Scratch2
    {
        public class Person
        {
            private string name = "Bob";  // the name field - no constructor
            public string Name    // the Name property
            {
                get  // no get = write only
                {
                    return name;
                }

                set // no set = read only
                { 
                    name = value;
                }
            }
        }


        public class AnotherPerson
        {
            private string last;  // private and valueless
            private string first;

            public override string ToString() => $"{first} {last}".Trim(); // overrides tostring with expression body definition

            // constructor
            public AnotherPerson(string lastName, string firstName) // values come from instantiation
            {
                last = lastName;
                first = firstName;
            }

            public string FirstName    // the firstname property hidden behind properties
            {
                get { return first; }

                set { first = value; }
            }

            public string LastName  // same for lastname. note the difference in variable names
            {
                get { return last; }

                set { last = value; }
            }
        }


        public class Location
        {
            private string locationName;

            public Location(string name) => Name = name; // single expression constructor expressed as 'expression body definition'

            public string Name
            {
                get => locationName;
                set => locationName = value;
            }
        }


        public class Adult : AnotherPerson  // The following example uses a static constructor to initialize a static field.
        {
            public static int minimumAge;

            public Adult(string lastName, string firstName) : base(lastName, firstName)
            { }

            static Adult()
            {
                minimumAge = 18;
            }

        }



        static void Main(string[] args)
        {
            Person person = new Person();
            Console.WriteLine(person.Name);  // the get accessor is invoked here
            person.Name = "Joe";  // setter is called (implicitly)
            Console.WriteLine(person.Name); // get our new property

            AnotherPerson anotherperson = new AnotherPerson("Smith", "Tom"); // supply values for constructor
            Console.WriteLine("{0} {1}", anotherperson.FirstName, anotherperson.LastName); // uses get to retrieve

            Location loc = new Location("here");
            Console.WriteLine(loc.Name);

            Adult grownup = new Adult("Crews", "Terry");
            Console.Write(grownup.FirstName);
            Console.Write(grownup.LastName);
            Console.Write("{0}\n", Adult.minimumAge); // cannot access static members with instance syntax


            Console.Write(anotherperson); // to string method is overridden 


        }
    }
}
