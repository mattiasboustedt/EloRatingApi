using System.Collections.Generic;

namespace EloRatingApi.Models
{
    public class Result
    {
        private double ratingA;
        private double ratingB;
        private double ratingChangeA;
        private double ratingChangeB;

        public double RatingA { get { return ratingA; } set { ratingA = value; } }
        public double RatingB { get { return ratingB; } set { ratingB = value; } }
        public double RatingChangeA { get { return ratingChangeA; } set { ratingChangeA = value; } }
        public double RatingChangeB { get { return ratingChangeB; } set { ratingChangeB = value; } }

        public List<double> CalculateRatingChanges(double oldRatingA, double oldRatingB, double newRatingA, double newRatingB)
        {
            if (oldRatingA > newRatingA)
                ratingChangeA = newRatingA - oldRatingA;

            if (newRatingA > oldRatingA)
                ratingChangeA = newRatingA - oldRatingA;

            if (newRatingA == oldRatingA)
                ratingChangeA = 0;


            if (oldRatingB > newRatingB)
                ratingChangeB = newRatingB - oldRatingB;

            if (newRatingB > oldRatingB)
                ratingChangeB = newRatingB - oldRatingB;

            if (newRatingB == oldRatingB)
                ratingChangeA = 0;

            return new List<double>
            {
                ratingChangeA,
                ratingChangeB
            };

        }
    }
}