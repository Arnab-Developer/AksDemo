using AksDemo.Api1.Controllers;
using Xunit;

namespace AksDemo.Api1Test
{
    public class HelloApiTest
    {
        [Fact]
        public void CanGetReturnProperMessage()
        {
            string name = "Test User 1";
            HelloApiController controller = new();
            string message = controller.Get(name).Value;
            Assert.Equal("Hello Test User 1, this is API 1", message);
        }
    }
}
