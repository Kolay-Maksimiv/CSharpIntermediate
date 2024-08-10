
namespace Classes
{
    public static class Properties
    {
        public class Persone
        {
            public DateTime Birthdate { get; private set; }

            public Persone(DateTime birthdate)
            {
                Birthdate = birthdate;
            }

            public int Age
            {
                get
                {
                    var timeSpan = DateTime.Now - Birthdate;
                    var years = timeSpan.Days / 365;

                    return years;
                }
            }
        }

        public static void PropertiesProgram()
        {
            //var person = new Persone2();
            //person.Birthdate = new DateTime(1999, 12, 16);

            var person = new Persone(new DateTime(1999, 12, 16));

            Console.WriteLine(person.Age);

            Console.WriteLine("-----------------------------------------------------------------------");
        }
    }
}