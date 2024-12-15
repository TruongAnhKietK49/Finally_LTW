Drop Database BookStore_Management
Create Database BookStore_Management
Use BookStore_Management

Create Table Sach
(
	MaSach varchar(10) constraint MaSach_PK Primary Key,
	TenSach nvarchar(50) Unique Not Null,
	TacGia nvarchar(100) Not Null,
	NXB datetime Not Null,
	TheLoai nvarchar(50) Not Null,
)
Drop Table Sach

Create Table DichVu
(
	MaDV varchar(10) constraint DichVu_PK Primary Key,
	TenDV nvarchar(20) Not Null,
	MaSach varchar(10) constraint DV_MaSach_FK Foreign Key(MaSach) References Sach(MaSach) On delete cascade,
	GiaTien float Not Null,
)
Drop Table DichVu

Create Table KhachHang
(
	MaKH varchar(10) constraint MaKH_PK Primary Key,
	TenKH nvarchar(100) Unique Not Null,
	NgSinh Datetime Not Null,
	Phai nvarchar(10) Not Null,
	DiaChi nvarchar(100) Not Null,
	Email nvarchar(100) Unique Not Null,
	SDT nvarchar(10) Unique Not Null
)
Drop Table KhachHang

Create Table GioHang 
(
    MaKH varchar(10) NOT NULL,
    MaSach varchar(10) NOT NULL,
    SoLuong int NOT NULL,
    MaDV varchar(10) NOT NULL,
    Primary Key (MaKH, MaSach, MaDV),
    Constraint GH_MaKH_FK Foreign Key (MaKH) References KhachHang(MaKH) On delete no action,
    Constraint GH_MaSach_FK Foreign Key (MaSach) References Sach(MaSach) On delete no action,
    Constraint GH_MaDV_FK Foreign Key (MaDV) References DichVu(MaDV) On delete no action
)
Drop Table GioHang

Create Table HoaDon
(
    MaHD int identity(1,1) Primary Key,
    MaKH varchar(10) NOT NULL,
    MaSach varchar(10) NOT NULL,
    MaDV varchar(10) NOT NULL,
    SoLuong int NOT NULL,
    ThanhTien float NOT NULL,
    NgayMua datetime default GETDATE(),
    Constraint HD_MaKH_FK Foreign Key (MaKH) References KhachHang(MaKH) On delete no action,
    Constraint HD_MaSach_FK Foreign Key (MaSach) References Sach(MaSach) On delete no action,
    Constraint HD_MaDV_FK Foreign Key (MaDV) References DichVu(MaDV) On delete no action
)
Drop Table HoaDon

Create Table NhanVien
(
    MaNV varchar(10) Primary Key,
    TenNV nvarchar(100) NOT NULL,
    NgSinh datetime NOT NULL,
    Phai nvarchar(10) NOT NULL,
    DiaChi nvarchar(100) NOT NULL,
    SDT nvarchar(10) Unique NOT NULL,
    Email nvarchar(100) Unique NOT NULL,
)
Drop Table NhanVien

-- Chèn dữ liệu mẫu
Select *From NhanVien
Insert Into NhanVien (MaNV, TenNV, NgSinh, Phai, DiaChi, SDT, Email) Values
('NV.001', N'Trương Anh Kiệt', '2005-09-10', N'Nam', N'TP HCM', '0123456789', 'kietta@gmail.com'),
('NV.002', N'Nguyễn Thanh Tiền', '2005-06-16', N'Nam', N'TP HCM', '0853355115', 'tiennt@gmail.com'),
('NV.003', N'Nguyễn Đỗ Thanh Phú', '2005-06-18', N'Nam', N'TP HCM', '0852852018', 'phundt@gmail.com'),
('NV.004', N'Ngô Ý Nhi', '2005-01-25', N'Nữ', N'TP HCM', '0865778945', 'nhiny@gmail.com')

