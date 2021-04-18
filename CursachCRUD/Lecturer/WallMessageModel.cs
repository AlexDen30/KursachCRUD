using System.ComponentModel.DataAnnotations;

namespace CursachCRUD.Lecturer
{
    public class WallMessageModel
    {
        [Key]
        public int Id { get; set; }

        public int LecturerId { get; set; }

        public string Content { get; set; }
    }
}
