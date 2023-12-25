namespace FP.Patterns.Bridge.Exercice2
{
    public class ElectricScooter : IVehicle
    {
        private IAdditionalFeatures _additionalFeatures;

        public ElectricScooter(IAdditionalFeatures additionalFeatures)
        {
            _additionalFeatures = additionalFeatures;
        }

        public void ShowDetails()
        {
            Console.WriteLine("ElectricScooter");
            _additionalFeatures.ShowExtraFeatures();
        }
    }
}
