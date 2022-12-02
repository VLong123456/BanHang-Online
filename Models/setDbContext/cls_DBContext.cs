using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using banhang_online.Models.getWebData;
using Microsoft.EntityFrameworkCore;


namespace banhang_online.Models.setDbContext
{
    public class cls_DBContext : DbContext
    {
        public cls_DBContext (DbContextOptions<cls_DBContext> options) : base(options){

        }
        
        public DbSet<DangNhap> DangNhap { get; set;}

        public DbSet<SanPham> SanPham { get; set;}

        public DbSet<DonHang> DonHang { get; set;}

        public DbSet<GioHang> GioHang { get; set;}

        public DbSet<KhoHang> KhoHang { get; set;}

        public DbSet<AnhSanPham> AnhSanPham { get; set;}

        public DbSet<ThongTinKhachHang> ThongTinKhachHang { get; set;}
        
        
    }
}