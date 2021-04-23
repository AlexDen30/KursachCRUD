using System.ComponentModel.DataAnnotations;

namespace CursachCRUD.TeachingWork
{
    public class TeachingWorkModel
    {
        [Key]
        public int Id { get; set; }

        public int TeacherId { get; set; }

        public byte[] TeachingPlan { get; set; }
    }
}
