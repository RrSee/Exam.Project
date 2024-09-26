using Exam.Project.DAL.Context;
using Exam.Project.Models.Entities.Concrate;

namespace Exam.Project.DAL.Repository.Concrate;

public class CommentRepository:BaseRepository<Comment>
{
    public CommentRepository(ExamDbContext context) : base(context)
    {

    }
}
