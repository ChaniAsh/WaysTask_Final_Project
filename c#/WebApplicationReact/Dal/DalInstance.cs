using Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Dal
{
    public class DalInstance
    {
        public static projectTasksEntities db = new projectTasksEntities();
        public static ConvertTask convert =new ConvertTask();
        public void Save()
        {
            try
            {
                db.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static List<Task_Dto> GetAllTask(List<Task> lst)
        {
            try
            {
                using (projectTasksEntities db = new projectTasksEntities())
                {
                    List<Task> task = db.Task.ToList();
                    return task.Select(x => ConvertTask.ConvertToDto(x)).ToList();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static Task_Dto AddTask(Task_Dto taskDto)
        {
            try
            {
                using (projectTasksEntities db = new projectTasksEntities())
                {
                    Task t = db.Task.Add(ConvertTask.ConvertToDal(taskDto));
                    db.SaveChanges();
                    return taskDto;
                }
            }
            catch (Exception)
            {
                Console.WriteLine("errorrrrrrrrrrrrrrrr");
                throw;
            }
        }

        public static Task_Dto UpdateT(Task_Dto task)
        {
            try
            {
                using (projectTasksEntities db = new projectTasksEntities())
                {
                    Task t = db.Task.Find(task.IdTask);
                    if(t!=null)
                    {
                        db.Entry(t).CurrentValues.SetValues(ConvertTask.ConvertToDal(task));
                        db.SaveChanges();
                    }
                    return task;
                }
            }
            catch (Exception)
            {
                Console.WriteLine("errorrrrrrrrrrrrrrrr");
                throw;
            }
        }

        public static void DeleteTask(int id)
        {
            try
            {
                using (projectTasksEntities db = new projectTasksEntities())
                {
                    Task t = db.Task.ToList().Where(x => x.idTask == id).FirstOrDefault();
                    db.Entry(t).State = System.Data.Entity.EntityState.Deleted;
                    db.SaveChanges();
                }
            }
            catch (Exception)
            {
                Console.WriteLine("errorrrrrrrrrrrrrrrr");
                throw;
            }
        }
    }
}
