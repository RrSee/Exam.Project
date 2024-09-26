using Exam.Project.DAL.Context;
using Exam.Project.Models.Entities.Concrate;

namespace Exam.Project.DAL.Repository.Concrate;

public class UserRepository : BaseRepository<User>
{
    public UserRepository(ExamDbContext context) : base(context)
    {

    }
}
