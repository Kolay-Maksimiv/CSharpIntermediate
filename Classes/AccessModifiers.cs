namespace Classes
{
    public static class AccessModifiers
    {
        public class Person1
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
            var person = new Person1();

            person.SetBirthdate(new DateTime(1999, 12, 16));

            Console.WriteLine(person.GetBirthdate());

            Console.WriteLine("-----------------------------------------------------------------------");
        }
    }
}
