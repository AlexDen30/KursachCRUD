using System.ComponentModel.DataAnnotations;

namespace CursachCRUD.Student
{
    public class StudentModel
    {
        [Key]
        public int Id { get; set; }

        public int Course { get; set; }

        public string Status { get; set; }

        public int UserId { get; set; }
    }
}
