using System;
using Abp.Domain.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace FirstABP.Core.Entities
{
    [Table("T_User")]
    public class User : Entity
    {
        /// <summary>
        /// 用户名
        /// </summary>
        [MaxLength(200)]
        public virtual string UserName
        {
            get;
            set;
        }
        /// <summary>
        /// 密码
        /// </summary>
        [MaxLength(200)]
        public virtual string Password
        {
            get;
            set;
        }
        /// <summary>
        /// 是否开启
        /// </summary>
        public virtual bool? IsEnabled
        {
            get;
            set;
        }
        /// <summary>
        /// 是否删除
        /// </summary>
        public virtual bool? IsDeleted
        {
            get;
            set;
        }
        /// <summary>
        /// 创建时间
        /// </summary>
        public virtual DateTime? CreateTime
        {
            get;
            set;
        }
        /// <summary>
        /// 更新时间
        /// </summary>
        public virtual DateTime? UpdateTime
        {
            get;
            set;
        }
        public User()
        {

        }
    }
}