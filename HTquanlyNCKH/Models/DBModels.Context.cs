﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HTquanlyNCKH.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DBModel : DbContext
    {
        public DBModel()
            : base("name=DBModel")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Field> Fields { get; set; }
        public virtual DbSet<Status> Status { get; set; }
        public virtual DbSet<Council> Councils { get; set; }
        public virtual DbSet<Degree> Degrees { get; set; }
        public virtual DbSet<Foreign> Foreigns { get; set; }
        public virtual DbSet<Place> Places { get; set; }
        public virtual DbSet<Unit> Units { get; set; }
        public virtual DbSet<Nation> Nations { get; set; }
        public virtual DbSet<KeyWord> KeyWords { get; set; }
        public virtual DbSet<ArtType> ArtTypes { get; set; }
        public virtual DbSet<Conference> Conferences { get; set; }
        public virtual DbSet<Slider> Sliders { get; set; }
        public virtual DbSet<Classification> Classifications { get; set; }
        public virtual DbSet<Intro> Introes { get; set; }
        public virtual DbSet<Topic> Topics { get; set; }
    }
}
