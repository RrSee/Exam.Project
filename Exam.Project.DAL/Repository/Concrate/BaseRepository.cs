using Exam.Project.DAL.Context;
using Exam.Project.DAL.Repository.Abstract;
using Exam.Project.Models.Entities.Abstract;
using Microsoft.EntityFrameworkCore;

namespace Exam.Project.DAL.Repository.Concrate;

public class BaseRepository<T> : IRepository<T> where T : BaseEntity, new()
{
    private readonly ExamDbContext _context;
    private readonly DbSet<T> _dbSet;

    public BaseRepository(ExamDbContext context)
    {
        _context = new ExamDbContext();
        _dbSet = _context.Set<T>();
    }

    public void Add(T entity)
    {
        _dbSet.Add(entity);
        entity.CreatedTime = DateTime.Now;
    }

    public void Delete(int Id)
    {
        var entity = _dbSet.FirstOrDefault(e => e.Id == Id);
        if (entity != null)
        {
            entity.IsDeleted = true;
            entity.DeletedTime = DateTime.Now;
        }
        else
            throw new NullReferenceException();
    }
    public ICollection<T> GetAll()
    {
        return _dbSet.Where(t => t.IsDeleted == false).ToList();
    }

    public T GetById(int Id)
    {
        return _dbSet.FirstOrDefault(t => t.Id == Id && t.IsDeleted == false);
    }
    public void Update(int Id)
    {
        throw new NotImplementedException();
    }

}
