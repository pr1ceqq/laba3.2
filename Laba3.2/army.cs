using System;
using System.Collections.Generic;

namespace army
{
    class Vzvid
    {

        public List<Soldier> Vzvod = new List<Soldier>();
        public List<Commanders> Com = new List<Commanders>();

        // Конструктор
        public Vzvid(List<Soldier> vzvod, List<Commanders> com)
        {
            Vzvod = vzvod;
            Com = com;
        }

        public void SortSpec(string specialitty)
        {
            Console.WriteLine("Сортування за видом спеціальності");
            Console.WriteLine();

            foreach (var item in Vzvod)
            {
                if (item.Specialty == specialitty)
                {
                    Console.WriteLine($"{item.Id}|{item.Name}|{item.Specialty}");
                }
            }
            Console.WriteLine();
        }

        public void SortWep(string weaponn)
        {
            Console.WriteLine("Сортування за видом зброї");
            Console.WriteLine();

            foreach (var item in Vzvod)
            {
                if (item.Weapon == weaponn)
                {
                    Console.WriteLine($"{item.Id}|{item.Name}|{item.Weapon}");
                }
            }
            Console.WriteLine();
        }

        public void SortVzvid(string op)
        {
            Console.WriteLine("Сортування за будь-яким параметром");
           
            foreach (var item in Vzvod)
            {
                if (item.Weapon == op || item.Name == op || item.Specialty == op || item.Id == Int32.Parse(op))
                {
                    Console.WriteLine($"{item.Id}|{item.Name}|{item.Weapon}|{item.Specialty}");
                }
            }
            Console.WriteLine();
        }
    }
}