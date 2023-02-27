using _26022023_HomeWork_10Person;

namespace TestPerson
{
    [TestClass]
    public class PersonTests
    {
        [TestMethod]
        public void TestSortByNameAndWriteToFile()
        {
            // Arrange
            List<Person> people = new List<Person>();
            people.Add(new Teacher("Maria", "English Elementary", 343));
            people.Add(new Developer("Iryna", ".Net Core", 456));
            people.Add(new Teacher("Roman", "Early Education", 432));
            people.Add(new Developer("Volodia", "JS", 485));
            people.Add(new Teacher("Petro", "High School", 1212));
            people.Add(new Developer("Konstantyn", "WEB UI", 434));
            people.Add(new Teacher("Marta", "Special Education", 4444));
            people.Add(new Developer("Vira", "Python", 414));
            people.Add(new Teacher("Mykola", "Preschool Teacher", 2121));
            people.Add(new Developer("Nadia", "Java", 4643));

            // Act
            people.Sort();

            string path = @"Sorted_names.txt";
            using (StreamWriter sw = new StreamWriter(path, false))
            {
                sw.WriteLine("Sorted names:");
                foreach (Person p in people)
                {
                    sw.WriteLine(p.Name);
                }
            }

            // Assert
            List<string> expected = new List<string>() { "Iryna", "Konstantyn", "Maria", "Marta", "Mykola", "Nadia", "Petro", "Roman", "Vira", "Volodia" };
            List<string> actual = File.ReadAllLines(path).Skip(1).ToList();

            Assert.AreEqual(expected.Count, actual.Count, "Different number of elements.");
            CollectionAssert.AreEqual(expected, actual, "Elements at index {0} do not match.", string.Join(",", expected.Zip(actual, (e, a) => e == a ? " " : "x")));
        }
    }
    }