namespace FP.Patterns.Bridge.Exercice3
{
    public class SmartPlug : IDevice
    {
        private IComunicationProtocol _protocol;
        public void SetConnection(IComunicationProtocol protocol)
        {
            _protocol = protocol;
        }

        public void TurnOff()
        {
            Console.WriteLine($"Turn Off Smart Plug With {_protocol.Connect()} connection");
        }

        public void TurnOn()
        {
            Console.WriteLine($"Turn On Smart Plug With {_protocol.Connect()} connection");
        }
    }
}
