using Exam.Project.Models.Entities.Abstract;

namespace Exam.Project.Models.Entities.Concrate;

public class PostComment : BaseEntity
{
    public int Id { get; set; }
    public int? PostId { get; set; }
    public int? CommentId { get; set; }
    public Post Post { get; set; }
    public Comment Comment { get; set; }
}
