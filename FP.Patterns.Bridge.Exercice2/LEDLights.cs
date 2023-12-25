namespace FP.Patterns.Bridge.Exercice2
{
    public class LEDLights : IAdditionalFeatures
    {
        public void ShowExtraFeatures()
        {
            Console.WriteLine("LEDS lights added");
        }
    }
}
