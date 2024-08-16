using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;
using RestSharp.Authenticators;
using Newtonsoft.Json;
using System.Windows.Forms;

namespace MALRenamer
{
    static class Jikan
    {
        private static readonly RestClient client = new RestClient("https://api.jikan.moe/v4/");
        private static readonly RateLimiter rateLimiter = new RateLimiter(1, 30); // Adjust the rate limiter parameters as needed

        private class EpisodesResponse
        {
            [JsonProperty(PropertyName = "pagination")]
            public Pagination Pageination { get; set; }

            [JsonProperty(PropertyName = "data")]
            public List<Episode> Episodes { get; set; }
        }

        public class Pagination
        {
            [JsonProperty(PropertyName = "last_visible_page")]
            private int? _pageCount { get; set; }

            public int LastVisiblePage { get => _pageCount ?? 1; set => _pageCount = value; }
        }

        public class Episode
        {
            [JsonProperty(PropertyName = "episode_id")]
            public int ID { get; set; }

            [JsonProperty(PropertyName = "title")]
            public string Title { get; set; }

            [JsonProperty(PropertyName = "title_japanese")]
            public string TitleJP { get; set; }

            [JsonProperty(PropertyName = "title_romanji")]
            public string TitleRO { get; set; }
            
        }

        private class AnimeResponse
        {
            [JsonProperty(PropertyName = "data")]
            public AnimeData[] Data { get; set; }
        }


        public class AnimeData
        {
            [JsonProperty(PropertyName = "mal_id")]
            public int MalId { get; set; }

            [JsonProperty(PropertyName = "url")]
            public string Url { get; set; }

            [JsonProperty(PropertyName = "images")]
            public Images Images { get; set; }

            [JsonProperty(PropertyName = "episodes")]
            private int? _episodeCount { get; set; }

            public int Episodes { get => _episodeCount ?? 0; set => _episodeCount = value; }

            [JsonProperty(PropertyName = "title")]
            public string Title { get; set; }

            [JsonProperty(PropertyName = "aired")]
            public Aired aired { get; set; }

            [JsonProperty(PropertyName = "synopsis")]
            public string Synopsis { get; set; }
        }

        public class Images
        {
            [JsonProperty(PropertyName = "jpg")]
            public ImageInfo Jpg { get; set; }
        }

        public class ImageInfo
        {
            [JsonProperty(PropertyName = "image_url")]
            public string ImageUrl { get; set; }
            // Add other image properties as needed
        }

        public class Aired
        {
            [JsonProperty(PropertyName = "from")]
            public string From { get; set; }
        }

        public class AnimeGeneralInfo
        {
            [JsonProperty(PropertyName = "data")]
            public GeneralInfo Data { get; set; }
        }

        public class GeneralInfo
        {
            [JsonProperty(PropertyName = "url")]
            public string URL { get; set; }

            [JsonProperty(PropertyName = "images")]
            public Images Images { get; set; }

            [JsonProperty(PropertyName = "title")]
            public string Title { get; set; }

            [JsonProperty(PropertyName = "title_english")]
            public string TitleEnglish { get; set; }

            [JsonProperty(PropertyName = "title_japanese")]
            public string TitleJapanese { get; set; }

            [JsonProperty(PropertyName = "episodes")]
            private int? _episodeCount { get; set; }

            public int EpisodeCount { get => _episodeCount ?? 0; set => _episodeCount=value; }
        }

        static public async Task<List<Episode>> GetEpisodesAsync(string animeId)
        {
            List<Episode> episodes = new List<Episode>();
            int pageNum = 1;
            int pageCount = 1;
            while (pageNum <= pageCount)
            {
                await rateLimiter.DelayIfNeededAsync();

                var request = new RestRequest($"anime/{animeId}/episodes", Method.Get);
                request.AddParameter("page", pageNum);

                var response = await client.ExecuteAsync(request);
                if (!response.IsSuccessful)
                {
                    // Handle the error (e.g., log it, throw an exception, etc.)
                    throw new Exception($"Request failed with status code {response.StatusCode}");
                }

                var tempResponse = JsonConvert.DeserializeObject<EpisodesResponse>(response.Content);
                if (tempResponse == null || tempResponse.Episodes == null)
                {
                    // Handle unexpected response
                    throw new Exception("Failed to deserialize response or response is null");
                }

                episodes.AddRange(tempResponse.Episodes);

                // Update pageCount based on the response
                pageCount = tempResponse.Pageination.LastVisiblePage;

                pageNum++;
            }

            return episodes;
        }

        public static List<Episode> GetEpisodes(string animeId)
        {
            return GetEpisodesAsync(animeId).GetAwaiter().GetResult();
        }

        static public AnimeData[] Search(string searchQuery)
        {
            var request = new RestRequest("anime", Method.Get);
            request.AddParameter("q", searchQuery);
            var response = client.Execute(request);
            var results = JsonConvert.DeserializeObject<AnimeResponse>(response.Content).Data;
            return results;
        }

        static public AnimeGeneralInfo GetInfo(string animeId)
        {
            var request = new RestRequest("anime/" + animeId, Method.Get);
            var response = client.Execute(request);
            return JsonConvert.DeserializeObject<AnimeGeneralInfo>(response.Content);
        }
    }
}
