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
            Owner owner = new Owner("Didier", "Marien", 34, 10000);
            List<Artist> artist = new List<Artist>();
            artist.Add(new Artist(1, "Salvador", "Dali", ArtStyle.Realism));
            artist.Add(new Artist(2, "Claude", "Monet", ArtStyle.Abstract));
            artist.Add(new Artist(3, "Leonardo", "da Vinci", ArtStyle.Surrealism));
            ArtGallery artGallery = new ArtGallery("Louvre", owner, artist);
            Painting painting = new Painting(artist[0], "Mona Lisa", 300);
            string expected = $"Art Gallery: {artGallery.Name}, Owner: {owner.FirstName} {owner.LastName}, Painting: {painting.Title}";
            string actual = "Art Gallery: Louvre, Owner: Didier Marien, Painting: Mona Lisa";
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestOwner_Name()
        {
            Owner owner1 = new Owner("", "Marien", 23, 5000);
            Assert.ThrowsException<ArgumentNullException>(() => owner1);
        }
        [TestMethod]
        public void TestOwner_Surname()
        {
            Owner owner2 = new Owner("Didier", "", 23, 5000);
            Assert.ThrowsException<ArgumentNullException>(() => owner2);
        }
        [TestMethod]
        public void TestOwner_Age()
        {
            Owner owner3 = new Owner("Didier", "Marien", 17, 5000);
            Assert.ThrowsException<ArgumentException>(() => owner3);
        }
        [TestMethod]
        public void TestOwner_Income()
        {
            Owner owner4 = new Owner("Didier", "Marien", 17, -5000);
            Assert.ThrowsException<ArgumentException>(() => owner4);
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
            Owner owner5 = new Owner("Didier", "Marien", 34, 10000);
            List<Artist> artist5 = new List<Artist>();
            artist5.Add(new Artist(1, "Salvador", "Dali", ArtStyle.Realism));
            artist5.Add(new Artist(2, "Claude", "Monet", ArtStyle.Abstract));
            artist5.Add(new Artist(3, "Leonardo", "da Vinci", ArtStyle.Surrealism));
            ArtGallery artGallery2 = new ArtGallery("", owner5, artist5);
            Assert.ThrowsException<ArgumentNullException>(() => artGallery2);
        }
    }
}