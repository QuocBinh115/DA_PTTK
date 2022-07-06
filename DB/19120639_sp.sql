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
CREATE PROCEDURE qltc.`sp_TaoHD` (i_Loai varchar(50), i_MaKH char(10), i_NgayHen date, i_NguoiLap char(10))
BEGIN
	declare i_MaHD varchar(10);
    set i_MaHD = f_AutoMaHD();
	INSERT INTO hoadon VALUES (i_MaHD, i_Loai, i_MaKH, i_NgayHen, i_NguoiLap, NULL);
    select i_MaHD MaHD from dual;
END; $$

drop procedure if exists `sp_ThemCTHD`;
DELIMITER $$
CREATE PROCEDURE `sp_ThemCTHD` (i_MaHD char(10), i_MaGT char(10), i_SoLuong int)
BEGIN
	INSERT INTO ct_hoadon VALUES (i_MaHD, i_MaGT, i_SoLuong, NULL);
END; $$

drop procedure if exists `sp_ThemVaccine`;
DELIMITER $$
CREATE PROCEDURE `sp_ThemVaccine` (i_Ten varchar(50), i_NXS varchar(50), i_HSD date, i_GiaMua int)
BEGIN
    declare i_MaVX varchar(10);
    set i_MaVX = f_AutoMaVX();
    INSERT INTO vaccine VALUES (i_MaVX, i_Ten, i_NXS,i_GiaMua, i_HSD, NULL);
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
    set i_Gia = (select ifnull(dongia,0) from goitiem where MaGT = i_MaGT);
    set i_ThanhTien = i_SoLuong * i_Gia;
END; $$

drop procedure if exists `sp_ThanhTienDonHD`;
DELIMITER $$
CREATE PROCEDURE `sp_ThanhTienDonHD` (
	i_MaVX varchar(10),
    i_SoLuong int, 
    out i_ThanhTien int)
BEGIN
	declare i_Gia int;
    set i_Gia = (select ifnull(giamua,0) from vaccine where MaVX = i_MaVX);
    set i_ThanhTien = i_SoLuong * i_Gia;
END; $$

drop procedure if exists `sp_TongTienHD`;
DELIMITER $$
CREATE PROCEDURE `sp_TongTienHD` (i_MaHD varchar(10))
BEGIN
	declare i_TongTien int;
    declare i_DatHang int;
    set i_DatHang = (select ifnull(sum(TongTien),0) from dathang where MaHD = i_MaHD);
    set i_TongTien = (select ifnull(sum(ThanhTien),0) from ct_hoadon where MaHD = i_MaHD);
    update hoadon
    set TongTien = i_TongTien + i_DatHang where MaHD = i_MaHD;
END; $$

drop procedure if exists `sp_TongTienDH`;
DELIMITER $$
CREATE PROCEDURE `sp_TongTienDH` (i_MaDonDH varchar(10))
BEGIN
	declare i_TongTien int;
    set i_TongTien = (select ifnull(sum(ThanhTien),0) from ct_dondh where MaDonDH = i_MaDonDH);
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

drop procedure if exists `sp_DatHang`;
DELIMITER $$
CREATE PROCEDURE `sp_DatHang` (i_MaHD varchar(50))
BEGIN
	declare i_MaDonDH varchar(10);
    set i_MaDonDH = f_AutoMaDonDH();
	INSERT INTO dathang VALUES (i_MaDonDH, i_MaHD, NULL, FALSE);
    select i_MaDonDH;
END; $$

drop procedure if exists `sp_ThemCTDatHang`;
DELIMITER $$
CREATE PROCEDURE `sp_ThemCTDatHang` (i_MaDonDH varchar(10), i_MaVX varchar(10), i_SoLuong int, i_ThanhTien int)
BEGIN
	INSERT INTO ct_dondh VALUES (i_MaDonDH, i_MaVX, i_SoLuong, i_ThanhTien);
END; $$

drop procedure if exists `sp_XepLich`;
DELIMITER $$
CREATE PROCEDURE `sp_XepLich` ()
BEGIN
	declare n int;
    declare i int;
    declare i_Ngay date;
    declare i_Ca varchar(10);
    set n = (select count(*) from lichlamviec);
    set i = 0;
	while i < n do
		if (select MaNV from lichlamviec limit i,1) is null then
			set i_Ngay = (select Ngay from lichlamviec limit i,1);
            set i_Ca = (select Ca from lichlamviec limit i,1);
			if exists (select * from lichranh where Ngay = i_Ngay and Ca = i_Ca) then
				update lichlamviec
                set MaNV = (select MaNV from lichranh where Ngay = i_Ngay and Ca = i_Ca limit 1)
                where Ngay = i_Ngay and Ca = i_Ca;
			end if;
		end if;
        set i = i+1;
	end while;
END; $$

drop procedure if exists `sp_TaoHSBN`;
DELIMITER $$
CREATE PROCEDURE `sp_TaoHSBN` (i_MaBN char(10), i_Ngay date, i_NguoiTiem varchar(10))
BEGIN
	INSERT INTO hosobn VALUES (i_MaBN, i_NgayKham, i_NguoiTiem);
END; $$

drop procedure if exists `sp_ThemCTHSBN`;
DELIMITER $$
CREATE PROCEDURE `sp_ThemCTHSBN` (i_MaBN char(10), i_NgayKham date, i_NguoiKham varchar(10), i_STT int, i_MoTa varchar(50))
BEGIN
	INSERT INTO chitiethsbn VALUES (i_MaBN, i_NgayKham, i_STT, i_NguoiKham, i_MoTa);
END; $$