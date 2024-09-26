using Exam.Project.DAL.Context;
using Exam.Project.Models.Entities.Concrate;

namespace Exam.Project.DAL.Repository.Concrate;

public class UserDetailsRepository : BaseRepository<UserDetails>
{
    public UserDetailsRepository(ExamDbContext context) : base(context)
    {

    }
}
