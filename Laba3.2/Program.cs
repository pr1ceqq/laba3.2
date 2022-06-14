namespace Завдання2
{
    //Армія. Визначити ієрархію військових. Створити кілька об'єктів-взводів(Невеликий військовий підрозділ у різних родах військ).
    //Сортувати військових згідно бойової спеціальності.
    //Провести сортування взводів на основі одного за параметірв.
    //Вивести список військових, які користуються однаковим видом зброї.

    internal class Soldier
    {
        public int Id { get; set; }
        public string Specialty { get; set; }

        public string Weapon { get; set; }

        public Soldier(int id, string specialty, string weapon)
        {
            Id = id;
            Specialty = specialty;
            Weapon = weapon;
        }

    }
    internal class Commanders : Soldier
    {
        public string Status { get; set; }

        public Commanders(int id, string specialty, string weapon, string status)
            : base(id, specialty, weapon)
        {
            Status = status;
        }

    }

    internal class Vzvid
    {

        public List<Soldier> Vzvod = new List<Soldier>();
        public List<Commanders> Com = new List<Commanders>();

        // Конструктор
        public Vzvid(List<Soldier> vzvod, List<Commanders> com)
        {
            Vzvod = vzvod;
            Com = com;
        }
        
        public void ShowVzvid()
        {
            foreach (var v in Com)
            {
                Console.WriteLine(v.Id);
                Console.WriteLine($"{v.Specialty} | {v.Weapon} | {v.Status}");
                Console.WriteLine();
            }

            foreach (var v in Vzvod)
            {
                Console.WriteLine(v.Id);
                Console.WriteLine($"{v.Specialty} | {v.Weapon}");
                Console.WriteLine();
            }

        }

        public void SortVzvid()
        {
            foreach (var item in Vzvod)
            {
                if (item.Weapon == "AK-47")
                {
                    Console.WriteLine();
                }
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {

            Vzvid Vzvоd1 = new Vzvid(new List<Soldier>()
            {
             new Soldier(17, "Shooter", "AK-47"),
             new Soldier(18, "Shooter", "AK-47"),
             new Soldier(19, "Shooter", "AK-47"),
             new Soldier(20, "Shooter", "AK-47"),
             new Soldier(21, "Shooter", "AK-47"),
             new Soldier(22, "Shooter", "AK-47"),
             new Soldier(23, "Shooter", "AK-47"),
             new Soldier(24, "Shooter", "AK-47"),
            },

           new List<Commanders>()
           {
           new Commanders(1,"Strategist","Mozg","Lieutenant")
           }
           );

            Vzvоd1.ShowVzvid();
            Vzvоd1.SortVzvid();
            Console.ReadLine();
        }
    }
}