using CursachCRUD.Global_news;
using CursachCRUD.Student;
using CursachCRUD.User;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CursachCRUD
{
    class Program
    {
        static void Main(string[] args)
        {
            INewsRepository newsRep = new NewsRepository();
            //List<NewsModel> news = newsRep.GetAllNews().ToList();

            //foreach (NewsModel n in news)
            //{
            //    Console.WriteLine(n.Id + " " + n.Content + " " + n.DocName);
            //}

            ////for (int i = 1; i < 9; i++)
            ////{
            ////    NewsModel another = new NewsModel();
            ////    another.Content = i.ToString();
            ////    newsRep.AddNews(another);
            ////}

            //news = newsRep.GetLastTenNews().ToList();
            //foreach (NewsModel n in news)
            //{
            //    Console.WriteLine(n.Id + " " + n.Content + " " + n.DocName);
            //}

            //newsRep.DeleteNews(10);

            IUserRepository usRep = new UserRepository();
            IStudentRepository stRep = new StudentRepository();

            //UserModel user = new UserModel();
            //user.BirthDate = "12.12.2000";
            //user.Email = "sdsdvsd";
            //user.FIO = "AA sAS ASA";
            //user.Password = "asasdasda";
            //user.Sex = "male";

            //usRep.AddUser(user);
            //List<UserModel> users = usRep.GetAllUsers().ToList();
            //foreach (UserModel n in users)
            //{
            //    Console.WriteLine(n.Id + " " + n.FIO + " " + n.Password);
            //}

            //usRep.ChangeStatus("student", 1);
            //StudentModel stud = new StudentModel();
            //stud.Course = 2;
            //stud.Status = "2nd curse of mag, good dude ";
            //stud.UserId = 1;

            //stRep.AddStudent(stud);
            List<StudentModel> students = stRep.GetAllStudents().ToList();
            foreach (StudentModel n in students)
            {
                Console.WriteLine(n.Id + " " + n.Status + " " + n.Course);
            }
        }
    }
}
