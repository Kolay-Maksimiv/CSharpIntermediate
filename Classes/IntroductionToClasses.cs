namespace Classes
{
    public static class IntroductionToClasses
    {
        public class Person
        {
            public string Name;

            public void Introduce(string to)
            {
                Console.WriteLine("Hi {0}, I am {1}.", to, Name);
            }

            public static Person Parse(string str)
            {
                var person = new Person();
                person.Name = str;

                return person;
            }
        }

        public static void IntroductionToClassesProgram()
        {
            //var person = new Person();
            //person.Name = "Mykola";
            //person.Introduce("Mosh");

            var person = Person.Parse("Mykola");
            person.Introduce("Program");

            Console.WriteLine("-----------------------------------------------------------------------");
        }
    }
}
