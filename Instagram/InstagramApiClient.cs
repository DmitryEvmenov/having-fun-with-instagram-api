using System.Net.Http;
using Instagram.Models;
using Newtonsoft.Json;

namespace Instagram
{
    public class InstagramApiClient
    {
        private static readonly HttpClient Client = new HttpClient();
        private const string InstagramAccessToken = "1535702573.7037be0.5d7fe4aa562a4772bfdc84c6f56d8c50";
        private const string InstagramApiBaseUrl = "https://api.instagram.com/v1/";
        private static string AccessTokenQueryParam => $"access_token={InstagramAccessToken}";

        public SearchUsersResponse SearchUsers(string queryString, long count = 50)
            => GetAsync<SearchUsersResponse>(InstagramApiBaseUrl + $"users/search?q={queryString}&count={count}&");

        public GetUsersFollowersResponse GetUserFollowers(string userId)
            => GetAsync<GetUsersFollowersResponse>(InstagramApiBaseUrl + $"users/{userId}/followed-by?");

        private T GetAsync<T>(string url)
            => JsonConvert.DeserializeObject<T>(Client
                .GetAsync($"{url}{AccessTokenQueryParam}").Result.Content
                .ReadAsStringAsync().Result);
    }
}
