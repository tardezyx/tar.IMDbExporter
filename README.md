# tar.IMDbExporter

 - [X] C# .NET 8.0

![IMDbExporter](https://raw.githubusercontent.com/tardezyx/tar.IMDbExporter/main/Images/IMDbExporter.png)

## Function

This app can be used to scrape and export various IMDb title information by using the <a href="https://github.com/tardezyx/tar.IMDbScraper/">IMDbScraper library</a>.

<details>
  <summary>Function list</summary>
  <ul>
    <li>all alternate titles ("Also known as" = AKAs)</li>
    <li>all awards</li>
    <li>all awards for a particular awards event (via enum)</li>
    <li>all awards for a particular awards event (via string)</li>
    <li>all awards events</li>
    <li>all companies</li>
    <li>all companies of a particular category (via enum)</li>
    <li>all connections</li>
    <li>all connections of a particular category (via enum)</li>
    <li>all external reviews</li>
    <li>all external sites</li>
    <li>all external sites of a particular category (via enum)</li>
    <li>all filming dates</li>
    <li>all filming locations</li>
    <li>all goofs</li>
    <li>all goofs of a particular category (via enum)</li>
    <li>all keywords</li>
    <li>all news</li>
    <li>all plot summaries</li>
    <li>all quotes</li>
    <li>all release dates</li>
    <li>all seasons</li>
    <li>all topics</li>
    <li>all trivia entries</li>
    <li>all user reviews</li>
    <li>alternate versions page</li>
    <li>awards page</li>
    <li>crazy credits page</li>
    <li>critics reviews page</li>
    <li>episodes card (2 top ranked and 2 most recent episodes, if available)</li>
    <li>FAQ page</li>
    <li>full credits page</li>
    <li>locations page</li>
    <li>main news (without details)</li>
    <li>main page</li>
    <li>next episode (if available)</li>
    <li>parental guide page</li>
    <li>ratings page</li>
    <li>reference page</li>
    <li>soundtrack page</li>
    <li>storyline</li>
    <li>suggestions (search on IMDb)</li>
    <li>taglines page</li>
    <li>technical page</li>
  </ul>
</details>

## Caution

It is recommended to not scrape all information at once and it also does not make any sense to store everything in your own database which could not only be a legal issue but is also immediately outdated as the IMDb data is updated regularly. Therefore, you should only scrape and store general information (e.g. title(s), year(s), genre(s), plot(s)) and scrape the other info when you really need (to display) it. This is also due to the duration a particular scrape needs (e.g. it takes already around 42 seconds to scrape all 37 seasons of "The Simpsons" without detailed information of each episode).

## Hashes

IMDb regularly changes the hashes which are used for most of the requests. The hashes are updated once on the initial run and whenever the last update older as the given period (in days) or the path to the .json file has been adjusted where the hashes are stored. Therefore a simulated browser is used which you need leave open until it is finished whereby it closes automatically.

Furthermore, you can also adjust the .json file manually as follows:
<ol>
  <li>Open the corresponding site listed below with Firefox, click F12 to show the Web Dev Tools window
  <li>Go to Network Analysis and sort by Host
  <li>On the site, click on "More..." below the corresponding items
  <li>In Web Dev Tools window: check new entry for File starting with "/?operationName=" to find the corresponding operation
  <li>Copy the value from `Header Lines` -> `GET` -> `extensions` -> `sha256Hash` to the .json file</li>
</ol>

Operation | GET-Operation-Name | Page | How to retrieve
--- | --- | --- | ---
AllAwardsEvents | AllEventsPage | https://www.imdb.com/event/all/ | no click necessary
AllTopics | TitleAllTopics | https://www.imdb.com/title/tt0068646/keywords/ | no click necessary
AlternateTitles | TitleAkasPaginated | https://www.imdb.com/title/tt0068646/releaseinfo/ | click on "More"
Awards | TitleAwardsSubPagePagination | https://www.imdb.com/title/tt0068646/awards/ | click on "More"
CompanyCredits | TitleCompanyCreditsPagination | https://www.imdb.com/title/tt0068646/companycredits/ | click on "More"
Connections | TitleConnectionsSubPagePagination | https://www.imdb.com/title/tt0068646/movieconnections/ | click on "More"
EpisodesCard | TMD_Episodes_EpisodesCardContainer | https://www.imdb.com/title/tt0072562/ | no click necessary
ExternalReviews | TitleExternalReviewsPagination | https://www.imdb.com/title/tt0068646/externalreviews/ | click on "More"
ExternalSites | TitleExternalSitesSubPagePagination | https://www.imdb.com/title/tt0068646/externalsites/ | click on "More"
FilmingDates | TitleFilmingDatesPaginated | https://www.imdb.com/title/tt0944947/locations/ | click on "More"
FilmingLocations | TitleFilmingLocationsPaginated | https://www.imdb.com/title/tt0068646/locations/ | click on "More"
Goofs | TitleGoofsPagination | https://www.imdb.com/title/tt0068646/goofs/ | click on "More"
Keywords | TitleKeywordsPagination | https://www.imdb.com/title/tt0068646/keywords/ | click on "More"
MainNews | TitleMainNews | https://www.imdb.com/title/tt0072562/ | only scroll down
News | TitleNewsPagination | https://www.imdb.com/title/tt0072562/news/ | click on "More"
NextEpisode | TMD_Episodes_NextEpisode | https://www.imdb.com/title/tt0072562/ | no click necessary
PlotSummaries |TitlePlotSummariesPaginated | https://www.imdb.com/title/tt4154796/plotsummary/ | click on "More"
Quotes | TitleQuotesPagination | https://www.imdb.com/title/tt0068646/quotes/ | click on "More"
ReleaseDates | TitleReleaseDatesPaginated | https://www.imdb.com/title/tt0068646/releaseinfo/ | click on "More"
Storyline | TMD_Storyline | https://www.imdb.com/title/tt0072562/ | only scroll down
Trivia | TitleTriviaPagination | https://www.imdb.com/title/tt0068646/trivia/ | click on "More"

## Usage

Just download and start a release.
