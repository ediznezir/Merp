﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnTime.TaskManagement.Web.Areas.OnTime.Model.Task
{
    public class UpdateModel
    {
        [Required]
        public Guid TaskId { get; set; }

        [Required]
        public string Name { get; set; }

        public TaskPriority Priority { get; set; }

        public Guid? JobOrderId { get; set; }

        public enum TaskPriority
        {
            Low = 0,
            Standard = 1,
            High = 2,
            Critical = 3
        }
    }
}
