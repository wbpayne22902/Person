using System;

namespace Persons {
    /// <summary>
    /// A class defining a person with a name and age.
    /// </summary>
    public class Person {
        string name;
        int age;

        /// <summary>
        /// Creates a new person with the given name and age.
        /// </summary>
        /// <param name="name">The name</param>
        /// <param name="age">The age</param>
        public Person(string name, int age) {
            this.name = name;
            this.age = age;
        }

        /// <summary>
        /// Creates a new person with no name and age.
        /// </summary>
        public Person() {
            this.name = null;
            this.age = 0;
        }

        /// <summary>
        /// Creates a new person with the given name and no age.
        /// </summary>
        /// <param name="name">The name of the person.</param>
        public Person(string name) {
            this.name = name;
            this.age = 0;
        }

        /// <summary>
        /// Sets the name of the person
        /// </summary>
        /// <param name="name">The name to set for the person</param>
        public void setName(string name) {
            this.name = name;
        }

        /// <summary>
        /// Gets the name of the person
        /// </summary>
        /// <returns>The person's name</returns>
        public string getName() {
            Console.WriteLine("Returning name {0} of object.", name);
            return name;
        }
        /// <summary>
        /// Sets the age of the person
        /// </summary>
        /// <param name="age">The person's age</param>
        public void setAge(int age) {
            this.age = age;
        }

        /// <summary>
        /// Gets the age of the person
        /// </summary>
        /// <returns>The person's age.</returns>
        public int getAge() {
            Console.WriteLine("Returning age {0} of object.", age);
            return age;
        }

        /// <summary>
        /// Returns a string representation of the person.
        /// </summary>
        /// <returns>A string representing the person.</returns>
        public override string ToString() => String.Format("Person Name: {0}, Age: {1}", name, age);
    }
}
