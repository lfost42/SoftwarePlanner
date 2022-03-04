﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwarePlannerLibrary.Models
{
    public class TeamModel
    {
        public int Id { get; set; }
        public string Team { get; set; }
        public string Description { get; set; }

        [Display(Name = "Members")]
        public virtual ICollection<UserModel> UserModels { get; set; }
        //[Display(Name = "Projects")]
        //public virtual ICollection<ProjectModel> ProjectModels { get; set; }
        //[Display(Name = "Notifications")]
        //public virtual ICollection<NotificationModel> NotificationModels { get; set; }

        //public int ProjectModelId { get; set; }
        //public ProjectModel ProjectModel { get; set; }

    }
}
