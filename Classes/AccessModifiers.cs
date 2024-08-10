namespace Classes
{
    public static class AccessModifiers
    {
        public class Person
        {
            private DateTime _birthdate;

            public void SetBirthdate(DateTime birthdate)
            {
                _birthdate = birthdate;
            }

            public DateTime GetBirthdate()
            {
                return _birthdate;
            }
        }

        public static void AccessModifiersProgram()
        {
            var person = new Person();

            person.SetBirthdate(new DateTime(1999, 12, 16));

            Console.WriteLine(person.GetBirthdate());

            Console.WriteLine("-----------------------------------------------------------------------");
        }
    }
}
