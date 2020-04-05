namespace RPG
{
    public class Burn : ICurse
    {
        public Burn()
        {
            CurseDuration  = 1;
        }
        public string CurseName { get; set; } = "Огонь";
        public int CurseDamage { get; set; } = 2;
        public int CurseDuration { get; set; } = -1;
        public bool Skipping { get; set; } = false;
    }
}