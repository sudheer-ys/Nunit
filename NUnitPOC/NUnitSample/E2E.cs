using NUnit.Framework;

namespace NUnitSample
{
    [TestFixture]
    public class E2E
    {
        [Test]

        public void SumOfTwoNumbers()
        {

            Assert.AreEqual(10, 5 + 5);

        }

        [Test]

        public void AreTheValuesTheSame()
        {

            Assert.AreSame(10, 5 + 6);

        }
    }
}
