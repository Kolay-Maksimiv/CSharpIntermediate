namespace Classes
{
    public static class IntroductionToClasses
    {
        public static void IntroductionToClassesProgram()
        {
            //var person = new Person();
            //person.Name = "John";
            //person.Introduce("Mosh");

            var person = Person.Parse("John");
            person.Introduce("Mosh");
        }
    }

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
}
