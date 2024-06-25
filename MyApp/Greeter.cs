using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp
{
    public class Greeter
    {
        #region Methods

        /// <summary>
        /// Greets a person with the given name.
        /// </summary>
        /// <param name="name">A <see cref="string"/> containing the name of the person to greet.</param>
        /// <returns>A <see cref="string"/> containing the greeting.</returns>
        /// <exception cref="ArgumentNullException"><c>name</c> is null.</exception>
        /// <exception cref="ArgumentException"><c>name</c> is empty.</exception>
        public string Greet(string name)
        {
            if (name == null)
            {
                throw new ArgumentNullException("name");
            }

            if (name.Trim() == string.Empty)
            {
                throw new ArgumentException("name is empty", "name");
            }

            return $"Hello, {name}";
        }

        #endregion
    }
}
