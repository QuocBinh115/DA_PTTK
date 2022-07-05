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
	declare i_MaHD varchar(10);
    set i_MaHD = f_AutoMaHD();
	INSERT INTO hoadon VALUES (i_MaHD, i_Loai, i_MaKH, i_NgayHen, i_NguoiLap, NULL);
    select i_MaHD;
END; $$

drop procedure if exists `sp_ThemCTHD`;
DELIMITER $$
CREATE PROCEDURE `sp_ThemCTHD` (i_MaHD char(10), i_MaGT char(10), i_SoLuong int)
BEGIN
	INSERT INTO ct_hoadon VALUES (i_MaHD, i_MaGT, i_SoLuong, NULL);
END; $$

drop procedure if exists `sp_ThemVaccine`;
DELIMITER $$
CREATE PROCEDURE `sp_ThemVaccine` (i_Ten varchar(50), i_NXS varchar(50), i_HSD date)
BEGIN
	declare i_MaVX varchar(10);
    set i_MaVX = f_AutoMaVX();
	INSERT INTO hoadon VALUES (i_MaVX, i_Ten, i_NXS, i_HSD);
    select i_MaVX;
END; $$

drop procedure if exists `sp_ThanhTienHD`;
DELIMITER $$
CREATE PROCEDURE `sp_ThanhTienHD` (
	i_MaGT varchar(10),
    i_SoLuong int, 
    out i_ThanhTien int)
BEGIN
	declare i_Gia int;
    set i_Gia = (select dongia from goitiem where MaGT = i_MaGT);
    set i_ThanhTien = i_SoLuong * i_Gia;
END; $$

drop procedure if exists `sp_TongTienHD`;
DELIMITER $$
CREATE PROCEDURE `sp_TongTienHD` (i_MaHD varchar(10))
BEGIN
	declare i_TongTien int;
    declare i_DatHang int;
    set i_DatHang = (select sum(TongTien) from dathang where MaHD = i_MaHD);
    set i_TongTien = (select sum(ThanhTien) from ct_hoadon where MaHD = i_MaHD);
    update hoadon
    set TongTien = i_TongTien where MaHD = i_MaHD;
END; $$

drop procedure if exists `sp_TongTienDH`;
DELIMITER $$
CREATE PROCEDURE `sp_TongTienDH` (i_MaDonDH varchar(10))
BEGIN
	declare i_TongTien int;
    set i_TongTien = (select sum(ThanhTien) from ct_dondh where MaDonDH = i_MaDonDH);
    update dathang
    set TongTien = i_TongTien where MaDonDH = i_MaDonDH;
END; $$

drop procedure if exists `sp_CheckGoiTiem`;
DELIMITER $$
CREATE PROCEDURE `sp_CheckGoiTiem` (i_MaGT varchar(10), i_SoLuong int)
BEGIN
	select if(SoLuongTon > i_SoLuong, TRUE, FALSE) 
	from vaccine 
    where MaVX in (select MaVX from ct_goitiem where MaGT = i_MaGT);
END; $$
