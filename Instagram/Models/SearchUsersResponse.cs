using Newtonsoft.Json;

namespace Instagram.Models
{


    public partial class SearchUsersResponse
    {
        [JsonProperty("data")]
        public SearchUsersResposeData[] Data { get; set; }
    }

    public partial class SearchUsersResposeData
    {
        [JsonProperty("username")]
        public string Username { get; set; }

        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        [JsonProperty("profile_picture")]
        public string ProfilePicture { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("last_name")]
        public string LastName { get; set; }
    }
}
