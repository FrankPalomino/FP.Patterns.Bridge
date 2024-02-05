using FP.Patterns.Bridge.Exercice3;

Adsl adsl = new Adsl();
Bluetooth bluetooth = new Bluetooth();
Wifi wifi = new Wifi();

Light light = new Light();
light.SetConnection(adsl);
light.TurnOn();
light.TurnOff();

light.SetConnection(wifi);
light.TurnOn();
light.TurnOff();

Thermostat thermostat = new Thermostat();
thermostat.SetConnection(bluetooth);
thermostat.TurnOn();
thermostat.TurnOff();

thermostat.SetConnection(adsl);
thermostat.TurnOn();
thermostat.TurnOff();