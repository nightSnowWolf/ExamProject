using CatAlog.Db.Models.General;

namespace CatAlog.Db.Models.Relationship
{
    public class AudioInfo_Actor
    {
        public int AudioInfoId { get; set; }
        public VideoTemplate.AudioInfo AudioInfo { get; set; }

        public int ActorId { get; set; }
        public Actor Actor { get; set; }
    }
}
