using GameApp.Abstract;
using GameApp.Adapters;
using GameApp.Concrete;
using GameApp.Entities;


// Oyuncu ekleme 
BaseUserManager baseUserManager = new PlayerManager(new MernisServiceAdapter());
baseUserManager.Add(new Player { DateOfBirth = (1997), FirstName = "Ahmet Ozan", LastName = "Akın", NationalityIdenty = "39280325282" });
//PlayerManager playerManager = new PlayerManager(new PlayerCheckManager());
//playerManager.Update(new Player { FirstName = "ozan"});
//playerManager.Delete(new Player { FirstName = "ozan" });


// Kampanya Oluşturma
BaseCampaignManager baseCampaignManager = new CampaignManager(new PlayerCheckManager());
baseCampaignManager.Add(new Campaign { Name = "Doğum gününüze özel kampanya : " }, new Player { FirstName = "Ahmet Ozan" });

// Oyun Satışı ve Kampanya oranı
BaseGameManager baseGameManager = new GameManager(new PlayerCheckManager());
baseGameManager.Sell(new Game { Name = "Temple Run"}, new Player { FirstName = "Ahmet Ozan"}, new Campaign { DiscountRate = 10 });