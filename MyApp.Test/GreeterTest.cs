using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.Test
{
    /// <summary>
    /// Contains unit tests for the <see cref="Greeter"/> class
    /// </summary>
    [TestClass]
    public class GreeterTest
    {
        #region Methods

        /// <summary>
        /// Checks the default behavior of the method.
        /// </summary>
        [TestMethod]
        public void TestGreet()
        {
            const string testName = "FPoly";
            Greeter greeter = new Greeter();

            StringAssert.Contains(greeter.Greet(testName), testName);
            //StringAssert.Contains(greeter.Greet(testName), "FFF");
        }

        /// <summary>
        /// Checks the behavior of the method with an invalid argument (null).
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void TestGreetNull()
        {
            Greeter greeter = new Greeter();
            greeter.Greet(null);
        }

        /// <summary>
        /// Checks the behavior of the method with an invalid argument (empty).
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestGreetEmpty()
        {
            Greeter greeter = new Greeter();
            greeter.Greet(string.Empty);
        }

        #endregion
    }
}
