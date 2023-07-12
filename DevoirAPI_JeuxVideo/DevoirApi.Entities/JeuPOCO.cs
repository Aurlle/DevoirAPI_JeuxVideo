namespace DevoirApi.Entities
{
    public class JeuPOCO
    {
        public int Id { get; set; }
        public string Titre { get; set; }
        public int AnneeSortie { get; set; }
        public double Note { get; set; }
        public string Descriptif { get; set; }
        public string Genre_Id { get; set; }

    }
}