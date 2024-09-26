using Exam.Project.DAL.Context;
using Exam.Project.DAL.Repository.Abstract;
using Exam.Project.DAL.Repository.Concrate;
using Exam.Project.Models.Entities.Concrate;

namespace Exam.Project.Main.UnitOfWork;

public interface IUnitOfWork
{
    IRepository<Post> Posts { get; }
    IRepository<Comment> Comments { get; }
    IRepository<User> Users { get; }
    IRepository<UserDetails> UserDetails { get; }

    int Complete();
}
