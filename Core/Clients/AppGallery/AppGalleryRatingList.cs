using System.Collections.Generic;
using Newtonsoft.Json;

namespace Core.Clients.AppGallery
{
    public class AppGalleryRatingList
    {
        [JsonProperty("ratingDstList")] public List<AppGalleryRating> RatingsList { get; set; }
    }

    public class AppGalleryRating
    {
        [JsonProperty("rating")] public int Rating { get; set; }

        [JsonProperty("ratingCounts")] public int RatingCounts { get; set; }
    }
}