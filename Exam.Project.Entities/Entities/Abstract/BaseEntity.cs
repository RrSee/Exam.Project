namespace Exam.Project.Models.Entities.Abstract;

public abstract class BaseEntity
{
    public int Id { get; set; }
    public bool IsDeleted { get; set; }
    public DateTime CreatedTime { get; set; }
    public DateTime UpdatedTime { get; set; }
    public DateTime? DeletedTime { get; set; }
}
