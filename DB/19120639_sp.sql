USE QLTC;

drop procedure if exists `sp_XemLichLamViec`;
DELIMITER $$
CREATE PROCEDURE `sp_XemLichLamViec` ()
BEGIN
	SELECT * FROM LICHLAMVIEC;
END; $$

drop procedure if exists `sp_XemLichRanh`;
DELIMITER $$
CREATE PROCEDURE `sp_XemLichRanh` (i_MaNV char(10))
BEGIN
	SELECT * FROM LICHRANH WHERE MaNV=i_MaNV;
END; $$

drop procedure if exists `sp_ThemLichRanh`;
DELIMITER $$
CREATE PROCEDURE `sp_ThemLichRanh` (i_MaNV char(10), i_Ngay date, i_Ca varchar(10))
BEGIN
	INSERT INTO LICHRANH VALUES (i_MaNV, i_Ngay, i_Ca);
END; $$

drop procedure if exists `sp_XoaLichRanh`;
DELIMITER $$
CREATE PROCEDURE `sp_XoaLichRanh` (i_MaNV char(10), i_Ngay date, i_Ca varchar(10))
BEGIN
    DELETE FROM LICHRANH WHERE MaNV=i_MaNV AND Ngay=i_Ngay AND Ca=i_Ca;
END; $$

drop procedure if exists `sp_XemHoaDon`;
DELIMITER $$
CREATE PROCEDURE `sp_XemHoaDon` ()
BEGIN
    select * from HoaDon;
END; $$

drop procedure if exists `sp_XemCTHoaDon`;
DELIMITER $$
CREATE PROCEDURE `sp_XemCTHoaDon` (i_MaHD char(10))
BEGIN
    select * from CT_HoaDon where MaHD=i_MaHD;
END; $$

drop procedure if exists `sp_TimKhachHang`;
DELIMITER $$
CREATE PROCEDURE `sp_TimKhachHang` (i_CMND varchar(12))
BEGIN
	SELECT * FROM KhachHang WHERE CMND=i_CMND;
END; $$

drop procedure if exists `sp_TaoHD`;
DELIMITER $$
CREATE PROCEDURE `sp_TaoHD` (i_Loai varchar(50), i_MaKH char(10), i_NgayHen date, i_NguoiLap char(10))
BEGIN
	INSERT INTO hoadon VALUES (f_AutoMaHD(), i_Loai, i_MaKH, i_NgayHen, i_NguoiLap, NULL);
END; $$

drop procedure if exists `sp_ThemCTHD`;
DELIMITER $$
CREATE PROCEDURE `sp_ThemCTHD` (i_MaHD char(10), i_MaGT char(10), i_SoLuong int)
BEGIN
	INSERT INTO ct_hoadon VALUES (i_MaHD, i_MaGT, i_SoLuong, NULL);
END; $$