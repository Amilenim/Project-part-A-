namespace Project
{
    public class ArtGallery : IPrintable
    {
        public string Name { get; set; }
        public Curator Curator { get; set; }
        public List<Employee> Employees { get; set; }
        public ArtGallery(string name)
        {
            Name = name;
        }
        public ArtGallery(string name, Curator curator, List<Employee> employees) : this(name)
        {
            Curator = curator;
            Employees = employees;
        }
        public void IsEmpty(string name)
        {
            if (string.IsNullOrEmpty(name)) throw new ArgumentException("Невiрний тип");
        }
        public override string ToString()
        {
            return $"{Curator.FirstName} {Curator.LastName}";
        }
        public string PrintToDisplay() 
        {
            string result = $"Хранитель: {Curator.FirstName} {Curator.LastName}, вiк - {Curator.Age}\nДохiд: {Curator.Income}\n\nРобочий - {Employees.Count}";
            foreach (Employee employee in Employees) 
            {
                result += $"\nРобочий {employee.Id}: {employee.FirstName} {employee.LastName}, вiк - {employee.Age}\nРобота '{employee.Work}'";
            }
            return result += "\n";
        }
    }
}
