using WebApplication2.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Document_vault.Data;

namespace WebApplication2.Data
{
    public class FileStoreContext:DbContext
    {


    public  FileStoreContext(DbContextOptions<FileStoreContext> options):base(options)
        {

        }

        public DbSet<SignUp> SignUps { get; set; }

        public DbSet<Admin> Admin_s { get; set; }
        public DbSet<Company_Details> Company_Details { get; set; }

        public DbSet<Contact_Detail> Contact_Details { get; set; }


        public DbSet<Document_Date_Detail> Document_Date_Details { get; set; }


        public DbSet<Document_Detail> Document_Details { get; set; }

        public DbSet<Logs_Details> Logs_Details { get; set; }

        public DbSet<Role_Selection> Role_Selections { get; set; }

        public DbSet<Status_Details> Status_Details { get; set; }

        public DbSet<User_Details> User_Details { get; set; }


        public DbSet<User_Profile_Details> User_Profile_Details { get; set; }


        public DbSet<WebApplication2.Data.Login> Login { get; set; }


        public DbSet<WebApplication2.Data.LoginAdmin> LoginAdmin { get; set; }



    }
}
