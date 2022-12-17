using Dal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dto;

namespace Bll
{
    public class ConnectDb
    {
        projectTasksEntities db = new projectTasksEntities();

        public List<Task_Dto> GetAllTasks()
        {

            List<Dto.Task_Dto> lst = new List<Dto.Task_Dto>();
            foreach (var item in db.Task.ToList())
            {
                lst.Add(ConvertTask.ConvertToDto(item));
            }

            return lst;
        }

        //public List<Position_Dto> GetAllPositions()
        //{
        //    List<Position_Dto> lst = new List<Position_Dto>();
        //    foreach (var item in db.Position.ToList())
        //    {
        //        lst.Add(Position.(item));
        //    }
        //    return lst;
        //}

        public static Task_Dto AddNewTask(Task_Dto task_Dto)
        {
            return DalInstance.AddTask(task_Dto);
        }
        public static void DeleteT(int id)
        {
             DalInstance.DeleteTask(id);
        }

        public static Task_Dto UpdateT(Task_Dto task)
        {
            return DalInstance.UpdateT(task);
        }



        //public void AddPosition(Position_Dto position)
        //{
        //    DalInstance.db.Position.Add(position.DtoToDal());
        //    DalInstance.db.SaveChanges();
        //}
        //public void AddTask(Task_Dto task)
        //{
        //    DalInstance.db.Task.Add(task);
        //    DalInstance.db.SaveChanges();
        //}
        //public Task_Dto GetCustomerById(string id)
        //{
        //    Dto.Task_Dto customer = new Dto.Task_Dto();
        //    List<Dto.Task_Dto> lst = GetAllCustomers();
        //    foreach (var item in lst)
        //    {
        //        if (item.id == id)
        //        {
        //            customer = item;
        //        }               
        //    }
        //    return customer;
        //}

        //public Task_Dto GetCustomerByName(string name)
        //{
        //    Dto.Task_Dto customer = new Dto.Task_Dto();
        //    List<Dto.Task_Dto> lst = GetAllCustomers();
        //    foreach (var item in lst)
        //    {
        //        if (item.name == name)
        //        {
        //            customer = item;
        //        }
        //    }
        //    return customer;
        //}



    }
}
