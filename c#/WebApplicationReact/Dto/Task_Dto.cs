using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dto
{
    public class Task_Dto
    {
        public int IdTask { get; set; }
        public string Title { get; set; }
        public  string Description { get; set; }
        public int IdPosition { get; set; }
        public bool Check { get; set; }

        //public Dal.Task DtoToDal()
        //{
        //    var config = new MapperConfiguration(cfg => cfg.CreateMap<Task_Dto, Dal.Task>());
        //    var mapper = new Mapper(config);
        //    return mapper.Map<Dal.Task>(this);
        //}
        //public static Task_Dto DaltoDto(Dal.Task task)
        //{
        //    var config = new MapperConfiguration(cfg => cfg.CreateMap<Dal.Task, Task_Dto>());
        //    var mapper = new Mapper(config);
        //    return mapper.Map<Task_Dto>(task);
        //}
    }
}
