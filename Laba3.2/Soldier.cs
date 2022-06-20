namespace army
{
    class Soldier
    {
        public int Id { get; set; }
        public string Specialty { get; set; }

        public string Weapon { get; set; }
        public string Name { get; set; }

        public Soldier(int id, string specialty, string weapon, string name)
        {
            Id = id;
            Specialty = specialty;
            Weapon = weapon;
            Name = name;
        }

    }
}