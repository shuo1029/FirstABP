using Abp.Application.Services.Dto;
using Abp.Runtime.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstABP.UserApp.Dto
{
    public class UserInput : IInputDto, IShouldNormalize
    {
        [Required]
        public string UserName { get; set; }

        [Required]
        public string Password { get; set; }

        public bool? IsEnabled { get; set; }

        public bool? IsDeleted { get; set; }

        public DateTime? CreateTime { get; set; }

        public DateTime? UpdateTime { get; set; }

        public void Normalize()
        {
            IsDeleted = false;
            IsEnabled = true;

            if (CreateTime.HasValue == false)
            {
                CreateTime = DateTime.Now;
            }
        }
    }

    public class UserOutput : IOutputDto
    {
        public string UserName { get; set; }
        public bool? IsEnabled { get; set; }
    }
}
