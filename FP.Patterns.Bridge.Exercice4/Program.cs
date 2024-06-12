// Create publishers
using FP.Patterns.Bridge.Exercice4;

IPublisher websitePublisher = new WebsitePublisher();
IPublisher mobileAppPublisher = new MobileAppPublisher();
IPublisher socialMediaPublisher = new SocialMediaPublisher();

// Create content
Content article = new Article(websitePublisher, "Bridge Pattern in C#", "The Bridge Pattern decouples an abstraction from its implementation.");
Content video = new Video(mobileAppPublisher, "Bridge Pattern Video", "Explaining the Bridge Pattern with examples.");
Content podcast = new Podcast(socialMediaPublisher, "Bridge Pattern Podcast", "A podcast about the Bridge Pattern.");

// Publish content
article.Publish();
video.Publish();
podcast.Publish();

// Demonstrate publishing the same content on a different platform
article = new Article(socialMediaPublisher, "Bridge Pattern in C#", "The Bridge Pattern decouples an abstraction from its implementation.");
article.Publish();

Console.ReadLine(); // Keep console window open