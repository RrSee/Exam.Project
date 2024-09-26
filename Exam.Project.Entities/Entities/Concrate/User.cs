using Exam.Project.Models.Entities.Abstract;

namespace Exam.Project.Models.Entities.Concrate;

public class User : BaseEntity
{
    public int Id { get; set; }
    public UserDetails UserDetails { get; set; }
    public ICollection<Post> Posts { get; set; }
}
