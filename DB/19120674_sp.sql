USE QLTC;

drop procedure if exists `sp_CheckGoiTiem`;
DELIMITER $$
CREATE PROCEDURE `sp_CheckGoiTiem` (i_MaGT varchar(10), i_SoLuong int)
BEGIN
	select if(SoMui*i_SoLuong < SoLuongTon,true,false) as sl
    from ct_goitiem c left join vaccine v on c.MaVX=v.MaVX
    where MaGT = i_MaGT;
END; $$

DROP PROCEDURE IF EXISTS sp_XemDSGoiTiem;
DELIMITER $$
CREATE PROCEDURE `sp_XemDSGoiTiem` ()
BEGIN
	select * from goitiem;
END; $$ 

DROP PROCEDURE IF EXISTS sp_XemCTGoiTiem;
DELIMITER $$
CREATE PROCEDURE `sp_XemCTGoiTiem` (i_MaGT char(10))
BEGIN
	select * from ct_goitiem where MaGT=i_MaGT;
END; $$ 

drop procedure if exists `sp_ThemGiamHo`;
DELIMITER $$
CREATE PROCEDURE `sp_ThemGiamHo` (i_MaKH VarChar(10), i_HoTen varchar(50), i_NgaySinh date, 
i_GioiTinh bit, i_DiaChi varchar(100), 
i_CMND varchar(12), i_SDT varchar(10),i_qh varchar(10))
BEGIN
declare i_MaGH varchar(10);
set i_MaGH = f_AutoMaKH();
	INSERT INTO khachhang(MaKH, HoTenKH, NgaySinh, GioiTinh, DiaChi, CMND, SDT) VALUES(i_MaGH, i_HoTen, i_NgaySinh, i_GioiTinh, i_DiaChi, i_CMND, i_SDT);
	INSERT INTO nguoigiamho(MaKH, NguoiGiamHo, QuanHe) VALUES (i_MaKH,i_MaGH, i_qh);
END; $$

drop procedure if exists `sp_CapNhatNgayHen`;
DELIMITER $$
CREATE PROCEDURE `sp_CapNhatNgayHen` (i_MaHD varchar(10), i_NgayHen date)
BEGIN
    Update HoaDon set Ngayhen=i_NgayHen where MaHD=i_MaHD;
END; $$