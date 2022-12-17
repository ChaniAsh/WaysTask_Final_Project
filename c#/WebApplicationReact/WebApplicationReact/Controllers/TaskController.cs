using Bll;
using Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;


namespace WebApplicationReact.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]

    [RoutePrefix("api/tasks")]
    public class TaskController : ApiController
    {
        ConnectDb connect = new ConnectDb();
        // GET: api/Tasks

        [Route("getAllTasks")]
        [HttpGet]
        public IHttpActionResult GetTask()
        {

            return Ok(connect.GetAllTasks());
        }


        [Route("AddTask")]
        [HttpPost]
        public IHttpActionResult AddTask(Task_Dto task_Dto)
        {
            try
            {
                Task_Dto newTask = ConnectDb.AddNewTask(task_Dto);
                return Ok(newTask);
            }
            catch (Exception)
            {

                throw;
            }
        }


        //// GET: api/Customer/5
        //public string Get(int id)
        //{
        //    return "value";
        //}
        //[HttpGet]
        //[Route("api/Customer/GetById/{name}")]
        //public object GetByName(string name)
        //{
        //    return name;
        //}
        // POST: api/Customer
        //public void Post([FromBody]string value)
        //{
        //}

        // PUT: api/Customer/5
        public void Put(int id, [FromBody]string value)
        {
        }

        //DELETE: api/Customer/5
        [Route("DeleteTasks")]
        [HttpDelete]
        public IHttpActionResult DeleteTask([FromUri]int id)
        {     
            try
            {
               /* List<Task_Dto> lst = connect.GetAllTasks();
                var q = lst.First(x=>x.IdTask==id);*/
                ConnectDb.DeleteT(id);
                return Ok();
            }
            catch (Exception)
            {

                throw;
            }
        }
        [Route("UpdateTask")]
        [HttpPost]
        public IHttpActionResult UpdateTask([FromBody] Task_Dto task)
        {
            try
            {
                Task_Dto newT = ConnectDb.UpdateT(task);
                return Ok(newT);
            }
            catch (Exception)
            {

                throw;
            }
        }
        //DELETE: api/Customer/5
        [Route("FindTask")]
        [HttpDelete]
        public IHttpActionResult FindTask([FromUri] int id)
        {
            try
            {
                /* List<Task_Dto> lst = connect.GetAllTasks();
                 var q = lst.First(x=>x.IdTask==id);*/
                ConnectDb.DeleteT(id);
                return Ok();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
