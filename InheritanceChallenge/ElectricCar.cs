namespace InheritanceChallenge
{
    public class ElectricCar : Vehicle
    {
        public ElectricCar(string make, string model) : base(make, model)
        {
            NumOfGears = 1;
        }
    }
}