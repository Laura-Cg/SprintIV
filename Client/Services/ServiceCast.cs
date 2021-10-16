using ProySprintIII.Shared.Entity;
using System;
using System.Collections.Generic;

namespace ProySprintIII.Client.Services
{
    public class ServiceCast: IServiceCast
    {
        public List <Cast> GetCast(){
            return new List<Cast>{
                new Cast (){ActorName = "Robert Downey Jr", ActorImage="/images/Actors/Actor1.jpg", BirthDate = new DateTime(2021,09,27), KnowCredits = 1, Nominations = "", Biography = "Biografia..."},
                new Cast (){ActorName = "Tom Holland", ActorImage="/images/Actors/Actor2.jpg", BirthDate = new DateTime(2021,09,27), KnowCredits = 1, Nominations = "", Biography = "Biografia..."},
                new Cast (){ActorName = "Scarlett Johansson", ActorImage="/images/Actors/Actor3.jpg",  BirthDate = new DateTime(2021,09,27), KnowCredits = 1, Nominations = "", Biography = "Biografia..."},
                new Cast (){ActorName = "Florence Pugh", ActorImage="/images/Actors/Actor4.jpg",  BirthDate = new DateTime(2021,09,27), KnowCredits = 1, Nominations = "", Biography = "Biografia..."},
                new Cast (){ActorName = "Simu Liu", ActorImage="/images/Actors/Actor5.jpg", BirthDate = new DateTime(2021,09,27), KnowCredits = 1, Nominations = "", Biography = "Biografia..."},
                new Cast (){ActorName = "Cho Yeo-jeong", ActorImage="/images/Actors/Actor6.jpg",  BirthDate = new DateTime(2021,09,27), KnowCredits = 1, Nominations = "", Biography = "Biografia..."},
                new Cast (){ActorName = "Park Seo-joon", ActorImage="/images/Actors/Actor7.jpg", BirthDate = new DateTime(2021,09,27), KnowCredits = 1, Nominations = "", Biography = "Biografia..."},
                new Cast (){ActorName = "Park So-dam", ActorImage="/images/Actors/Actor8.jpg",  BirthDate = new DateTime(2021,09,27), KnowCredits = 1, Nominations = "", Biography = "Biografia..."},
                new Cast (){ActorName = "Amy Adams", ActorImage="/images/Actors/Actor9.jpg",  BirthDate = new DateTime(2021,09,27), KnowCredits = 1, Nominations = "", Biography = "Biografia..."},
                new Cast (){ActorName = "Patrick Dempsey", ActorImage="/images/Actors/Actor10.jpg", BirthDate = new DateTime(2021,09,27), KnowCredits = 1, Nominations = "", Biography = "Biografia..."}
            };
        }
    }
}