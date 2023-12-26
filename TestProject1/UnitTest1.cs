using Project;
using Project.Enums;

namespace Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestInspector_Normal()
        {
            Curator curator = new Curator("Didier", "Marien", 34, 10000);
            List<Artist> artist = new List<Artist>();
            artist.Add(new Artist(1, "Salvador", "Dali", ArtStyle.Realism));
            artist.Add(new Artist(2, "Claude", "Monet", ArtStyle.Abstract));
            artist.Add(new Artist(3, "Leonardo", "da Vinci", ArtStyle.Surrealism));
            ArtGallery artGallery = new ArtGallery("Louvre", curator, artist);
            Painting painting = new Painting(artist[0], "Mona Lisa", 300);
            string expected = $"Art Gallery: {artGallery.Name}, Owner: {curator.FirstName} {curator.LastName}, Painting: {painting.Title}";
            string actual = "Art Gallery: Louvre, Owner: Didier Marien, Painting: Mona Lisa";
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestOwner_Name()
        {
            Curator curator1 = new Curator("", "Marien", 23, 5000);
            Assert.ThrowsException<ArgumentNullException>(() => curator1);
        }
        [TestMethod]
        public void TestOwner_Surname()
        {
            Curator curator2 = new Curator("Didier", "", 23, 5000);
            Assert.ThrowsException<ArgumentNullException>(() => curator2);
        }
        [TestMethod]
        public void TestOwner_Age()
        {
            Curator curator3 = new Curator("Didier", "Marien", 17, 5000);
            Assert.ThrowsException<ArgumentException>(() => curator3);
        }
        [TestMethod]
        public void TestOwner_Income()
        {
            Curator curator4 = new Curator("Didier", "Marien", 17, -5000);
            Assert.ThrowsException<ArgumentException>(() => curator4);
        }
        [TestMethod]
        public void TestWorker_Id()
        {
            Artist artist = new Artist(-1, "Salvador", "Dali", ArtStyle.Realism);
            Assert.ThrowsException<ArgumentException>(() => artist);
        }
        [TestMethod]
        public void TestWorker_Name()
        {
            Artist artist2 = new Artist(1, "", "Dali", ArtStyle.Realism);
            Assert.ThrowsException<ArgumentNullException>(() => artist2);
        }
        [TestMethod]
        public void TestWorker_Surname()
        {
            Artist artist3 = new Artist(1, "Salvador", "", ArtStyle.Realism);
            Assert.ThrowsException<ArgumentException>(() => artist3);
        }
        [TestMethod]
        public void TestWorker_Age()
        {
            Artist artist4 = new Artist(1, "Salvador", "Dali", ArtStyle.Realism);
            Assert.ThrowsException<ArgumentNullException>(() => artist4);
        }
        [TestMethod]
        public void TestRestaurant_Name()
        {
            Curator curator5 = new Curator("Didier", "Marien", 34, 10000);
            List<Artist> artist5 = new List<Artist>();
            artist5.Add(new Artist(1, "Salvador", "Dali", ArtStyle.Realism));
            artist5.Add(new Artist(2, "Claude", "Monet", ArtStyle.Abstract));
            artist5.Add(new Artist(3, "Leonardo", "da Vinci", ArtStyle.Surrealism));
            ArtGallery artGallery2 = new ArtGallery("", curator5, artist5);
            Assert.ThrowsException<ArgumentNullException>(() => artGallery2);
        }
    }
}