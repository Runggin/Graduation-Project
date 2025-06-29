Create database DKKlearning;

USE DKKlearning;

-- ================================
-- DATABASE: QUAN_LY_XEP_LICH_HOC
-- ================================

-- 1. Tài khoản (Admin, Giảng viên)
CREATE TABLE TaiKhoan (
    TenDangNhap VARCHAR(50) PRIMARY KEY,
    MatKhau VARCHAR(100) NOT NULL,
    VaiTro VARCHAR(20) NOT NULL CHECK (VaiTro IN ('Admin', 'GiangVien'))
);

-- 2. Admin
CREATE TABLE Admin (
    MaAdmin VARCHAR(20) PRIMARY KEY,
    HoTen NVARCHAR(100) NOT NULL,
    TenDangNhap VARCHAR(50) UNIQUE,
    FOREIGN KEY (TenDangNhap) REFERENCES TaiKhoan(TenDangNhap)
);

-- 3. Giảng viên
CREATE TABLE GiangVien (
    MaGV VARCHAR(20) PRIMARY KEY,
    HoTen NVARCHAR(100) NOT NULL,
    BoMon NVARCHAR(100),
    TenDangNhap VARCHAR(50) UNIQUE,
    FOREIGN KEY (TenDangNhap) REFERENCES TaiKhoan(TenDangNhap)
);

-- 4. Chuyên đề (môn học / học phần)
CREATE TABLE ChuyenDe (
    MaCD VARCHAR(20) PRIMARY KEY,
    TenCD NVARCHAR(100),
    ThoiLuong INT
);

-- 5. Khóa học (đợt mở cụ thể của 1 chuyên đề)
CREATE TABLE KhoaHoc (
    MaKH VARCHAR(20) PRIMARY KEY,
    MaCD VARCHAR(20) NOT NULL,
    NgayKhaiGiang DATE,
    GhiChu NVARCHAR(255),
    TenDangNhapTao VARCHAR(50), -- Admin hoặc Giảng viên tạo
    NgayTao DATE,
    FOREIGN KEY (MaCD) REFERENCES ChuyenDe(MaCD),
    FOREIGN KEY (TenDangNhapTao) REFERENCES TaiKhoan(TenDangNhap)
);

-- 6. Phòng học
CREATE TABLE PhongHoc (
    MaPhong VARCHAR(20) PRIMARY KEY,
    TenPhong NVARCHAR(100),
    SucChua INT,
    TrangThai NVARCHAR(20) -- 'ConTrong' / 'DaSuDung'
);

-- 7. Lịch học (xếp lịch dạy)
CREATE TABLE LichHoc (
    MaLich VARCHAR(20) PRIMARY KEY,
    MaKH VARCHAR(20),
    MaPhong VARCHAR(20),
    MaGV VARCHAR(20),
    ThoiGian DATETIME,
    GhiChu NVARCHAR(255),
    FOREIGN KEY (MaKH) REFERENCES KhoaHoc(MaKH),
    FOREIGN KEY (MaPhong) REFERENCES PhongHoc(MaPhong),
    FOREIGN KEY (MaGV) REFERENCES GiangVien(MaGV)
);

-- 8. Lớp học (phân lớp nếu cần)
CREATE TABLE LopHoc (
    MaLop VARCHAR(20) PRIMARY KEY,
    MaKH VARCHAR(20),
    MaCD VARCHAR(20),
    FOREIGN KEY (MaKH) REFERENCES KhoaHoc(MaKH),
    FOREIGN KEY (MaCD) REFERENCES ChuyenDe(MaCD)
);

CREATE TABLE KhoiPhucMatKhau (
    MaKhoiPhuc INT PRIMARY KEY IDENTITY(1,1),
    Email VARCHAR(100) NOT NULL,
    MatKhauMoi VARCHAR(100) NULL
);


INSERT INTO TaiKhoan (TenDangNhap, MatKhau, VaiTro)
VALUES 
('admin01', '123456', 'Admin'),
('gv01', '123456', 'GiangVien'),
('gv02', '123456', 'GiangVien');

INSERT INTO Admin (MaAdmin, HoTen, TenDangNhap)
VALUES 
('AD001', N'Phạm Anh Khoa', 'admin01');

INSERT INTO GiangVien (MaGV, HoTen, BoMon, TenDangNhap)
VALUES 
('GV001', N'Trần Thị Mai', N'Công nghệ phần mềm', 'gv01'),
('GV002', N'Lê Quốc Dũng', N'Mạng máy tính', 'gv02');


INSERT INTO ChuyenDe (MaCD, TenCD, ThoiLuong)
VALUES 
('CD001', N'Lập trình Java', 60),
('CD002', N'Quản trị mạng', 45);


INSERT INTO KhoaHoc (MaKH, MaCD, NgayKhaiGiang, GhiChu, TenDangNhapTao, NgayTao)
VALUES 
('KH001', 'CD001', '2025-07-15', N'Khóa học cơ bản Java', 'admin01', '2025-06-29'),
('KH002', 'CD002', '2025-07-20', N'Khóa học nâng cao mạng', 'admin01', '2025-06-29');


INSERT INTO PhongHoc (MaPhong, TenPhong, SucChua, TrangThai)
VALUES 
('P101', N'Phòng Lab 1', 40, N'ConTrong'),
('P102', N'Phòng Lab 2', 35, N'ConTrong');


INSERT INTO LopHoc (MaLop, MaKH, MaCD)
VALUES 
('LH001', 'KH001', 'CD001'),
('LH002', 'KH002', 'CD002');


INSERT INTO LichHoc (MaLich, MaKH, MaPhong, MaGV, ThoiGian, GhiChu)
VALUES 
-- Buổi 1 cho cả 2 môn
('JAVA001', 'KH001', 'P101', 'GV001', '2025-07-16 08:00:00', N'Buổi 1 - Java'),
('MANG001', 'KH002', 'P102', 'GV002', '2025-07-16 08:00:00', N'Buổi 1 - Mạng máy tính'),

-- Buổi 2 cho cả 2 môn
('JAVA002', 'KH001', 'P101', 'GV001', '2025-07-18 13:00:00', N'Buổi 2 - Java'),
('MANG002', 'KH002', 'P102', 'GV002', '2025-07-18 13:00:00', N'Buổi 2 - Mạng máy tính');



