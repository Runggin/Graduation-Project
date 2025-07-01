CREATE DATABASE [DKK_Education];

USE [DKK_Education];
GO

CREATE TABLE TaiKhoan (
    TenDN VARCHAR(50) PRIMARY KEY,
    MatKhau VARCHAR(100) NOT NULL,
    VaiTro VARCHAR(20) CHECK (VaiTro IN ('Admin', 'GiangVien', 'SinhVien'))
);

-- 2. Bảng GiangVien
CREATE TABLE GiangVien (
    MaGV VARCHAR(10) PRIMARY KEY,
    HoTen NVARCHAR(100) NOT NULL,
    BoMon NVARCHAR(100),
    TenDN VARCHAR(50),
    Email VARCHAR(100),
    FOREIGN KEY (TenDN) REFERENCES TaiKhoan(TenDN)
);

-- 3. Bảng PhongHoc
CREATE TABLE PhongHoc (
    MaPhong VARCHAR(10) PRIMARY KEY,
    TenPhong NVARCHAR(100),
    SucChua INT,
    TrangThai NVARCHAR(50)
);

-- 4. Bảng MonHoc
CREATE TABLE MonHoc (
    MaMH VARCHAR(10) PRIMARY KEY,
    NgayHoc DATE,
    GhiChu NVARCHAR(255),
    TenDangNhapGV VARCHAR(50),
    NgayTao DATE,
    FOREIGN KEY (TenDangNhapGV) REFERENCES TaiKhoan(TenDN)
);

-- 5. Bảng LopHoc (đã bỏ MaCD, đổi MaKH thành MaMH)
CREATE TABLE LopHoc (
    MaLop VARCHAR(10) PRIMARY KEY,
    TenLop NVARCHAR(100),
    MaMH VARCHAR(10), -- đổi từ MaKH
    FOREIGN KEY (MaMH) REFERENCES MonHoc(MaMH)
);

-- 6. Bảng SinhVien
CREATE TABLE SinhVien (
    MaSV VARCHAR(10) PRIMARY KEY,
    HoTen NVARCHAR(100),
    TenDN VARCHAR(50),
    LopHoc VARCHAR(10),
    Email VARCHAR(100),
    FOREIGN KEY (TenDN) REFERENCES TaiKhoan(TenDN),
    FOREIGN KEY (LopHoc) REFERENCES LopHoc(MaLop)
);

-- 7. Bảng LichHoc (đổi MaKH thành MaMH)
CREATE TABLE LichHoc (
    MaLich VARCHAR(10) PRIMARY KEY,
    MaMH VARCHAR(10),
    MaPhong VARCHAR(10),
    MaGV VARCHAR(10),
    ThoiGianHoc NVARCHAR(100),
    GhiChu NVARCHAR(255),
    FOREIGN KEY (MaMH) REFERENCES MonHoc(MaMH),
    FOREIGN KEY (MaPhong) REFERENCES PhongHoc(MaPhong),
    FOREIGN KEY (MaGV) REFERENCES GiangVien(MaGV)
);
GO

-- Tài khoản Admin
INSERT INTO TaiKhoan (TenDN, MatKhau, VaiTro)
VALUES ('khoa26', 'admin123', 'Admin');

-- Tài khoản Giảng viên
INSERT INTO TaiKhoan (TenDN, MatKhau, VaiTro)
VALUES 
    ('lehuukhang', '123456', 'GiangVien'),
    ('tranmylinh', '123456', 'GiangVien');

-- Tài khoản Sinh viên
INSERT INTO TaiKhoan (TenDN, MatKhau, VaiTro)
VALUES 
    ('ngominhquan', '123456', 'SinhVien');


    INSERT INTO GiangVien (MaGV, HoTen, BoMon, TenDN, Email)
VALUES 
    ('GV001', N'Lê Hữu Khang', N'Java', 'lehuukhang', 'khang.le@edu.vn'),
    ('GV002', N'Trần Mỹ Linh', N'Tiếng Anh', 'tranmylinh', 'linh.tran@edu.vn');

    INSERT INTO MonHoc (MaMH, NgayHoc, GhiChu, TenDangNhapGV, NgayTao)
VALUES 
    ('JV001', '2025-07-15', N'Môn lập trình Java cơ bản', 'lehuukhang', '2025-06-30'),
    ('ENG001', '2025-07-16', N'Môn tiếng Anh giao tiếp', 'tranmylinh', '2025-06-30');

    INSERT INTO LopHoc (MaLop, TenLop, MaMH)
VALUES 
    ('LJ01', N'Lớp Java 01', 'JV001'),
    ('LE01', N'Lớp English 01', 'ENG001');

    INSERT INTO SinhVien (MaSV, HoTen, TenDN, LopHoc, Email)
VALUES 
    ('SV001', N'Ngô Minh Quân', 'ngominhquan', 'LJ01', 'quan.ngo@student.edu.vn');

    INSERT INTO PhongHoc (MaPhong, TenPhong, SucChua, TrangThai)
VALUES 
    ('P101', N'Phòng 101', 40, N'Sẵn sàng'),
    ('P202', N'Phòng 202', 35, N'Sẵn sàng');

    -- Lịch cho lớp Java (do GV Lê Hữu Khang dạy)
INSERT INTO LichHoc (MaLich, MaMH, MaPhong, MaGV, ThoiGianHoc, GhiChu)
VALUES 
    ('LICH01', 'JV001', 'P101', 'GV001', N'Thứ 2 - Tiết 1-2', N'Giới thiệu Java cơ bản');

-- Lịch cho lớp Tiếng Anh (do GV Trần Mỹ Linh dạy)
INSERT INTO LichHoc (MaLich, MaMH, MaPhong, MaGV, ThoiGianHoc, GhiChu)
VALUES 
    ('LICH02', 'ENG001', 'P202', 'GV002', N'Thứ 4 - Tiết 3-4', N'Trò chuyện tiếng Anh cơ bản');
-- 1. Danh sách tài khoản
SELECT * FROM TaiKhoan;

-- 2. Danh sách giảng viên
SELECT * FROM GiangVien;

-- 3. Danh sách phòng học
SELECT * FROM PhongHoc;

-- 4. Danh sách môn học
SELECT * FROM MonHoc;

-- 5. Danh sách lớp học
SELECT * FROM LopHoc;

-- 6. Danh sách sinh viên
SELECT * FROM SinhVien;

-- 7. Danh sách lịch học
SELECT * FROM LichHoc;



