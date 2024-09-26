using Exam.Project.Models.Entities.Abstract;

namespace Exam.Project.Models.Entities.Concrate;

public class UserDetails : BaseEntity
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Surname { get; set; }
    public DateTime BirthDay { get; set; }
    public enum Status
    {
        Admin,
        User
    }
    public int? UserId { get; set; } // Nullable
    public User User { get; set; }
}
