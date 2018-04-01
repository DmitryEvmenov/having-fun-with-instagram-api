using Newtonsoft.Json;

namespace Instagram.Models
{
    public partial class GetUsersFollowersResponse
    {
        [JsonProperty("data")]
        public GetUsersFollowersResponseData[] Data { get; set; }
    }

    public partial class GetUsersFollowersResponseData
    {
        [JsonProperty("username")]
        public string Username { get; set; }

        [JsonProperty("profile_picture")]
        public string ProfilePicture { get; set; }

        [JsonProperty("full_name")]
        public string FullName { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }
}
