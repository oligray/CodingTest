using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MovieSearch;

namespace Tests
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void Test_MovieTitlesAreSorted()
        {
            // Arrange
            string searchTerm = "Shawshank";

            string[] ExpectedResults = new string[] { "Hope Springs Eternal: A Look Back at 'The Shawshank Redemption'", "Shawshank: The Redeeming Feature", "The Shawshank Redemption",
                                    "The Shawshank Redemption (Scene)", "The Shawshank Redemption: Behind the Scenes", "The Shawshank Redemption: Cast Interviews", "The Shawshank Reflection" };

            // Act
            string[] ActualResults = MovieTitles.getMovieTitles(searchTerm);

            // Asset
            CollectionAssert.AreEqual(ExpectedResults, ActualResults);
        }

        [TestMethod]
        public void Test_MovieTitlesMultiPageResults()
        {
            // Arrange
            string searchTerm = "the lightning";

            string[] ExpectedResults = new string[] { "Behind the Storm: The Making of the Scent of Rain and Lightning", "Ben Franklin: Stealing Lightning from the Sky",
                    "Between the Lightning Strikes: The Making of 'Paul'", "Emily and the Lightning", "Goodnight to the Lightning", "Jakub Narkiewicz-Jodko. The Lightning Tamer, or the Electric Man",
                    "Journey of the Lightning Stalker", "Kilat: The Lightning", "Lightning Bolt: The Power of Salad", "Lightning in the Hand",  "Lightning Man: Defeat the Cavity-Mon",
                    "Lightning Man: The Allen Glukowski Story", "Lightning Strikes Twice: The Real-life Sequel to Moby Dick", "Lightning, the White Stallion", "Lightning: Fire from the Sky",
                    "Magicians of the Earth: The Giant Woman and the Lightning Man", "Ninja Girl: The Lightning Orb", "Percy Jackson & the Olympians: The Lightning Thief",
                    "Relámpago en la Oscuridad: Lightning in the Dark", "Ride the Lightning", "R-Type III: The Third Lightning", "Sara Jane and the Lightning Bugs",
                    "Sergeant Lightning and the Gorgonzola Gang", "Smokestack Lightning: A Day in the Life of Barbecue", "Smokestack Lightning: The Legendary Howlin' Wolf",
                    "The Adventures of Willie Woodbine and Lightning Larry -- A Joyride to the Cannibal Islands", "The Blue Lightning", "The City Struck by Lightning",
                    "The F-35 Lighting II: Can Lightning Strike Twice?", "The Flash: Chasing Lightning", "The Lightning and Thunder Case", "The Lightning Artist", "The Lightning Bell-Hop",
                    "The Lightning Bill-Poster", "The Lightning Bolt", "The Lightning Conductor", "The Lightning Express", "The Lightning Liver Cure", "The Lightning Paper Hanger",
                    "The Lightning Postcard Artist", "The Lightning Raider", "The Lightning Rider", "The Lightning Round", "The Lightning Slider", "The Lightning Testimonies",
                    "The Lightning Tree", "The Lightning War", "The Lightning Warrior", "The Making of 'The Shock of the Lightning'", "The Scent of Rain & Lightning",
                    "The Shadow of Lightning Ridge", "Thoreau and the Lightning", "We, Hit by the Lightning", "When the Lightning Struck" }

            // Act
            string[] ActualResults = MovieTitles.getMovieTitles(searchTerm);

            // Asset
            CollectionAssert.AreEqual(ExpectedResults, ActualResults);
        }

        [TestMethod]
        public void Test_MovieTitlesMultiPageDuplicatesRemoved()
        {
            // Arrange
            string searchTerm = "Hackers";

            string[] ExpectedResults = new string[] { "Cyber Guérilla: Hackers, pirates et guerres secrètes","Devil Summoner: Soul Hackers","Dream Hackers",
                "En busca de hackers","Hackers","Hackers 95","Hackers Are Not Dead","Hackers Are People Too","Hackers Computer Outlaws",
                "Hackers in Wonderland","Hackers Wanted","Hackers: Outlaws and Angels","Hackers: Wizards of the Electronic Age","Hekerji: The Hackers",
                "In the Realm of the Hackers","Lifebook Hackers","Machine Robo: Butchigiri Battle Hackers","ModPro Hackers","Reality Hackers","Space Hackers",
                "The Hackers","Tomb Hackers" };

            // Act
            string[] ActualResults = MovieTitles.getMovieTitles(searchTerm);

            // Asset
            CollectionAssert.AreEqual(ExpectedResults, ActualResults);
        }

        [TestMethod]
        public void Test_MovieTitlesNoResults()
        {
            // Arrange
            var searchTerm = "ThisHasToBeTheBestMovieEverWrittenThatNoOneHasWatched";

            string[] ExpectedResults = new string[] { };

            // Act
            var ActualResults = MovieTitles.getMovieTitles(searchTerm);

            // Asset
            CollectionAssert.AreEqual(ExpectedResults, ActualResults);
        }
    }
}
