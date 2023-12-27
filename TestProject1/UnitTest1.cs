using Project;
using Project.Enums;

namespace Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestInspector_Normal()
        {
            Curator curator = new Curator("Didier", "Marien", 34, 777);
            List<Employee> employees = new List<Employee>();
            employees.Add(new Employee(1, "Salvador", "Dali", 30, Work.Екскурсовод));
            employees.Add(new Employee(2, "Claude", "Monet", 23, Work.Доглядач));
            employees.Add(new Employee(3, "Leonardo", "da Vinci", 25, Work.Реставратор));
            ArtGallery artGallery1 = new ArtGallery("HillLime", curator, employees);
            ArtInspector inspector = new ArtInspector(artGallery1, 3);
            string expected = $"Didier Marien";
            string actual = artGallery1.ToString();
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestOwner_Name()
        {
            Curator curator1 = new Curator("", "Marien", 23, 777);
            Assert.ThrowsException<ArgumentException>(() => curator1.IsEmpty(curator1.FirstName));
        }
        [TestMethod]
        public void TestOwner_Surname()
        {
            Curator curator2 = new Curator("Didier", "", 23, 777);
            Assert.ThrowsException<ArgumentException>(() => curator2.IsEmpty(curator2.LastName));
        }
        [TestMethod]
        public void TestOwner_Age()
        {
            Curator curator3 = new Curator("Didier", "Marien", 17, 777);
            Assert.ThrowsException<ArgumentException>(() => curator3.NormalAge(curator3.Age));
        }
        [TestMethod]
        public void TestWorker_Id()
        {
            Employee employee = new Employee(-1, "Salvador", "Dali", 26, Work.Екскурсовод);
            Assert.ThrowsException<ArgumentException>(() => employee.Enough(employee.Id));
        }
        [TestMethod]
        public void TestWorker_Name()
        {
            Employee employee2 = new Employee(1, "", "Dali", 26, Work.Екскурсовод);
            Assert.ThrowsException<ArgumentException>(() => employee2.IsEmpty(employee2.FirstName));
        }
        [TestMethod]
        public void TestWorker_Surname()
        {
            Employee employee3 = new Employee(1, "Salvador", "", 26, Work.Екскурсовод);
            Assert.ThrowsException<ArgumentException>(() => employee3.IsEmpty(employee3.LastName));
        }
        [TestMethod]
        public void TestWorker_Age()
        {
            Employee employee4 = new Employee(1, "Salvador", "Dali", 17, Work.Екскурсовод);
            Assert.ThrowsException<ArgumentException>(() => employee4.NormalAge(employee4.Age));
        }
        [TestMethod]
        public void TestRestaurant_Name()
        {
            Curator curator5 = new Curator("Didier", "Marien", 23, 777);
            List<Employee> workers2 = new List<Employee>();
            workers2.Add(new Employee(1, "Salvador", "Dali", 31, Work.Екскурсовод));
            workers2.Add(new Employee(2, "Claude", "Monet", 19, Work.Екскурсовод));
            workers2.Add(new Employee(3, "Leonardo", "da Vinci", 22, Work.Екскурсовод));
            ArtGallery restaurant2 = new ArtGallery("", curator5, workers2);
            Assert.ThrowsException<ArgumentException>(() => restaurant2.IsEmpty(restaurant2.Name));
        }
    }
}