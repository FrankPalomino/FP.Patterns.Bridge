namespace FP.Patterns.Bridge.Exercice3
{
    public class Thermostat : IDevice
    {
        private IComunicationProtocol _protocol;
        public void SetConnection(IComunicationProtocol protocol)
        {
            _protocol = protocol;
        }

        public void TurnOff()
        {
            Console.WriteLine($"Thermostat turn off with {_protocol.Connect()} connection");
        }

        public void TurnOn()
        {
            Console.WriteLine($"Thermostat turn on with {_protocol.Connect()} connection");
        }
    }
}
