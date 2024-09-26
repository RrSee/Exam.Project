using Exam.Project.DAL.Context;
using Exam.Project.Main.UnitOfWork;
using Exam.Project.Models.Entities.Concrate;

class Program()
{
    static void Main(string[] args)
    {
        using(var context = new ExamDbContext())
        {
            var unitOfWork = new UnitOfWork(context);
            var newUser = new User
            {
                UserDetails = new UserDetails
                {
                    Name = "Ahmet",
                    Surname = "Yılmaz",
                    BirthDay = new DateTime(1990, 1, 1),
                    CreatedTime = DateTime.Now
                },
                CreatedTime = DateTime.Now
            };

            unitOfWork.Users.Add(newUser);
            Console.WriteLine("Yeni kullanıcı eklendi.");



            var newPost = new Post
            {
                Text = "İlk Postum",
                Comment = "Bu bir başlangıçtır.",
                UserId = newUser.Id, // Kullanıcı ID'si
                CommentId = 1,
                CreatedTime = DateTime.Now
            };;
            unitOfWork.Posts.Add(newPost);
            Console.WriteLine("Yeni post eklendi.");



            var newComment = new Comment
            {
                Text = "Bu harika bir post!",
                LikeCount = 10,
                CreatedTime = DateTime.Now
            };
            unitOfWork.Comments.Add(newComment);
            Console.WriteLine("Yeni yorum eklendi.");

            unitOfWork.Complete();
        }
    }
}