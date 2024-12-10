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
Create Table DichVu
(
	MaDV varchar(10) constraint DichVu_PK Primary Key,
	TenDV nvarchar(20) Not Null,
	MaSach varchar(10) constraint DV_MaSach_FK Foreign Key(MaSach) References Sach(MaSach),
	GiaTien float Not Null,
)
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

Create Table GioHang 
(
    MaKH varchar(10) NOT NULL,
    MaSach varchar(10) NOT NULL,
    SoLuong int NOT NULL,
    MaDV varchar(10) NOT NULL,
    PRIMARY KEY (MaKH, MaSach, MaDV),
    CONSTRAINT GH_MaKH_FK FOREIGN KEY (MaKH) REFERENCES KhachHang(MaKH),
    CONSTRAINT GH_MaSach_FK FOREIGN KEY (MaSach) REFERENCES Sach(MaSach),
    CONSTRAINT GH_MaDV_FK FOREIGN KEY (MaDV) REFERENCES DichVu(MaDV)
)
Drop Table GioHang

Create Table HoaDon
(
    MaHD int identity(1,1) Primary Key,
    MaKH VARCHAR(10) NOT NULL,
    MaSach VARCHAR(10) NOT NULL,
    MaDV VARCHAR(10) NOT NULL,
    SoLuong INT NOT NULL,
    ThanhTien FLOAT NOT NULL,
    NgayMua DATETIME DEFAULT GETDATE(),
    CONSTRAINT HD_MaKH_FK FOREIGN KEY (MaKH) REFERENCES KhachHang(MaKH),
    CONSTRAINT HD_MaSach_FK FOREIGN KEY (MaSach) REFERENCES Sach(MaSach),
    CONSTRAINT HD_MaDV_FK FOREIGN KEY (MaDV) REFERENCES DichVu(MaDV)
);

CREATE TABLE NhanVien
(
    MaNV VARCHAR(10) PRIMARY KEY,
    TenNV NVARCHAR(100) NOT NULL,
    NgSinh DATETIME NOT NULL,
    Phai NVARCHAR(10) NOT NULL,
    DiaChi NVARCHAR(100) NOT NULL,
    SDT NVARCHAR(10) UNIQUE NOT NULL,
    Email NVARCHAR(100) UNIQUE NOT NULL,
);

-- Chèn dữ liệu mẫu
Select *From NhanVien
INSERT INTO NhanVien (MaNV, TenNV, NgSinh, Phai, DiaChi, SDT, Email)
VALUES
('NV.001', N'Trần Văn A', '1990-01-15', N'Nam', N'TP HCM', '0901234567', 'vana@gmail.com'),
('NV.002', N'Lê Thị B', '1995-03-20', N'Nữ', N'TP HCM', '0912234567', 'thib@gmail.com'),
('NV.003', N'Nguyễn Văn C', '1992-07-10', N'Nam', N'TP HCM', '0921234567', 'vanc@gmail.com');

ALTER TABLE Sach
ADD MaNV VARCHAR(10) NOT NULL, -- Nhân viên thêm sách
CONSTRAINT Sach_MaNV_FK FOREIGN KEY (MaNV) REFERENCES NhanVien(MaNV);

ALTER TABLE HoaDon
ADD MaNV VARCHAR(10) NOT NULL, -- Nhân viên kiểm tra hóa đơn
CONSTRAINT HD_MaNV_FK FOREIGN KEY (MaNV) REFERENCES NhanVien(MaNV);

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
('KH.001', N'Anh Kiệt', '2005-10-09', N'Nam', N'TP HCM', N'anhkiet@gmail.com', '0912311313'),
('KH.002', N'Thanh Tiền', '2005-04-15', N'Nam', N'TP HCM', N'thanhtien@gmail.com', '0921231453'),
('KH.003', N'Thanh Phú', '2005-08-12', N'Nam', N'TP HCM', N'thanhphu@gmail.com', '023451456')

Delete From GioHang
Select *From GioHang
INSERT INTO GioHang (MaKH, MaSach, SoLuong, MaDV) VALUES
('KH.001', 'S.001', 2, 'DV.001'),
('KH.001', 'S.001', 3, 'DV.002')


Delete From HoaDon
Select *From HoaDon
INSERT INTO HoaDon (MaKH, MaSach, MaDV, SoLuong, ThanhTien, MaNV)
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

