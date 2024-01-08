using Microsoft.EntityFrameworkCore;
using MeviyImporter.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeviyImporter.Data
{
    public class MeviyImporterDBContext : DbContext
    {

        //パーツのDBテーブル
        public DbSet<Part> Parts { get; set; }


        public MeviyImporterDBContext()
        {

        }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //SQLiteを使用するための宣言
            optionsBuilder.UseSqlite("Data source=C:\\meviy\\meviy.db");

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //テーブルとクラスの紐づけ
            modelBuilder.Entity<Part>().ToTable("Parts");

            //主キーにIdentityを設定
            //SQLiteの場合はValueGeneratedOnAddを使用する。
            modelBuilder.Entity<Part>()
                .Property(x => x.Id)
                .ValueGeneratedOnAdd();
        }
    }
}
