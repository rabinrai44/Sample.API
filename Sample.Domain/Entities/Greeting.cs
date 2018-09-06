using Sample.Domain.Abstract;

namespace Sample.Domain.Entities
{
    public class Greeting : IGreeting
    {
        public string GetGreet()
        {
            return "Hello World";
        }
    }
}
