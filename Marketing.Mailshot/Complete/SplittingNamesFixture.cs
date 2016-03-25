using Concordion.NET.Integration;

namespace Marketing.Mailshot.Complete
{
    [ConcordionTest]
    public class SplittingNamesFixture
    {
        public Result Split(string fullName)
        {
            Result result = new Result();
            string[] words = fullName.Split(' ');
            result.firstName = words[0];
            result.lastName = words[1];
            return result;
        }
    }

    public class Result
    {
        public string firstName;
        public string lastName;
    }
}
