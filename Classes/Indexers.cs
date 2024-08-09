namespace Classes
{
    public static class Indexers
    {
        public class HttpCookie
        {
            private readonly Dictionary<string, string> _dictionary; //= new Dictionary<string, string>();

            public HttpCookie()
            {
                _dictionary = new Dictionary<string, string>();
            }

            public string this[string key]
            {
                get { return _dictionary[key]; }
                set { _dictionary[key] = value; }
            }
        }

        public static void IndexersProgram()
        {
            var cookie = new HttpCookie();

            cookie["name"] = "Mykola";

            Console.WriteLine(cookie["name"]);

            Console.WriteLine("-----------------------------------------------------------------------");
        }
    }
}