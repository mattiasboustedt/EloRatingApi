using System.Collections.Generic;
using System.Net;
using System.Web.Http;
using EloRatingApi.Models;
using Swashbuckle.Swagger.Annotations;
using Newtonsoft.Json;

namespace EloRatingApi.Controllers
{
    public class RatingsController : ApiController
    {
        [SwaggerOperation("CalculateNewRating")]
        [SwaggerResponse(HttpStatusCode.OK)]
        [SwaggerResponse(HttpStatusCode.BadRequest)]
        public string Get(double ratingA, double ratingB, double scoreA, double scoreB)
        {
            Rating rating = new Rating(ratingA, ratingB, scoreA, scoreB);
            List<double> ratingsList = rating.GetNewRatings();

            Result result = new Result()
            {
                RatingA = ratingsList[0],
                RatingB = ratingsList[1]
            };

            List<double> ratingChanges = result.CalculateRatingChanges(ratingA, ratingB, result.RatingA, result.RatingB);

            result.RatingChangeA = ratingChanges[0];
            result.RatingChangeB = ratingChanges[1];

            string finalResult = JsonConvert.SerializeObject(result);

            return finalResult;
        }
    }
}
