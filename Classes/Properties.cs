
namespace Classes
{
    public static class Properties
    {
        public class Persone2
        {
            public DateTime Birthdate { get; private set; }

            public Persone2(DateTime birthdate)
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

            var person = new Persone2(new DateTime(1999, 12, 16));

            Console.WriteLine(person.Age);

            Console.WriteLine("-----------------------------------------------------------------------");
        }
    }
}