namespace InheritanceChallenge
{
    public class Motorcycle : Vehicle
    {
        public Motorcycle(string make, string model) : base(make, model)
        {
            NumOfTires = 2;
        }

       
    }

    public class Trike : Motorcycle
    {
        public Trike(string make, string model) : base(make, model)
        {
            NumOfTires = 3;
        }
    }
}