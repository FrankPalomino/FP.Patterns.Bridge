using FP.Patterns.Bridge.Exercice1;


ClientNotification clientNotification = new ClientNotification(new Push());
ClientNotification clientNotification2 = new ClientNotification(new Email());
ClientNotification clientNotification3 = new ClientNotification(new Sms());

clientNotification.Notify("Hello World");
clientNotification2.Notify("Hello World");
clientNotification3.Notify("Hello World");