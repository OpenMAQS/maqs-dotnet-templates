using OpenMAQS.Maqs.BaseEmailTest;
using NUnit.Framework;
using Assert = NUnit.Framework.Assert;

namespace $safeprojectname$
{
    /// <summary>
    /// Tests test class
    /// </summary>
    [TestFixture]
    public class EmailTestNUnit : BaseEmailTest
    {
        /// <summary>
        /// Sample test
        /// </summary>
        [Test]
        public void SampleTestNUnit()
        {
            // TODO: Update email connection configuration and add test code
            //Assert.IsTrue(this.EmailDriver.CanAccessEmailAccount(), "Could not access account");

            this.Log.LogMessage("Dummy test");
        }
    }
}
