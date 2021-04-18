using System.ComponentModel.DataAnnotations;

namespace CursachCRUD.ScientificWork
{
    public class ScientificWorkModel
    {
        [Key]
        public int Id { get; set; }

        public int TeacherId { get; set; }

        public int MentorId { get; set; }

        public string Content { get; set; }

        public byte[] TeachingPlan { get; set; }
    }
}
