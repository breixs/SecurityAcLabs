using Xunit;
using MyAPICode;
using System.Threading.Tasks;
using System.Linq;


namespace MyAPICodeTest
{
    public class UnitTest1
    {
        [Fact]
        [Trait("Type","Unit")]
        public void Test1()
        {
            var api = new PasswordAPI();
            var result = api.GetPasswordAPI(16);
            string[] finalres = result.Split('"');
            Assert.Equal(16, finalres[3].Length);
        }
    }
}