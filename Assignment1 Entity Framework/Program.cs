using Assignment1_Entity_Framework.Contexts;

namespace Assignment1_Entity_Framework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // when creating object from "ITIDbContext" We Open connection with datbase
            ITIDbContext dbContext = new ITIDbContext();

            dbContext.Students.Where(S => S.Id == 1);

        }
    }
}
