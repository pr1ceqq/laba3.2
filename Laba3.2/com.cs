namespace army
{
    internal class Commanders : Soldier
    {
        public string Status { get; set; }

        public Commanders(int id, string specialty, string weapon, string status, string name)
            : base(id, specialty, weapon, name)
        {
            Status = status;
        }

    }
}