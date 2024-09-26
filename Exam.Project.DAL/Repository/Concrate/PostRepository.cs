using Exam.Project.DAL.Context;
using Exam.Project.Models.Entities.Concrate;

namespace Exam.Project.DAL.Repository.Concrate;

public class PostRepository: BaseRepository<Post>
{
    public PostRepository(ExamDbContext context) : base(context)
    {

    }
}
