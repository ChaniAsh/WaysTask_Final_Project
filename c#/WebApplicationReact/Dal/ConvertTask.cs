using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dto;

namespace Dal
{
    public partial class ConvertTask
    {
        public object Task_Dto { get; internal set; }

        public static Task_Dto ConvertToDto(Task task)
        {
            Task_Dto task_Dto = new Task_Dto();
            task_Dto.Title = task.title;
            task_Dto.Description = task.description;
            task_Dto.IdTask = task.idTask;
            task_Dto.IdPosition = (int)task.idPosition;
            task_Dto.Check = (bool)task.cheked;
            return task_Dto;
        }

        

        public static Task ConvertToDal(Task_Dto task_Dto)
        {
            Task task = new Task();
            task.title = task_Dto.Title;
            task.description = task_Dto.Description;
            task.idTask = task_Dto.IdTask;
            task.idPosition = task_Dto.IdPosition;
            task.cheked = task_Dto.Check;
            return task;
        }
    }
}
