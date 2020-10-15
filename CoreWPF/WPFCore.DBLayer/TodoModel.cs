namespace WPFCore.DBLayer
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class TodoModel : DbContext
    {
        public TodoModel()
            : base("name=TodoEntities")
        {
        }

        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<TodoItem> TodoItems { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>()
                .Property(e => e.CategoryName)
                .IsUnicode(false);

            modelBuilder.Entity<Category>()
                .Property(e => e.BackColor)
                .IsUnicode(false);

            modelBuilder.Entity<Category>()
                .HasMany(e => e.TodoItems)
                .WithRequired(e => e.Category)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TodoItem>()
                .Property(e => e.Title)
                .IsUnicode(false);

            modelBuilder.Entity<TodoItem>()
                .Property(e => e.Description)
                .IsUnicode(false);
        }
    }
}
