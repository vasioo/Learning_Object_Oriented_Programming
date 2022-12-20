using System;

namespace AuthorProblem
{
    [Author("Vasil")]
    [Author("Students")]
    public class StartUp
    {

        [Author("Vasil")]
        [Author("Students")]
        public static void Main(string[] args)
        {
            Tracker tr = new Tracker();
            tr.PrintMethodsByAuthor();
        }
        public void Test()
        {

        }
    }
}
