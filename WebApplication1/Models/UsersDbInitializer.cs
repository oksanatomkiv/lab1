using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class UsersDbInitializer : DropCreateDatabaseAlways<Lab6Context>
    {
        protected override void Seed(Lab6Context db)
        {
            Users user1 = db.Users.Add(new Users { UserId = 1, Name = "OksanaTomkiv", UserAge = 19 });
            Users user2 = db.Users.Add(new Users { UserId = 2, Name = "OleksandrSalamakha", UserAge = 21 });
            Users user3 = db.Users.Add(new Users { UserId = 3, Name = "ChristyKolodiy", UserAge = 19 });
            Users user4 = db.Users.Add(new Users { UserId = 4, Name = "SergiiNadakhovskii", UserAge = 21 });

            Games game1 = db.Games.Add(new Games { GameId = 1, GameName = "CounterStrike", GameType = "Shooter" });
            Games game2 = db.Games.Add(new Games { GameId = 2, GameName = "The Alder Scrolls", GameType = "RPG" });
            Games game3 = db.Games.Add(new Games { GameId = 3, GameName = "NeedForSpeed", GameType = "Racing" });
            Games game4 = db.Games.Add(new Games { GameId = 4, GameName = "State of Decay", GameType = "TPS" });

            Groups group1 = db.Groups.Add(new Groups { GroupId = 1, GroupName = "LovelyGroup" });
            Groups group2 = db.Groups.Add(new Groups { GroupId = 2, GroupName = "TheBest" });
            Groups group3 = db.Groups.Add(new Groups { GroupId = 3, GroupName = "Advanced" });

            game1.Users.Add(user1);
            game2.Users.Add(user2);
            game3.Users.Add(user3);
            game4.Users.Add(user4);

            group1.Users.Add(user1);
            group1.Users.Add(user2);
            group2.Users.Add(user3);
            group3.Users.Add(user4);

            base.Seed(db);
        }
    }
}