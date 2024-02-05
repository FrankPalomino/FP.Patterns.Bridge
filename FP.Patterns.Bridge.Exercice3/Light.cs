namespace FP.Patterns.Bridge.Exercice3
{
    public class Light : IDevice
    {
        private IComunicationProtocol _protocol;
        public void SetConnection(IComunicationProtocol protocol)
        {
            _protocol = protocol;
        }

        public void TurnOff()
        {
            Console.WriteLine($"Lights turn off with {_protocol.Connect()} connection");
        }

        public void TurnOn()
        {
            Console.WriteLine($"Lights turn on with {_protocol.Connect()} connection");
        }
    }
}
