# EloRatingApi C#
The Elo rating system is a method for calculating the relative skill levels of players in competitor-versus-competitor games such as chess. 
<br /> 
<br />
Read more at [Wikipedia](http://en.wikipedia.org/wiki/Elo_rating_system).

# Usage
Deploy to for example Azure.
Do a get request and include the following query parameters:

ratingA (Current Rating), <br />
ratingB (Current Rating), <br />
scoreA, (1 for win, 0 for loose, 0.5 for draw)<br />
scoreB, (1 for win, 0 for loose, 0.5 for draw). <br />

Example: <br />
Player one (with a rating of 1200) beats player two (with a rating of 1100). <br />
http://yoururl/api/Ratings?ratingA=1200&ratingB=1100&scoreA=1&scoreB=0

Returns json: <br />
"{\"RatingA\":1205.0,\"RatingB\":1095.0,\"RatingChangeA\":5.0,\"RatingChangeB\":-5.0}" <br />
RatingA and RatingB represents the new rating. RatingChangeA and RatingChangeB is the rating change relative to the old rating (Positive or negative).
<br />
<br /> 
If you are only interested in the Elo Rating C# class, click [here](https://github.com/mattiasboustedt/EloRating)

# License
<span xmlns:dct="http://purl.org/dc/terms/" property="dct:title">Elo Rating C#</span> by Mattias Boustedt is licensed under a <a rel="license" href="http://creativecommons.org/licenses/by/4.0/">Creative Commons Attribution 4.0 International License</a>.
