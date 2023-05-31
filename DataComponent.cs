﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;



namespace HotelWebApi.Models
{
    [Table("Menu")]
    public class hotel
    {
        [Key]
        public int dishid { get; set; }
        [Required]
        public string dishName { get; set; } = string.Empty;
        public string dishreview { get; set; } = string.Empty;
        public int dishPrice { get; set; }
        public string dishimage { get; set; } = string.Empty;



    }
    public class hotelcomponent : DbContext
    {
        public DbSet<hotelcomponents> hotel { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            const string strcon = "Data Source=W-674PY03-1;Initial Catalog=NidhiDb;Persist Security Info=True;User ID=sa;Password=Password@12345;TrustServerCertificate=True";
            optionsBuilder.UseSqlServer(strcon);
            base.OnConfiguring(optionsBuilder);
        }
    }
    interface Ihotelcharge
    {
        void Additem(hotelcomponents item);
        void Updateitem(hotelcomponents item);
        hotelcomponents Getitem(int id);
        List<hotelcomponents> Getitems();
        void RemoveItem(int id);
    }
    class hoteldata : Ihotelcharge
    {
        public void Additem(hotelcomponents item)
        {
            var context = new hotelcomponent();
            context.hotel.Add(item);
            context.SaveChanges();
        }



        public hotelcomponents Getitem(int id)
        {
            var context = new hotelcomponent();
            var founditem = context.hotel.FirstOrDefault(x => x.dishid == id);
            if (founditem != null)
            {
                return founditem;
            }
            else
            {
                throw new Exception("No item found !");
            }
        }



        public List<hotelcomponents> Getitems()
        {
            var context = new hotelcomponent();
            var items = context.hotel.ToList();
            if (items != null)
            {
                return items;
            }
            else
            {
                throw new Exception("items not found!");
            }
        }



        public void RemoveItem(int id)
        {
            var context = new hotelcomponent();
            var find = context.hotel.FirstOrDefault(x => x.dishid == id);
            if (find != null)
            {
                context.hotel.Remove(find);
            }
            else
            {
                throw new Exception("No item found!!");
            }



        }



        public void Updateitem(hotelcomponents item)
        {
            var context = new hotelcomponent();
            var data = context.hotel.FirstOrDefault(x => x.dishid == item.dishid);
            if (data != null)
            {
                data.dishreview = item.dishreview;
                data.dishPrice = item.dishPrice;
                data.dishName = item.dishName;
                data.dishimage = item.dishimage;
            }
            context.SaveChanges();
        }
    }
}