namespace FP.Patterns.Bridge.Exercice3
{
    public class Adsl : IComunicationProtocol
    {

        string IComunicationProtocol.Connect()
        {
            return "ADSL";
        }
    }
}
