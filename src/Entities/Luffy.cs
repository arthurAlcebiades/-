namespace dotnet.src.Entities
{
    public class Luffy
    {
        public Luffy(string Name, string Fruit, string Attacks1, string Attacks2, string Transformation)
        {
            this.Name = Name;
            this.Fruit = Fruit;
            this.Attacks1 = Attacks1;
            this.Attacks2 = Attacks2;
            this.Transformation = Transformation;
        }

        public string Name;
        public string Fruit;
        public string Attacks1;
        public string Attacks2;
        public string Transformation;

        public override string ToString()
        {
            return this.Name + ", " + this.Fruit;
        }

        public string Attack()
        {
            return this.Name + ", " + this.Attacks1;
        }
        
        public string Gear()
        {
            return Transformation;
        }
    }
}