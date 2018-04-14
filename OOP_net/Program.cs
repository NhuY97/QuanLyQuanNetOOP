using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_net
{
    class Program
    {
        static List<LoaiKH> dsLoaiKhach = new List<LoaiKH>();
        static List<KhachHang> dsKhachHang = new List<KhachHang>();
        static List<LoaiMT> dsLoaiMay = new List<LoaiMT>();
        static List<MayTinh> dsMayTinh = new List<MayTinh>();
        static List<LoaiPhong> dsLoaiPhong = new List<LoaiPhong>();
        static List<Phong> dsPhong = new List<Phong>();
        static List<LoaiDichVu> dsLoaiDichVu = new List<LoaiDichVu>();
        static List<DichVu> dsDichVu = new List<DichVu>();
        static List<HoaDon> dsHoaDon = new List<HoaDon>();
        static List<NhanVien> dsNhanVien = new List<NhanVien>();
        static List<ChiTietSuDungDV> dsChiTietSDDV = new List<ChiTietSuDungDV>();
        static List<TrucPhong> dsTrucPhong = new List<TrucPhong>();
        public  static void TaoDanhSachLoaiKhach()
        {
            dsLoaiKhach.Add(new LoaiKH("LKH1", "Vip"));
            dsLoaiKhach.Add(new LoaiKH("LKH2", "Nomal"));
            dsLoaiKhach.Add(new LoaiKH("LKH3", "Transient"));// khach vang lai
        }
        public static void TaoDanhSachKhachHang()
        {
            dsKhachHang.Add(new KhachHang("KH1", "Anh ", "Thu Duc", "01233423453", "nam", dsLoaiKhach[0]));
            dsKhachHang.Add(new KhachHang("KH2", "Binh", "Quan 9", "0946655456", "nu", dsLoaiKhach[1]));
            dsKhachHang.Add(new KhachHang("KH3", "Cuc", "Quan 1", "0867454289", "nu", dsLoaiKhach[0]));
            dsKhachHang.Add(new KhachHang("KH4", "Dung ", "Thu Duc", "01205559232", "nam", dsLoaiKhach[0]));
            dsKhachHang.Add(new KhachHang("KH5", "Bao", "Thu Duc", "01662333345", "nam", dsLoaiKhach[1]));
            dsKhachHang.Add(new KhachHang("KH6", "An", "Quan 1", "01227886678", "nu", dsLoaiKhach[1]));
            dsKhachHang.Add(new KhachHang("KH7", "Giang", "Quan 9", "01659698901", "nu", dsLoaiKhach[1]));
            dsKhachHang.Add(new KhachHang("KH8", "Hung", "Thu Duc", "0945342234", "nam", dsLoaiKhach[0]));
            dsKhachHang.Add(new KhachHang("KH9", "Khang", "Quan 1", "0989234567", "nam", dsLoaiKhach[2]));
            dsKhachHang.Add(new KhachHang("KH10", "Lan", "Quan 9", "01667233890", "nu", dsLoaiKhach[2]));
        }
        public static void TaoDanhSachLoaiMayTinh()
        {
            dsLoaiMay.Add(new LoaiMT("LMT1", "ASUS"));
            dsLoaiMay.Add(new LoaiMT("LMT2", "HP"));
            dsLoaiMay.Add(new LoaiMT("LMT3", "DELL"));
            dsLoaiMay.Add(new LoaiMT("LMT4", "APPLE"));
        }
        public static void TaoDanhSachMayTinh()
        {
             dsMayTinh.Add(new MayTinh("MT1", dsLoaiMay[0], dsPhong[0]));
             dsMayTinh.Add(new MayTinh("MT2", dsLoaiMay[0], dsPhong[0]));
             dsMayTinh.Add(new MayTinh("MT3", dsLoaiMay[0], dsPhong[0]));
             dsMayTinh.Add(new MayTinh("MT4", dsLoaiMay[1], dsPhong[0]));
             dsMayTinh.Add(new MayTinh("MT5", dsLoaiMay[0], dsPhong[0]));
             dsMayTinh.Add(new MayTinh("MT6", dsLoaiMay[1], dsPhong[1]));
             dsMayTinh.Add(new MayTinh("MT7", dsLoaiMay[1], dsPhong[1]));
             dsMayTinh.Add(new MayTinh("MT8", dsLoaiMay[1], dsPhong[1]));
             dsMayTinh.Add(new MayTinh("MT9", dsLoaiMay[1], dsPhong[1]));
             dsMayTinh.Add(new MayTinh("MT10", dsLoaiMay[1], dsPhong[1]));
             dsMayTinh.Add(new MayTinh("MT11", dsLoaiMay[2], dsPhong[2]));
             dsMayTinh.Add(new MayTinh("MT12", dsLoaiMay[2], dsPhong[2]));
             dsMayTinh.Add(new MayTinh("MT13", dsLoaiMay[2], dsPhong[2]));
             dsMayTinh.Add(new MayTinh("MT14", dsLoaiMay[2], dsPhong[2]));
             dsMayTinh.Add(new MayTinh("MT15", dsLoaiMay[2], dsPhong[2]));
             dsMayTinh.Add(new MayTinh("MT16", dsLoaiMay[3], dsPhong[3]));
             dsMayTinh.Add(new MayTinh("MT17", dsLoaiMay[3], dsPhong[3]));
             dsMayTinh.Add(new MayTinh("MT18", dsLoaiMay[3], dsPhong[3]));
             dsMayTinh.Add(new MayTinh("MT19", dsLoaiMay[3], dsPhong[3]));
             dsMayTinh.Add(new MayTinh("MT20", dsLoaiMay[3], dsPhong[3]));

        }
        public static void TaoDanhSachLoaiPhong()
        {
            dsLoaiPhong.Add(new LoaiPhong("LP1", "phong 4 k"));
            dsLoaiPhong.Add(new LoaiPhong("LP2", "phong 6 k"));
            dsLoaiPhong.Add(new LoaiPhong("LP3", "phong 8 k"));
            dsLoaiPhong.Add(new LoaiPhong("LP4", "phong 10k"));
         }
         public static void TaoDanhSachPhong()
        {
            dsPhong.Add(new Phong("P1",dsLoaiPhong[0]));
            dsPhong.Add(new Phong("P2", dsLoaiPhong[1]));
            dsPhong.Add(new Phong("P3", dsLoaiPhong[2]));
            dsPhong.Add(new Phong("P4", dsLoaiPhong[3]));
        }
        public static void TaoDanhSachLoaiDichVu()
         {
             dsLoaiDichVu.Add(new LoaiDichVu("LDV1", "THUC AN"));
             dsLoaiDichVu.Add(new LoaiDichVu("LDV2", "NUOC UONG"));
             dsLoaiDichVu.Add(new LoaiDichVu("LDV3", "THUOC LA"));
         }
          public static void TaoDanhSachDichVu()
        {
            dsDichVu.Add(new DichVu("DV1", dsLoaiDichVu[0], "com ga"));
            dsDichVu.Add(new DichVu("DV2", dsLoaiDichVu[0], "my trung"));
            dsDichVu.Add(new DichVu("DV3", dsLoaiDichVu[0], "my y"));
            dsDichVu.Add(new DichVu("DV4", dsLoaiDichVu[0], "banh my"));
            dsDichVu.Add(new DichVu("DV5", dsLoaiDichVu[1], "coca"));
            dsDichVu.Add(new DichVu("DV6", dsLoaiDichVu[1], "persi"));
            dsDichVu.Add(new DichVu("DV7", dsLoaiDichVu[1], "biaTiger"));
            dsDichVu.Add(new DichVu("DV8", dsLoaiDichVu[1], "sting"));
            dsDichVu.Add(new DichVu("DV9", dsLoaiDichVu[2], "CHAMPION"));
            dsDichVu.Add(new DichVu("DV10", dsLoaiDichVu[2], "JET"));
            dsDichVu.Add(new DichVu("DV11", dsLoaiDichVu[2], "555"));
        }
        public static void TaoDanhSachNhanVien()
         {
             dsNhanVien.Add(new NhanVien("NV1","Nguyen Chi Trung","Quang Nam","nam","01665293553"));
             dsNhanVien.Add(new NhanVien("NV2", "Vo Ngoc Vinh Anh", "TP.HCM", "nam", "0942889914"));
             dsNhanVien.Add(new NhanVien("NV3", "Trinh Thi Ngoc Yen", "Quang Ninh", "nu", "01226783404"));
             dsNhanVien.Add(new NhanVien("NV4", "Thuy Thi Ngoc Huyen", "Kien Giang", "nu", "01652559609"));
          }
        public static void TaoDanhSachTrucPhong()
        {
            dsTrucPhong.Add(new TrucPhong(dsNhanVien[0], dsPhong[0], "thu 2-4-6"));
            dsTrucPhong.Add(new TrucPhong(dsNhanVien[1], dsPhong[0], "thu 3-5-7"));
            dsTrucPhong.Add(new TrucPhong(dsNhanVien[2], dsPhong[0], "chu nhat"));
            dsTrucPhong.Add(new TrucPhong(dsNhanVien[3], dsPhong[1], "thu 2-4-6"));
            dsTrucPhong.Add(new TrucPhong(dsNhanVien[0], dsPhong[1], "thu 3-5-7"));
            dsTrucPhong.Add(new TrucPhong(dsNhanVien[0], dsPhong[1], "chu nhat"));
            dsTrucPhong.Add(new TrucPhong(dsNhanVien[2], dsPhong[2], "thu 2-4-6"));
            dsTrucPhong.Add(new TrucPhong(dsNhanVien[2], dsPhong[2], "thu 3-5-7"));
            dsTrucPhong.Add(new TrucPhong(dsNhanVien[3], dsPhong[2], "chu nhat"));
            dsTrucPhong.Add(new TrucPhong(dsNhanVien[1], dsPhong[3], "thu 2-4-6"));
            dsTrucPhong.Add(new TrucPhong(dsNhanVien[3], dsPhong[3], "thu 3-5-7"));
            dsTrucPhong.Add(new TrucPhong(dsNhanVien[1], dsPhong[3], "chu nhat"));
        }
        public static void TaoDanhSachHoaDon()
        {
            dsHoaDon.Add(new HoaDon("HD1",dsKhachHang[0],dsNhanVien[0],dsMayTinh[11], 16000, 76000));
            dsHoaDon.Add(new HoaDon("HD2", dsKhachHang[1], dsNhanVien[1], dsMayTinh[8], 6000, 56000));
            dsHoaDon.Add(new HoaDon("HD3", dsKhachHang[2], dsNhanVien[2], dsMayTinh[4], 16000, 36000));
            dsHoaDon.Add(new HoaDon("HD4", dsKhachHang[3], dsNhanVien[3], dsMayTinh[16], 10000, 19000));
            dsHoaDon.Add(new HoaDon("HD5", dsKhachHang[4], dsNhanVien[3], dsMayTinh[0], 4000, 24000));
            dsHoaDon.Add(new HoaDon("HD6", dsKhachHang[5], dsNhanVien[2], dsMayTinh[3], 16000, 36000));
            dsHoaDon.Add(new HoaDon("HD7", dsKhachHang[6], dsNhanVien[1], dsMayTinh[6], 6000, 46000));
            dsHoaDon.Add(new HoaDon("HD8", dsKhachHang[7], dsNhanVien[2], dsMayTinh[1], 8000, 28000));
            dsHoaDon.Add(new HoaDon("HD9", dsKhachHang[8], dsNhanVien[3], dsMayTinh[1], 16000, 36000));
            dsHoaDon.Add(new HoaDon("HD10", dsKhachHang[9], dsNhanVien[2], dsMayTinh[7], 6000, 15000));
            dsHoaDon.Add(new HoaDon("HD11", dsKhachHang[3], dsNhanVien[0], dsMayTinh[2], 20000, 50000));
            dsHoaDon.Add(new HoaDon("HD12", dsKhachHang[1], dsNhanVien[3], dsMayTinh[13], 8000, 48000));
            dsHoaDon.Add(new HoaDon("HD13", dsKhachHang[7], dsNhanVien[1], dsMayTinh[5], 18000, 36000));
            dsHoaDon.Add(new HoaDon("HD14", dsKhachHang[6], dsNhanVien[2], dsMayTinh[1], 16000, 26000));
            dsHoaDon.Add(new HoaDon("HD15", dsKhachHang[0], dsNhanVien[1], dsMayTinh[18], 10000, 60000));
            dsHoaDon.Add(new HoaDon("HD16", dsKhachHang[9], dsNhanVien[0], dsMayTinh[10], 8000, 28000));
        }
        public static void TaoDanhSachChiTietSDDV()
        {
            dsChiTietSDDV.Add(new ChiTietSuDungDV(dsHoaDon[0],dsDichVu[10],2, 60000));
            dsChiTietSDDV.Add(new ChiTietSuDungDV(dsHoaDon[1], dsDichVu[9], 1, 50000));
            dsChiTietSDDV.Add(new ChiTietSuDungDV(dsHoaDon[2], dsDichVu[8], 1, 20000));
            dsChiTietSDDV.Add(new ChiTietSuDungDV(dsHoaDon[3], dsDichVu[7], 1, 9000));
            dsChiTietSDDV.Add(new ChiTietSuDungDV(dsHoaDon[4], dsDichVu[6], 2, 20000));
            dsChiTietSDDV.Add(new ChiTietSuDungDV(dsHoaDon[5], dsDichVu[5], 1, 20000));
            dsChiTietSDDV.Add(new ChiTietSuDungDV(dsHoaDon[6], dsDichVu[4], 2, 40000));
            dsChiTietSDDV.Add(new ChiTietSuDungDV(dsHoaDon[7], dsDichVu[3], 2, 20000));
            dsChiTietSDDV.Add(new ChiTietSuDungDV(dsHoaDon[8], dsDichVu[2], 2, 20000));
            dsChiTietSDDV.Add(new ChiTietSuDungDV(dsHoaDon[9], dsDichVu[7], 1, 9000));
            dsChiTietSDDV.Add(new ChiTietSuDungDV(dsHoaDon[10], dsDichVu[0], 2, 30000));
            dsChiTietSDDV.Add(new ChiTietSuDungDV(dsHoaDon[11], dsDichVu[8], 2, 40000));
            dsChiTietSDDV.Add(new ChiTietSuDungDV(dsHoaDon[12], dsDichVu[7], 2, 18000));
            dsChiTietSDDV.Add(new ChiTietSuDungDV(dsHoaDon[13], dsDichVu[3], 1, 10000));
            dsChiTietSDDV.Add(new ChiTietSuDungDV(dsHoaDon[14], dsDichVu[9], 1, 50000));
            dsChiTietSDDV.Add(new ChiTietSuDungDV(dsHoaDon[15], dsDichVu[4], 1, 20000));
        }
        public static void Cau1 ()
        {
            Console.WriteLine("------------Cau 1-----------");
            var dsnhomdichvu =
                from dv in dsDichVu
                join ldv in dsLoaiDichVu
                on dv.loaidichvu.maLoaiDV equals ldv.maLoaiDV
                select new
                {
                    dv.tendichvu,
                    dv.maDichVu,
                    ldv.LoaiDV
                };
            var NhomDV = from ndv in dsnhomdichvu
                         group ndv by ndv.LoaiDV into g
                         select new
                         {
                             nhomdv = g.Key,
                             dv = g
                         };
            Console.WriteLine(" Danh sach cac dich vu theo loai dich vu cua quan: ");
            foreach (var ldv in NhomDV)
            {
                Console.WriteLine("Nhom Dich Vu {0}:", ldv.nhomdv);
                int a = 1;
                foreach (var dv in ldv.dv)
                {
                    Console.WriteLine("  {0}.\t{1}     \t{2}             \t{3}", a, dv.maDichVu, dv.tendichvu, dv.LoaiDV);
                    a++;
                }
                Console.WriteLine("Tong So Dich Vu :{0}", ldv.dv.Count());
                Console.WriteLine();
            }
        }
         public static void Cau2 ()
        {
            Console.WriteLine("------------Cau 2-----------");
            var dskhachhang =
                from kh in dsKhachHang
                where kh.LKH.LoaiKh=="Vip"
                select new
                {
                    kh.maKH,
                    kh.tenKH,
                    kh.sdtKH,
                    kh.diaChi,
                    kh.gioiTinh
                };
            Console.WriteLine(" Danh sach cac khach hang thuoc loai Vip:");
            Console.WriteLine("\nMaKH  \tTenKH  \tDiaChi  \tSEX       \tSDT");
            Console.WriteLine();
            foreach (var p in dskhachhang)
            {
                Console.WriteLine("\n{0}\t{1} \t{2}        \t{3}         \t{4}", p.maKH, p.tenKH, p.diaChi, p.gioiTinh, p.sdtKH);
            }
         }
         public static void Cau3()
         {
             Console.WriteLine("------------Cau 3-----------");
             var dsKhachVip =
                 from vip in dsKhachHang
                 group vip by vip.LKH into k
                 select new
                 {
                     m = k.Key, n = k.Count()
                 };
             foreach (var vip in dsKhachVip)
             {
                 Console.Write("Loai khach {0}, ", vip.m.LoaiKh);
                 Console.WriteLine("\nSo luong khach thuoc loai {0} la {1}.", vip.m.LoaiKh, vip.n);
             }
         }
         public static void Cau4()
         {
             Console.WriteLine("------------Cau 4-----------");
             var dstinhtien =
                 from hd in dsChiTietSDDV
                 group hd by hd.dichvu.tendichvu into g
                 select new
                 {
                     tendv = g.Key,
                     Tongtiensddv = g.Sum(hd => hd.PhiSDDV),
                     sohd = g.Count()
                 };
             int a = 1;
             Console.WriteLine(" Tinh tien thu duoc cua tung dich vu:");
             foreach (var hd in dstinhtien)
             {
                 Console.WriteLine("  {3}.Loai {0} thu duoc {1} dong co {2} hoa don", hd.tendv, hd.Tongtiensddv, hd.sohd, a);
                 a++;
             }
         }
         public static void Cau5()
         {
             Console.WriteLine("------------Cau 5-----------");
             var dshd =
                 from hd in dsHoaDon
                 group hd by hd.NV.tenNV into g
                 select new
                 {
                     tennv = g.Key,
                     tien = g.Average(hd => hd.thanhTien)    
                 };
             int a = 1;
             Console.WriteLine(" Tinh tien trung binh thu duoc cua tung nhan vien:");
             foreach (var hd in dshd)
             {
                 Console.WriteLine("  {2}.Nhan vien {0} trung binh thu ngan duoc {1} dong cho quan", hd.tennv, hd.tien, a);
                 a++;
             }
         }
         public static void Cau6()
         {
             Console.WriteLine("------------Cau 6-----------");
             string chucai;
             string chucai1;
             Console.WriteLine(" Nhap chu cai dau tien cua khach hang can tim: ");
             chucai = Console.ReadLine();
             chucai1=chucai.Trim().ToUpper();
             var dschucai =
                 from c in dsKhachHang
                 where c.tenKH.StartsWith(chucai1)
                 select new
                 {
                     c.maKH,
                     c.tenKH,
                     c.sdtKH,
                     c.gioiTinh,
                     c.diaChi
                 };
             Console.WriteLine("Ten nhung khach hang bat dau bang chu {0} :", chucai);
             Console.WriteLine("\nMaKH  \tTenKH  \tDiaChi  \tSEX       \tSDT");
             Console.WriteLine();
             foreach (var p in dschucai)
             {
                 Console.WriteLine("\n{0}\t{1} \t{2}        \t{3}         \t{4}", p.maKH, p.tenKH, p.diaChi, p.gioiTinh, p.sdtKH);
             }
         }
         public static void Cau7()
         {
             Console.WriteLine("------------Cau 7-----------");
             var dshoadonlonnhat =
                 from hd in dsHoaDon
                 from kh in dsKhachHang
                 where hd.KH.maKH == kh.maKH && hd.thanhTien == dsHoaDon.Min(k => k.thanhTien)
                 select new
                 {
                     hd.thanhTien,
                     kh.tenKH,
                     kh.diaChi,
                     hd.maHoaDon
                 };
             Console.WriteLine("Ten khach hang co hoa don nho nhat :");
             Console.WriteLine("\nMaHD  \tTenKH  \tDiaChi  \tTongTien(dong)");
             Console.WriteLine();
             foreach (var m in dshoadonlonnhat)
             {
                 Console.WriteLine("\n{0}\t{1} \t{2}        \t{3}", m.maHoaDon, m.tenKH, m.diaChi, m.thanhTien);
             }
         }
         public static void Cau8()
         {
             Console.WriteLine("------------Cau 8-----------");
             var dsdienthoai =
                 from b in dsKhachHang
                 where (b.sdtKH.StartsWith("016") || b.sdtKH.StartsWith("098") || b.sdtKH.StartsWith("096")
                 || b.sdtKH.StartsWith("097") ||  b.sdtKH.StartsWith("086"))
                 select new
                 {
                     b.maKH,
                     b.tenKH,
                     b.sdtKH,
                     b.gioiTinh,
                     b.diaChi
                 };
             Console.WriteLine("Ten nhung khach hang dung mang Viettel: ");
             Console.WriteLine("\nMaKH  \tTenKH  \tDiaChi  \tSEX       \tSDT");
             Console.WriteLine();
             foreach (var p in dsdienthoai)
             {

                 Console.WriteLine("\n{0}\t{1} \t{2}        \t{3}         \t{4}", p.maKH, p.tenKH, p.diaChi, p.gioiTinh, p.sdtKH);
             }
         }
         public static void Cau9()
         {
             Console.WriteLine("------------Cau 9-----------");
             var sapxephd =
                 from hd in dsHoaDon
                 orderby hd.thanhTien descending
                 select new
                 {
                     hd.maHoaDon,
                     g = hd.KH.tenKH,
                     h = hd.MT.loaimaytinh.Loaimt,
                     k = hd.NV.tenNV,
                      l = hd.MT.phong.lp.Loaiphong, 
                     hd.thanhTien
                 };
             Console.WriteLine("Sap xep hoa don theo thu tu giam dan cua thanh tien:");
             Console.WriteLine("\nMaHD \tTenKH  \tLoaiMT \tLoaiPhong         \tTenNV_in_HD             \tThanhtien");
             Console.WriteLine();
             foreach (var hd in sapxephd)
             {
                 Console.WriteLine("\n{0}\t{1} \t{2} \t{3}       \t{4}         \t{5}", hd.maHoaDon, hd.g, hd.h,hd.l, hd.k, hd.thanhTien);
             } 
         }
         public static void Cau10()
         {
             Console.WriteLine("------------Cau 10-----------");
             var dsphong1 =
                 from hd in dsHoaDon
                 where hd.MT.phong.maPhong == "P1"
                 select new
                 {
                     g = hd.KH.tenKH
                 };
             Console.WriteLine("Danh sach cac khach hang da tung su dung phong may so 1:");
             foreach(var hd in dsphong1)
             {
                  Console.WriteLine("{0}",hd.g);
             }
         }
         public static void Cau11()
         {
             Console.WriteLine("------------Cau 11-----------");
             var dsnhomtp =
                 from nv in dsNhanVien
                 from ltp in dsTrucPhong
                 where nv.tenNV==ltp.nhanvien.tenNV           
                 select new
                 {
                     nv.sdtNV,
                     nv.tenNV,
                     h = ltp.phong.maPhong,
                     g = ltp.phong.lp.Loaiphong,
                     k = ltp.thoidiem
                 };
             var NhomTP = from ltp in dsnhomtp
                          group ltp by ltp.k into g
                          select new
                          {
                              nhomthoidiem = g.Key,
                              nv = g
                          };
             Console.WriteLine(" Danh sach lich truc cua quan: ");
             foreach (var tp in NhomTP)
             {
                 Console.WriteLine("Thoi gian {0}:", tp.nhomthoidiem);
                 int a = 1;
                 Console.WriteLine("\n STT \tTen Nhan Vien     \tPhong Truc   \tLoai Phong \tSDT Lien He");
                 Console.WriteLine();
                 foreach (var nv in tp.nv )
                 {
                     Console.WriteLine("  {0}.\t{1}\t{2}      \t{3}\t{4}", a, nv.tenNV, nv.h,nv.g, nv.sdtNV);
                     a++;
                 }                
                 Console.WriteLine();
             }
         }
         public static void Cau12()
         {
             Console.WriteLine("------------Cau 12-----------");
             var a = 
                 from kh in dsKhachHang
                  join hd in dsHoaDon on kh.maKH equals hd.KH.maKH
                  join ctdv in dsChiTietSDDV on hd.maHoaDon equals ctdv.hoadon.maHoaDon
                 select new
                 {
                     kh.tenKH,
                     hd.maHoaDon,                 
                     ctdv.PhiSDDV,
                     l = ctdv.dichvu.tendichvu,
                     ctdv.soLuong
                 };
             var b = from n in a
                     group n by n.tenKH into g
                     select new { ten = g.Key, dv=g };
             Console.WriteLine("Liet Ke cac dich vu theo ten khach hang da su dung:");
             Console.WriteLine("--------------------DANH SACH---------------------");
             foreach (var p in b)
             {
                 Console.WriteLine("          Khach Hang: {0}", p.ten);
                 int stt = 1;
                 Console.WriteLine("\nSTT \tMaHD  \tTenDV          \tSoLuong \tPhiSDDV ");
                 foreach (var k in p.dv)
                 {               
                     Console.WriteLine();
                     Console.WriteLine("\n {0}.\t{1}   \t{2}       \t{3}         \t{4}", stt, k.maHoaDon, k.l,k.soLuong, k.PhiSDDV);
                     stt++;
                 }
                 Console.WriteLine("---------------------------------------------------------- ");
             }
         }
        
        static void Main(string[] args)
        {
            // Code by:
            // Nguyen Chi Trung                            15110346
            // Tran Nguyen Thanh Nhu Y                15110378
            TaoDanhSachLoaiKhach();
            TaoDanhSachKhachHang();
            TaoDanhSachLoaiPhong();
            TaoDanhSachPhong();
            TaoDanhSachLoaiMayTinh();
            TaoDanhSachMayTinh();
            TaoDanhSachLoaiDichVu();
            TaoDanhSachDichVu();
            TaoDanhSachNhanVien();
            TaoDanhSachTrucPhong();
            TaoDanhSachHoaDon();
            TaoDanhSachChiTietSDDV();       
                int chon;
            start: 
                Console.Clear();
                Console.WriteLine("--------------------MENU------------------- ");
                Console.WriteLine("1 - Ke ten cac dich vu theo tung loai dich vu cua quan. ");
                Console.WriteLine("2 - Tim danh sach cac khach hang thuoc loai Vip.");
                Console.WriteLine("3 - So luong khach hang thuoc cac loai khach hang.");
                Console.WriteLine("4 - Tinh tien thu duoc cua tung dich vu trong quan.");
                Console.WriteLine("5 - Tinh tien trung binh thu duoc cua tung nhan vien.");
                Console.WriteLine("6 - Tim ten nhung khach hang bat dau bang mot chu cai, vd nhu a.");
                Console.WriteLine("7 - Tim ten khach hang co hoa don nho nhat.");
                Console.WriteLine("8 - Tim ten nhung khach hang dung mang Viettel.");
                Console.WriteLine("9 - Sap xep hoa don theo thu tu giam dan cua thanh tien.");
                Console.WriteLine("10 - Tim danh sach cac khach hang da tung su dung may o phong may so 1.");
                Console.WriteLine("11 - Lich truc phong cua nhan vien trong quan.");
                Console.WriteLine("12 - Liet ke cac dich vu theo ten khach hang da su dung.");
                Console.WriteLine("13 - Thoat.");
                Console.WriteLine("--------------------START------------------ ");
           nhaplai:
                Console.WriteLine("Moi ban chon cau truy van: ");
                try
                {
                    chon = int.Parse(Console.ReadLine());              
                    switch(chon)
                    {
                        case 1:
                            {
                                Cau1();
                                Console.ReadKey();
                               goto start;
                            }
                        case 2:
                            {
                                Cau2();
                                Console.ReadKey();
                                goto start;
                            }
                        case 3:
                            {
                                Cau3();
                                Console.ReadKey();
                                goto start;
                            }
                        case 4:
                            {
                                Cau4();
                                Console.ReadKey();
                                goto start;
                            }
                        case 5:
                            {
                                Cau5();
                                Console.ReadKey();
                                goto start;
                            }
                        case 6:
                            {
                                Cau6();
                                Console.ReadKey();
                                goto start;
                            }
                        case 7:
                            {
                                Cau7();
                                Console.ReadKey();
                                goto start;
                            }
                        case 8:          
                            {
                                Cau8();
                                Console.ReadKey();
                                goto start;
                            }
                        case 9:
                            {
                                Cau9();
                                Console.ReadKey();
                                goto start;
                            }
                        case 10:
                            {
                                Cau10(); 
                                Console.ReadKey();
                                goto start;
                            }
                        case 11:
                            {
                                Cau11();
                                Console.ReadKey();
                                goto start;
                            }
                        case 12:
                            {
                                Cau12();
                                Console.ReadKey();
                                goto start;
                            }                
                        case 13:
                            return;
                        default:
                            {
                                Console.WriteLine("Xin nhap lai !!!");
                                goto nhaplai;
                            }
                    }
                }
                catch (System.FormatException)
                {
                    Console.WriteLine("Xin nhap lai !!!");
                    goto nhaplai;
                }
                catch
                {
                    Console.WriteLine("Unknown exception caught !!!");
                }         
        }
    }
}
