namespace FP.Patterns.Bridge.Exercice2
{
    public class Car : IVehicle
    {
        private IAdditionalFeatures _additionalFeatures;

        public Car(IAdditionalFeatures additionalFeatures)
        {
            _additionalFeatures = additionalFeatures;
        }

        public void ShowDetails()
        {
            Console.WriteLine("Car");
            _additionalFeatures.ShowExtraFeatures();
        }
    }
}
