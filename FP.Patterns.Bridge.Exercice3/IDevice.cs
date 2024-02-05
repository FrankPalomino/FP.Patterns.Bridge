namespace FP.Patterns.Bridge.Exercice3
{
    public interface IDevice
    {
        void TurnOn();
        void TurnOff();
        void SetConnection(IComunicationProtocol protocol);
    }
}
