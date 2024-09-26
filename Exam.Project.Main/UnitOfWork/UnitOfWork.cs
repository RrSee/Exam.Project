using Exam.Project.DAL.Context;
using Exam.Project.DAL.Repository.Abstract;
using Exam.Project.DAL.Repository.Concrate;
using Exam.Project.Models.Entities.Concrate;

namespace Exam.Project.Main.UnitOfWork;

public class UnitOfWork : IUnitOfWork
{
    private readonly ExamDbContext _context;
    public IRepository<User> Users { get;}
    public IRepository<UserDetails> UserDetails { get;}
    public IRepository<Post> Posts { get;}
    public IRepository<Comment> Comments { get;}

    public UnitOfWork(ExamDbContext context)
    {
        _context = context;

        // Repository'leri initialize ediyoruz
        Posts = new BaseRepository<Post>(_context);
        Comments = new BaseRepository<Comment>(_context);
        Users = new BaseRepository<User>(_context);
        UserDetails = new BaseRepository<UserDetails>(_context);
    }

    public int Complete()
    {
        return _context.SaveChanges();
    }

    public void Dispose()
    {
        _context.Dispose();
    }
}
