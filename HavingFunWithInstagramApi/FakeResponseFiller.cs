using System.Collections.Generic;
using Instagram.Models;

namespace HavingFunWithInstagramApi
{
    public static class FakeResponseFiller
    {
        public class FakeUserData
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Id { get; set; }
            public string Username { get; set; }

            public SearchUsersResponseData ToSearchUsersResponseData()
                => new SearchUsersResponseData
                {
                    FirstName = FirstName,
                    LastName = LastName,
                    Id = Id,
                    Username = Username
                };

            public GetUsersFollowersResponseData ToGetUsersFollowersResponseData()
                => new GetUsersFollowersResponseData
                {
                    FullName = FirstName + " " + LastName,
                    Id = Id,
                    Username = Username
                };
        }

        private static List<FakeUserData> _fakeUsers = new List<FakeUserData>
        {
            new FakeUserData
            {
                FirstName = "Jimmy",
                LastName = "Jones",
                Id = "1",
                Username = "j.jones2343"
            },
            new FakeUserData
            {
                FirstName = "Eliza",
                LastName = "Macintosh",
                Id = "1",
                Username = "elza_mac_1love"
            },
            new FakeUserData
            {
                FirstName = "Nikolai",
                LastName = "Nikolai",
                Id = "1",
                Username = "nikkk222"
            },
            new FakeUserData
            {
                FirstName = "Valeria",
                LastName = "Dona",
                Id = "1",
                Username = "donka.val"
            },
            new FakeUserData
            {
                FirstName = "James",
                LastName = "Lebron",
                Id = "1",
                Username = "j.jones2343"
            },
            new FakeUserData
            {
                FirstName = "Hellios",
                LastName = "Holas",
                Id = "1",
                Username = "helio_holassio"
            },
            new FakeUserData
            {
                FirstName = "Mike",
                LastName = "Mosser",
                Id = "1",
                Username = "i_love_m1lky_way"
            },
            new FakeUserData
            {
                FirstName = "Linda",
                LastName = "Flower",
                Id = "1",
                Username = "l.flower_morning"
            },
        };

        public static void Fill(SearchUsersResponse respose)
        {
            
        }
    }
}
