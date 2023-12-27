using Project.Enums;
using Project.Interfaces;

namespace Project
{
    public class Employee : IPerson, ITest
    {
        public int Id { get; set; }
        public override string FirstName { get; set; }
        public override string LastName { get; set; }
        public override int Age { get; set; }
        public Work Work { get; set; }
        public Employee(int id, string name, string surname, int age, Work work)
        {
            Id = id;
            FirstName = name;
            LastName = surname;
            Age = age;
            Work = work;
        }
        public void IsEmpty(string text)
        {
            if (string.IsNullOrEmpty(text) || text == " " || text == "") throw new ArgumentException("Невiрний тип");
        }
        public void NormalAge(int age)
        {
            if (age < 18 || age > 70) throw new ArgumentException("Невiрний тип");
        }
        public void Enough(int id)
        {
            if (id < 0) throw new ArgumentException("Невiрний тип");
        }
    }
}
