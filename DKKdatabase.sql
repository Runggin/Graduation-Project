SELECT * FROM TaiKhoan;
SELECT * FROM Admin;
SELECT * FROM GiangVien;
SELECT * FROM ChuyenDe;
SELECT * FROM KhoaHoc;
SELECT * FROM PhongHoc;
SELECT * FROM LopHoc;
SELECT * FROM LichHoc;
SELECT * FROM KhoiPhucMatKhau;


-- Cập nhật tên lớp cho Java
UPDATE LopHoc
SET TenLop = 'SD1902'
WHERE MaLop = 'LH001';

-- Cập nhật tên lớp cho Mạng máy tính
UPDATE LopHoc
SET TenLop = 'SA1903'
WHERE MaLop = 'LH002';