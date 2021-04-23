using System.ComponentModel.DataAnnotations;

namespace CursachCRUD.Lecturer
{
    public class LecturerModel
    {
        [Key]
        public int Id { get; set; }

        public string Achivments { get; set; }

        public string Publications { get; set; }

        public string TeachingInfo { get; set; }

        public int UserId { get; set; }

        public byte[] Photo { get; set; }

    }
}