Alter Table Sach Drop Constraint Sach_MaNV_FK;
Alter Table Sach
Add MaNV varchar(10) NOT NULL, -- Nhân viên thêm sách
Constraint Sach_MaNV_FK Foreign Key (MaNV) References NhanVien(MaNV) On delete cascade;

Alter Table HoaDon Drop Constraint HD_MaNV_FK;
Alter Table HoaDon
Add MaNV varchar(10) NOT NULL, -- Nhân viên kiểm tra hóa đơn
Constraint HD_MaNV_FK Foreign Key (MaNV) References NhanVien(MaNV) On delete cascade;

Delete From Sach
Select *From Sach
Insert Into Sach(MaSach, TenSach, TacGia, NXB, TheLoai, MaNV) Values
('S.001', N'Dế Mèn Phiêu Lưu Ký', N'Tô Hoài', '1941-01-20', N'Sử Thi', 'NV.001'),
('S.002', N'Chí Phèo', N'Nam Cao', '1955-10-24', N'Truyện Ngắn', 'NV.002'),
('S.003', N'Người Lái Đò Sông Đà', N'Nguyễn Tuân', '1960-08-15', N'Tùy Bút', 'NV.003')

Delete From DichVu
Select *From DichVu
Insert Into DichVu(MaDV, TenDV, MaSach, GiaTien) Values
('DV.001', N'Bán', 'S.001', 25000),
('DV.002', N'Thuê', 'S.001', 5000),
('DV.003', N'Bán', 'S.002', 35000),
('DV.004', N'Thuê', 'S.002', 10000),
('DV.005', N'Bán', 'S.003', 20000),
('DV.006', N'Thuê', 'S.003', 4000)

Delete From KhachHang
Select *From KhachHang
Insert Into KhachHang(MaKH, TenKH, NgSinh, Phai, DiaChi, Email, SDT) Values
('KH.001', N'Nguyễn Văn A', '2005-05-19', N'Nam', N'TP HCM', N'vana@gmail.com', '0999888777'),
('KH.002', N'Thanh Tiền', '2005-04-15', N'Nam', N'TP HCM', N'thanhtien@gmail.com', '0921231453'),
('KH.003', N'Thanh Phú', '2005-08-12', N'Nam', N'TP HCM', N'thanhphu@gmail.com', '023451456')

Delete From GioHang
Select *From GioHang
Insert Into GioHang (MaKH, MaSach, SoLuong, MaDV) Values
('KH.001', 'S.001', 2, 'DV.001'),
('KH.001', 'S.001', 3, 'DV.002')


Delete From HoaDon
Select *From HoaDon
Insert Into HoaDon (MaKH, MaSach, MaDV, SoLuong, ThanhTien, MaNV)
SELECT 
    GioHang.MaKH, 
    GioHang.MaSach, 
    GioHang.MaDV, 
    GioHang.SoLuong, 
    GioHang.SoLuong * DichVu.GiaTien AS ThanhTien,
    'NV.002' AS MaNV 
FROM 
    GioHang
JOIN 
    DichVu ON GioHang.MaDV = DichVu.MaDV
WHERE 
    GioHang.MaKH = 'KH.001';

SELECT HoaDon.MaHD, HoaDon.MaKH, KhachHang.TenKH, HoaDon.MaSach, Sach.TenSach, HoaDon.MaDV, DichVu.TenDV, 
       HoaDon.SoLuong, HoaDon.ThanhTien, HoaDon.NgayMua, NhanVien.TenNV AS NhanVienKiemTra
FROM HoaDon
JOIN KhachHang ON HoaDon.MaKH = KhachHang.MaKH
JOIN Sach ON HoaDon.MaSach = Sach.MaSach
JOIN DichVu ON HoaDon.MaDV = DichVu.MaDV
JOIN NhanVien ON HoaDon.MaNV = NhanVien.MaNV
WHERE HoaDon.MaNV = 'NV.002';

