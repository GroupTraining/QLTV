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
        
        public object get_ngmuon()
        {
            var ngmuon = from u in data.ChiTietPhieuMuons
                         from z in data.PhieuMuonSaches
                         from v in data.SinhViens
                         from t in data.ChiTietSaches
                         where u.MaPM == z.MaPM
                         where z.MaSV == v.MaSV
                         where u.MaSach == t.MaSach
                         select new
                         {
                             MaSV = v.MaSV,
                             SoDT = v.SoDT,
                             Lop = v.Lop,
                             TenSach = t.TenSach,
                             NgayMuon = u.NgayMuon,
                             HanMuon = u.HanMuon,
                             NgayTra = u.NgayTra,
                             TienPhat = u.TienPhat,
                         }; ;
            return ngmuon;
        }
        public object get_ngmuon(string giatri)
        {
            var ngmuon = from u in data.ChiTietPhieuMuons
                         from z in data.PhieuMuonSaches
                         from v in data.SinhViens
                         from t in data.ChiTietSaches
                         where u.MaPM == z.MaPM
                         where z.MaSV == v.MaSV
                         where u.MaSach == t.MaSach
                         select new
                         {
                             MaSV = v.MaSV,
                             TenSV = v.TenSV,
                             SoDT = v.SoDT,
                             Lop = v.Lop,
                             TenSach = t.TenSach,
                             NgayMuon = u.NgayMuon,
                             HanMuon = u.HanMuon,
                             NgayTra = u.NgayTra,
                             TienPhat = u.TienPhat,
                         } into timkiemNguoimuon
                       where timkiemNguoimuon.MaSV.Contains(giatri)
                       || timkiemNguoimuon.TenSV.Contains(giatri)
                       || timkiemNguoimuon.SoDT.Contains(giatri)
                       select timkiemNguoimuon;
            return ngmuon;
        }
    }
}
