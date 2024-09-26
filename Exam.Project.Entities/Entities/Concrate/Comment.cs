using Exam.Project.Models.Entities.Abstract;

namespace Exam.Project.Models.Entities.Concrate;

public class Comment : BaseEntity
{
    public int Id { get; set; }
    public string Text { get; set; }
    public string Comment1 { get; set; }
    public int LikeCount { get; set; }
    public ICollection<PostComment> PostComments { get; set; }
}
