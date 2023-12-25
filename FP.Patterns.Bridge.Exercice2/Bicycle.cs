namespace FP.Patterns.Bridge.Exercice2
{
    public class Bicycle : IVehicle
    {
        private IAdditionalFeatures _additionalFeatures;

        public Bicycle(IAdditionalFeatures additionalFeatures)
        {
            _additionalFeatures = additionalFeatures;
        }

        public void ShowDetails()
        {
            Console.WriteLine("Bicycle");
            _additionalFeatures.ShowExtraFeatures();
        }
    }
}
