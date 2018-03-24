using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BUS
{
    public class Bus
    {
        DataDiagramDataContext data = new DataDiagramDataContext();
        public object get_sach()
        {
            var sach = from u in data.ChiTietSaches
                       from v in data.ViTriSaches
                       where u.MaVT == v.MaVT
                       select new
                       {
                           MaSach = u.MaSach,
                           TenSach = u.TenSach,
                           TacGia = u.TacGia,
                           TheLoai = u.TheLoai,
                           NXB = u.NXB,
                           NgonNgu = u.NgonNgu,
                           LinhVuc = u.LinhVuc,
                           NamXB = u.NamXB,
                           ViTri = u.MaVT,
                           }; ;
            return sach;
        }
        public object get_sach(string giatri)
        {
            var sach = from u in data.ChiTietSaches
                       from t in data.ViTriSaches
                       where u.MaVT ==t.MaVT
                       select new
                           {
                               MaSach = u.MaSach,
                               TenSach = u.TenSach,
                               TacGia = u.TacGia,
                               TheLoai = u.TheLoai,
                               NXB = u.NXB,
                               NgonNgu = u.NgonNgu,
                               LinhVuc = u.LinhVuc,
                               NamXB = u.NamXB,
                               ViTri = u.MaVT,
                           } into timkiemSach
                           where timkiemSach.MaSach.Contains(giatri)
                           || timkiemSach.TenSach.Contains(giatri)
                           || timkiemSach.TacGia.Contains(giatri)
                           || timkiemSach.TheLoai.Contains(giatri)
                           || timkiemSach.NgonNgu.Contains(giatri)
                           || timkiemSach.NXB.Contains(giatri)
                           || timkiemSach.LinhVuc.Contains(giatri)
                       select timkiemSach;
            return sach;
        }
    }
}
