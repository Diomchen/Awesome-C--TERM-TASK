﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace 高级人事管理系统
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class MSDSecondEntities : DbContext
    {
        public MSDSecondEntities()
            : base("name=MSDSecondEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Admin> Admin { get; set; }
        public virtual DbSet<department> department { get; set; }
        public virtual DbSet<staff> staff { get; set; }
        public virtual DbSet<CheckStaff> CheckStaff { get; set; }
        public virtual DbSet<TaskStaff> TaskStaff { get; set; }
        public virtual DbSet<ApplySalary> ApplySalary { get; set; }
    }
}
