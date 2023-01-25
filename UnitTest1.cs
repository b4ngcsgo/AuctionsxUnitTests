using System.Security.Cryptography.X509Certificates;

namespace AuctionsTest
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            VerifyBid newBid = new VerifyBid();
            bool returnVal = newBid.VerifyNewBid(300, 500);
            Assert.True(returnVal);
        }
    }
}