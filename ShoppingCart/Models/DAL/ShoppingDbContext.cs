namespace ShoppingCart.Models.Entities
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
   

    public partial class ShoppingDbContext : DbContext
    {
        public ShoppingDbContext()
            : base("name=ShoppingDbContext")
        {
        }

        public virtual DbSet<AspNetRole> AspNetRoles { get; set; }
        public virtual DbSet<AspNetUserClaim> AspNetUserClaims { get; set; }
        public virtual DbSet<AspNetUserLogin> AspNetUserLogins { get; set; }
        public virtual DbSet<AspNetUser> AspNetUsers { get; set; }
        public virtual DbSet<Equipment_Item_Details> Equipment_Item_Details { get; set; }
        public virtual DbSet<Equipment_Kit> Equipment_Kit { get; set; }
        public virtual DbSet<Event> Events { get; set; }
        public virtual DbSet<Event_Members> Event_Members { get; set; }
        public virtual DbSet<Event_Roles> Event_Roles { get; set; }
        public virtual DbSet<Item> Items { get; set; }
        public virtual DbSet<Item_Order_Details> Item_Order_Details { get; set; }
        public virtual DbSet<Language> Languages { get; set; }
        public virtual DbSet<Loan> Loans { get; set; }
        public virtual DbSet<Loan_Detail> Loan_Detail { get; set; }
        public virtual DbSet<Medium> Media { get; set; }
        public virtual DbSet<Media_Access> Media_Access { get; set; }
        public virtual DbSet<Media_Comment> Media_Comment { get; set; }
        public virtual DbSet<Media_Type> Media_Type { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<ShoppingCart> ShoppingCarts { get; set; }
        public virtual DbSet<ShoppingCart_item> ShoppingCart_item { get; set; }
        public virtual DbSet<Sponsor_Event> Sponsor_Event { get; set; }
        public virtual DbSet<Status> Status { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AspNetRole>()
                .HasMany(e => e.AspNetUsers)
                .WithMany(e => e.AspNetRoles)
                .Map(m => m.ToTable("AspNetUserRoles").MapLeftKey("RoleId").MapRightKey("UserId"));

            modelBuilder.Entity<AspNetUser>()
                .Property(e => e.interest)
                .IsUnicode(false);

            modelBuilder.Entity<AspNetUser>()
                .HasMany(e => e.AspNetUserClaims)
                .WithRequired(e => e.AspNetUser)
                .HasForeignKey(e => e.UserId);

            modelBuilder.Entity<AspNetUser>()
                .HasMany(e => e.AspNetUserLogins)
                .WithRequired(e => e.AspNetUser)
                .HasForeignKey(e => e.UserId);

            modelBuilder.Entity<AspNetUser>()
                .HasMany(e => e.Events)
                .WithOptional(e => e.AspNetUser)
                .HasForeignKey(e => e.user_id);

            modelBuilder.Entity<AspNetUser>()
                .HasMany(e => e.Event_Members)
                .WithRequired(e => e.AspNetUser)
                .HasForeignKey(e => e.user_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<AspNetUser>()
                .HasMany(e => e.Loans)
                .WithOptional(e => e.AspNetUser)
                .HasForeignKey(e => e.user_id);

            modelBuilder.Entity<AspNetUser>()
                .HasMany(e => e.Media)
                .WithOptional(e => e.AspNetUser)
                .HasForeignKey(e => e.user_id);

            modelBuilder.Entity<AspNetUser>()
                .HasMany(e => e.Media_Comment)
                .WithOptional(e => e.AspNetUser)
                .HasForeignKey(e => e.user_id);

            modelBuilder.Entity<AspNetUser>()
                .HasMany(e => e.ShoppingCarts)
                .WithOptional(e => e.AspNetUser)
                .HasForeignKey(e => e.user_id);

            modelBuilder.Entity<AspNetUser>()
                .HasMany(e => e.Sponsor_Event)
                .WithOptional(e => e.AspNetUser)
                .HasForeignKey(e => e.user_id);

            modelBuilder.Entity<Equipment_Item_Details>()
                .Property(e => e.status_code)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Equipment_Kit>()
                .Property(e => e.status_code)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Event>()
                .Property(e => e.event_title)
                .IsUnicode(false);

            modelBuilder.Entity<Event>()
                .Property(e => e.event_descr)
                .IsUnicode(false);

            modelBuilder.Entity<Event>()
                .Property(e => e.location)
                .IsUnicode(false);

            modelBuilder.Entity<Event>()
                .HasMany(e => e.Event_Members)
                .WithRequired(e => e.Event)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Event_Roles>()
                .Property(e => e.event_role_desc)
                .IsUnicode(false);

            modelBuilder.Entity<Item>()
                .Property(e => e.item_name)
                .IsUnicode(false);

            modelBuilder.Entity<Item>()
                .Property(e => e.item_descr)
                .IsUnicode(false);

            modelBuilder.Entity<Item>()
                .HasMany(e => e.Loan_Detail)
                .WithRequired(e => e.Item)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Item_Order_Details>()
                .Property(e => e.cost)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Language>()
                .Property(e => e.lang_descr)
                .IsUnicode(false);

            modelBuilder.Entity<Loan>()
                .HasMany(e => e.Loan_Detail)
                .WithRequired(e => e.Loan)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Loan_Detail>()
                .Property(e => e.reason)
                .IsUnicode(false);

            modelBuilder.Entity<Medium>()
                .Property(e => e.fileUrl)
                .IsUnicode(false);

            modelBuilder.Entity<Medium>()
                .Property(e => e.credit)
                .IsUnicode(false);

            modelBuilder.Entity<Medium>()
                .Property(e => e.media_title)
                .IsUnicode(false);

            modelBuilder.Entity<Medium>()
                .Property(e => e.media_alt_title)
                .IsUnicode(false);

            modelBuilder.Entity<Medium>()
                .Property(e => e.media_descr)
                .IsUnicode(false);

            modelBuilder.Entity<Medium>()
                .Property(e => e.media_code)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Medium>()
                .Property(e => e.status_code)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Media_Access>()
                .Property(e => e.access_descr)
                .IsUnicode(false);

            modelBuilder.Entity<Media_Comment>()
                .Property(e => e.comment)
                .IsUnicode(false);

            modelBuilder.Entity<Media_Type>()
                .Property(e => e.media_code)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Media_Type>()
                .Property(e => e.media_descr)
                .IsUnicode(false);

            modelBuilder.Entity<Order>()
                .Property(e => e.username)
                .IsUnicode(false);

            modelBuilder.Entity<Order>()
                .Property(e => e.subtotal)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Order>()
                .Property(e => e.gst)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Sponsor_Event>()
                .Property(e => e.event_descr)
                .IsUnicode(false);

            modelBuilder.Entity<Sponsor_Event>()
                .Property(e => e.event_url)
                .IsUnicode(false);

            modelBuilder.Entity<Sponsor_Event>()
                .Property(e => e.location)
                .IsUnicode(false);

            modelBuilder.Entity<Status>()
                .Property(e => e.status_code)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Status>()
                .Property(e => e.status_descr)
                .IsUnicode(false);
        }
    }
}
