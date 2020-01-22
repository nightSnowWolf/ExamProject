namespace CatAlog.Db.Models.VideoTemplate
{
    public class Episode
    {
        public int Id { get; set; }

        public string Number { get; set; }

        public string Name { get; set; }

        public int SerialInformationId { get; set; }
        public SerialInfo SerialInformation { get; set; }
    }
}
