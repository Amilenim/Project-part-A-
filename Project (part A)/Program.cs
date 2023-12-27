using Project.Enums;

namespace Project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<ArtInspector> list = new List<ArtInspector>();
            int i = 0;
            while (true)
            {
                try { 
                Console.WriteLine("1 - Оцiнiть галерею\n2 - Додати галерею в список\n3 - Видалити галерею зi список\n4 - Змiнити зберiгача\n5 - Контрольний список\n0 - Вихiд");
                int choose = Convert.ToInt32(Console.ReadLine());
                if (choose == 0) { break; }
                    switch (choose)
                    {
                        case 1:
                            i = 0;
                            if (list.Count == 0)
                                throw new Exception("Порожнiй список!");
                            Console.WriteLine("Виберiть:\n");
                            foreach (ArtInspector rating in list)
                            {
                                Console.WriteLine(++i + " " + rating.ToString() + "\n");
                            }
                            i = Convert.ToInt32(Console.ReadLine());
                            if (i <= list.Count && list[i - 1].Rating != null)
                                throw new Exception("Вже оцiнений!");
                            Console.WriteLine("Будь ласка, оцiнiть галерею:");
                            choose = Convert.ToInt32(Console.ReadLine());
                            if (choose >= 0 && choose <= 10)
                            {
                                list[i - 1].Rating = choose;
                                Console.WriteLine("Рейтинг");
                            }
                            break;
                        case 2:
                            Console.WriteLine("Введiть назву галереї:");
                            string? name = Console.ReadLine();
                            bool enough = false;
                            ArtInspector added;
                            ArtGallery artGallery;
                            Curator curator;
                            List<Employee> employees = new List<Employee>();
                            if (name != null)
                            {
                                artGallery = new ArtGallery(name);
                                string[] strings;
                                do
                                {
                                    Console.WriteLine("Введiть iм'я, прiзвище, вiк та дохiд зберiгача галереї:\nПриклад: Девiд Рон 34 41241");
                                    name = Console.ReadLine();
                                    strings = name.Split();
                                    if (strings.Length != 4)
                                        throw new Exception("Невiрний тип");
                                    enough = true;
                                } while (!enough);
                                curator = new Curator(strings[0], strings[1], Convert.ToInt32(strings[2]), Convert.ToInt32(strings[3]));
                                Console.WriteLine("Зберiгач додан!");
                                Console.WriteLine("Виберiть нижче кiлькiсть працiвникiв галереї");
                                choose = Convert.ToInt32(Console.ReadLine());
                                for (int k = 0; k < choose; k++)
                                {
                                    Employee employee;
                                    enough = false;
                                    while (!enough)
                                    {
                                        Console.WriteLine("Введiть iм'я, прiзвище, вiк та тип роботи (Екскурсовод, Доглядач, Реставратор) працiвника галереї:\nПример: Джон Уик 47 Реставратор");
                                        name = Console.ReadLine();
                                        strings = name.Split();
                                        if (strings.Length < 4 || strings.Length > 4)
                                            throw new Exception("Невiрний тип!");
                                        int choise = 0;
                                        switch (strings[3])
                                        {
                                            case "Екскурсовод":
                                                enough = true;
                                                choise = 1;
                                                break;
                                            case "Доглядач":
                                                enough = true;
                                                choise = 2;
                                                break;
                                            case "Реставратор":
                                                enough = true;
                                                choise = 3;
                                                break;
                                            default:
                                                throw new Exception("Невiрний тип!"); 
                                        }
                                        if (enough)
                                        {
                                            employee = new Employee(k + 1, strings[0], strings[1], Convert.ToInt32(strings[2]), (Work)choise);
                                            employees.Add(employee);
                                            Console.WriteLine("Додан рабочий!");
                                        }
                                    }
                                }
                                name = artGallery.Name;
                                artGallery = new ArtGallery(name, curator, employees);
                                added = new ArtInspector(artGallery, null);
                                list.Add(added);
                            }
                            break;
                        case 3:
                            if (list.Count == 0)
                                throw new Exception("Пустий список!"); 
                            else
                            {
                                i = 0;
                                Console.WriteLine("Вибрати:\n");
                                foreach (ArtInspector rating in list)
                                {
                                    Console.WriteLine(++i + " " + rating.ToString() + "\n");
                                }
                                i = Convert.ToInt32(Console.ReadLine());
                                list.RemoveAt(i - 1);
                                Console.WriteLine("Видалений!");
                            }
                            break;
                        case 4:
                            if (list.Count == 0)
                                throw new Exception("Пустий список!"); 
                            else
                            {
                                if (list.Count > 1)
                                {
                                    i = 0;
                                    Console.WriteLine("Виберiть зберiгача:\n");
                                    foreach (ArtInspector rating in list)
                                    {
                                        Console.WriteLine(++i + " " + rating.ToString() + $"\n{rating.ArtGallery.ToString()}\n");
                                    }
                                    i = Convert.ToInt32(Console.ReadLine());
                                    Curator copy = (Curator)list[i - 1].ArtGallery.Curator.Clone();
                                    int sort = 0;
                                    Console.WriteLine("Виберiть зберiгача:, якого хочете замiнити:\n");
                                    foreach (ArtInspector rating in list)
                                    {
                                        sort++;
                                        if (sort != i)
                                            Console.WriteLine(sort + " " + rating.ToString() + $"\n{rating.ArtGallery.ToString()}\n");
                                    }
                                    sort = Convert.ToInt32(Console.ReadLine());
                                    if (sort != i)
                                    {
                                        list[sort - 1].ArtGallery.Curator = copy;
                                        Console.WriteLine("Змiнено!");
                                    }
                                    else
                                        throw new Exception("Невiрний варiант!");
                                }
                            }
                            break;
                        case 5:
                            Console.WriteLine();
                            if (list.Count == 0)
                                throw new Exception("Пустий список!"); 
                            else
                                foreach (ArtInspector inspec in list)
                                    Console.WriteLine(inspec.PrintToDisplay());
                            break;
                        default:
                            throw new Exception("Невiрний варiант!");
                    }
                }
                catch (ArgumentNullException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}