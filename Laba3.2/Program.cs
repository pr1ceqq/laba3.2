using System;
using System.Collections.Generic;
using army;

namespace Завдання2
{
    //Армія. Визначити ієрархію військових. Створити кілька об'єктів-взводів(Невеликий військовий підрозділ у різних родах військ).
    //Сортувати військових згідно бойової спеціальності.
    //Провести сортування взводів на основі одного за параметірв.
    //Вивести список військових, які користуються однаковим видом зброї.

    class Program
    {
        static void Main(string[] args)
        {

            Vzvid Vzvоd1 = new Vzvid(new List<Soldier>()
            {
             new Soldier(17, "Communicator","Rifle", "Verba Yaroslav"),
             new Soldier(18, "Communicator","Rifle", "Maistrenko Mykyta"),
             new Soldier(19, "Communicator","Rifle","Mizinov Maksym"),
             new Soldier(20, "Artillerist","Grenade launcher", "Marzhievskiy Alex"),
             new Soldier(21, "Scout","Automatic weapons", "Kaiskii Kirill"),
             new Soldier(22, "Communicator","Rifle", "Lazarev Denys"),
             new Soldier(23, "Artillerist","Grenade launcher", "Tyshenko Andriy"),
             new Soldier(24, "Artillerist","Grenade launcher","Lasinskiy Nikita"),
             new Soldier(25, "Communicator","Rifle", "Kalenskiy Misha"),
             new Soldier(26, "Scout","Automatic weapons", "Usupov Hleb"),
             new Soldier(27, "Scout","Automatic weapons", "Chaminov Ramil"),
             new Soldier(28, "Communicator","Rifle", "Rubinov Leonid"),
             new Soldier(29, "Artillerist","Grenade launcher", "Nemchinskiy Yurii"),
             new Soldier(30, "Scout","Automatic weapons", "Popasniy Alexander"),

            },

           new List<Commanders>()
           {
           new Commanders(1,"Strategist - Ohrimenko Sergiy","Mozg - Firsik Yan","Lieutenant - Lozovinskiy Demian", ""),
           }
           );

            Vzvоd1.SortVzvid("24");
            Vzvоd1.SortSpec("Artillerist");
            Vzvоd1.SortWep("Rifle");
            Console.ReadLine();
        }
    }
}