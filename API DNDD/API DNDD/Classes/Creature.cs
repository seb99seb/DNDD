namespace API_DNDD.Classes
{
    public class Creature
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Size { get; set; }
        public int AC { get; set; }
        public int HP { get; set; }
        public string Speed { get; set; }
        public int STR { get; set; }
        public int DEX { get; set; }
        public int CON { get; set; }
        public string Skills { get; set; }
        public string Senses { get; set; }
        public double Challenge { get; set; }
        public int Proficiency { get; set; }
        public string Traits { get; set; }
        public string Actions { get; set; }
        public Creature() { }
        public Creature(int id, string name, string size, int armorClass, int hitPoints, string speed, int str, int dex, int con, string skills, string senses, double challenge, int proficieny, string traits, string actions)
        {
            Id= id;
            Name = name;
            Size = size;
            AC = armorClass;
            HP = hitPoints;
            Speed = speed;
            STR = str;
            DEX = dex;
            CON = con;
            Skills = skills;
            Senses = senses;
            Challenge = challenge;
            Proficiency = proficieny;
            Traits = traits;
            Actions = actions;
        }

    }
}
