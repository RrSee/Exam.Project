using Exam.Project.Models.Entities.Abstract;

namespace Exam.Project.Models.Entities.Concrate;

public class Post : BaseEntity
{
    public int Id { get; set; }
    public string Text { get; set; }
    public string Comment { get; set; }
    public int LikeCount { get; set; }
    public int? UserId { get; set; } // Nullable
    public int? CommentId { get; set; } // Nullable
    public User User { get; set; }
    public ICollection<PostComment> PostComments { get; set; }
}
