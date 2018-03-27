using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Globalization;

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
        public object get_sach1()
        {
            var sach = from u in data.ChiTietSaches

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
        public object addChiTietSach(string ms, string ts, string tg, string tl, string nxb, string nn, string lv, int namxb, string vitri)
        {
            ChiTietSach chitietsach = new ChiTietSach();
            //ViTriSach vt = data.ViTriSaches.Single(a => a.MaVT == vitri);
            chitietsach.MaSach = ms;
            chitietsach.TenSach = ts;
            chitietsach.TacGia = tg;
            chitietsach.TheLoai = tl;
            chitietsach.NXB = nxb;
            chitietsach.NgonNgu = nn;
            chitietsach.LinhVuc = lv;
            chitietsach.NamXB = namxb;
            chitietsach.MaVT = vitri;
            /*if(vt!= null)
            {
                chitietsach.MaVT = vitri;
            }*/
            data.ChiTietSaches.InsertOnSubmit(chitietsach);
            data.SubmitChanges();

            return 1;
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
                             TenSV = v.TenSV,
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

        //Lấy thông tin nhân viên
        public object get_infoPersonal()
        {
            var nv = from nvs in data.NhanViens
                     select nvs;
            return nv;
        }
        public object get_nhanvien()
        {
            var nv = from a in data.NhanViens
                     select new
                     {
                         MaNV = a.MaNV,
                         TenNV = a.TenNV,
                         GioiTinh = a.GioiTinh,
                         NgaySinh = a.NgaySinh,
                         DienThoai = a.DienThoai
                     }; ;
            return nv;
        }
        public object addNhanVien(string ma, string hoten, string gt, string ns, string sdt)
        {
            NhanVien nv = new NhanVien();
            nv.MaNV = ma;
            nv.TenNV = hoten;
            if (gt == "Nam")
            {
                nv.GioiTinh = false;
            }
            if (gt == "Nữ")
            {
                nv.GioiTinh = true;
            }
            nv.NgaySinh = DateTime.Parse(ns, new CultureInfo("en-US", true));
            nv.DienThoai = sdt;

            data.NhanViens.InsertOnSubmit(nv);
            data.SubmitChanges();
            return 1;
        }
        //Cập nhật thông tin nhân viên
        public int EditNhanVien(string ma,string hoten,bool gt, DateTime ns, string sdt)
        {
            var nv = data.NhanViens.Single(p => p.MaNV == ma);
            nv.TenNV = hoten;
            if(gt == true)
            {
                nv.GioiTinh = true;
            }
            else
            {
                nv.GioiTinh = false;
            }
            nv.NgaySinh = ns;
            nv.DienThoai = sdt;
            data.SubmitChanges();
            return 1;
        }
        //Xóa nhân viên
        public int DelNhanVien(string ma)
        {
            var nv = data.NhanViens.Single(p => p.MaNV == ma);

           var pm = (from p in data.PhieuMuonSaches where p.MaNV == ma select p);
            foreach(var p in pm)
            {
                p.MaNV = null;
            }
            data.NhanViens.DeleteOnSubmit(nv);
            data.SubmitChanges();
            return 1;
        }

        //Lấy thông tin chi tiết phiếu mượn
        public object get_CTThongTinPM()
        {
            var ctpm = from ctmps in data.ChiTietPhieuMuons
                       select new
                       {
                           ID_PM = ctmps.MaPM,
                           ID_MS = ctmps.MaSach,
                           Ngay_muon = ctmps.NgayMuon,
                           Han_Muon = ctmps.HanMuon,
                           Ngay_tra = ctmps.NgayTra,
                           Tien_Phat = ctmps.TienPhat
                       };

            return ctpm;
        }
        //Chỉnh sửa thông tin chi tiết phiếu mượn
        public int Update_TTPM(string mapm,string ngaymuon,string hanmuon,string ngaytra,string tienphat)
        {
            var CTPM = data.ChiTietPhieuMuons.Single(p => p.MaPM == mapm);
            CTPM.NgayMuon = Convert.ToDateTime(ngaymuon);
            CTPM.HanMuon = Convert.ToDateTime(hanmuon);
            CTPM.NgayTra = Convert.ToDateTime(ngaytra);
            CTPM.TienPhat = Convert.ToInt32(tienphat);
            data.SubmitChanges();
            return 1;
        }
        public int del_TTPM(string mapm)
        {
            var CTPM = data.ChiTietPhieuMuons.Single(p => p.MaPM == mapm);
            var PM = data.PhieuMuonSaches.Single(p => p.MaPM == mapm);
            data.PhieuMuonSaches.DeleteOnSubmit(PM);
            data.ChiTietPhieuMuons.DeleteOnSubmit(CTPM);
            data.SubmitChanges();
            return 1;
        }
        public object ThongKeSachTheoLinhVuc(string text)
        {
            var lv = from u in data.ChiTietSaches
                     from v in data.ViTriSaches
                     where u.LinhVuc == text
                     where u.MaVT == v.MaVT
                     select new
                     {
                         Ma = u.MaSach,
                         TenSach = u.TenSach,
                         TacGia = u.TacGia,
                         LinhVuc = u.LinhVuc,
                         ViTri = v.ViTri
                     };
            return lv;
        }
        public object ThongKeSachTheoTheLoai(string text)
        {
            var tl = from u in data.ChiTietSaches
                     from v in data.ViTriSaches
                     where u.TheLoai == text
                     where u.MaVT == v.MaVT
                     select new
                     {
                         Ma = u.MaSach,
                         TenSach = u.TenSach,
                         TacGia = u.TacGia,
                         TheLoai = u.TheLoai,
                         ViTri = v.ViTri
                     };
            return tl;
        }
        public object ThongKePhieuChuaTra()
        {
            var ngay = from a in data.ChiTietPhieuMuons
                       select Convert.ToString(a.NgayTra);
            var ph = from a in data.ChiTietPhieuMuons
                     from b in data.PhieuMuonSaches
                     from c in data.SinhViens
                     from d in data.ChiTietSaches
                     where a.MaPM == b.MaPM
                     where b.MaSV == c.MaSV
                     where a.MaSach == d.MaSach
                     where a.NgayTra == null
                     select new
                     {
                         TenSV = c.TenSV,
                         MaSach = a.MaSach,
                         TenSach = d.TenSach,
                         NgayMuon = a.NgayMuon,
                         HanMuon = a.HanMuon
                     };
            return ph;
        }
        public object ThongKePhieuDaTra()
        {
            var ph = from a in data.ChiTietPhieuMuons
                     from b in data.PhieuMuonSaches
                     from c in data.SinhViens
                     from d in data.ChiTietSaches
                     where a.MaPM == b.MaPM
                     where b.MaSV == c.MaSV
                     where a.MaSach == d.MaSach
                     where a.NgayTra != null
                     select new
                     {
                         TenSV = c.TenSV,
                         MaSach = a.MaSach,
                         TenSach = d.TenSach,
                         NgayMuon = a.NgayMuon,
                         NgayTra = a.NgayTra,
                         TienPhat = a.TienPhat
                     };
            return ph;
        }
        //lấy thông tin chi tiết sách
        public object get_ChiTietSach()
        {
            var cts = from p in data.ChiTietSaches
                      select new
                      {
                          MaSach = p.MaSach,
                          TenSach = p.TenSach,
                          TacGia = p.TacGia,
                          TheLoai = p.TheLoai,
                          NXB = p.NXB,
                          NgonNgu = p.NgonNgu,
                          LinhVuc = p.LinhVuc,
                          NamXB = p.NamXB,
                          MaVT = p.MaVT
                      };

            return cts;
        }
        //chỉnh sửa thông tin chi tiết sách
        public int Update_CTS(string masach, string tensach, string tacgia, string theloai, string nxb, string ngonngu, string linhvuc, string namxb, string mavt)
        {
            var CTS = data.ChiTietSaches.Single(p => p.MaSach == masach);
            data.SubmitChanges();
            return 1;
        }

        public int del_CTS(string masach, string mavt)
        {
            var CTS = data.ChiTietSaches.Single(p => p.MaSach == masach);
            var VTS = data.ViTriSaches.Single(p => p.MaVT == mavt);
            var CTPM = data.ChiTietPhieuMuons.Single(p => p.MaSach == masach);
            data.ChiTietSaches.DeleteOnSubmit(CTS);
            data.ViTriSaches.DeleteOnSubmit(VTS);
            data.ChiTietPhieuMuons.DeleteOnSubmit(CTPM);
            data.SubmitChanges();
            return 1;
        }

        public object get_SinhVien()
        {
            var sv = from a in data.SinhViens
                     select new
                     {
                         MaSV = a.MaSV,
                         TenSV = a.TenSV,
                         GioiTinh = a.GioiTinh,
                         NgaySinh = a.NgaySinh,
                         SoDT = a.SoDT
                     }; 
            return sv; 
        }
        public int EditSinhVien(string masv, string hoten, bool gioitinh, DateTime ngaysinh, string sodt)
        {
            var sv = data.SinhViens.Single(p => p.MaSV == masv);
            sv.TenSV = hoten;
            if (gioitinh == true)
            {
                sv.GioiTinh = true;
            }
            else
            {
                sv.GioiTinh = false;
            }
            sv.NgaySinh = ngaysinh;
            sv.SoDT = sodt;
            data.SubmitChanges();
            return 1;
        }
        public int DelSinhVien(string masv)
        {
            var sv = data.SinhViens.Single(p => p.MaSV == masv);

            var pm = (from p in data.PhieuMuonSaches where p.MaSV== masv select p);
            foreach (var p in pm)
            {
                p.MaSV = null;
            }
            data.SinhViens.DeleteOnSubmit(sv);
            data.SubmitChanges();
            return 1;
        }
    }
}
