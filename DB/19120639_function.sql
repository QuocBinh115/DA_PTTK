
SET GLOBAL log_bin_trust_function_creators = 1;
use qltc;
drop function if exists qltc.f_AutoMaHD;
delimiter $$
create function qltc.f_AutoMaHD() returns char(10)
begin
	declare i_MaHD varchar(10) default '00000001';
	while exists (SELECT * FROM HoaDon WHERE MaHD = concat('HD', i_MaHD)) do
		SET i_MaHD = i_MaHD + 1;
		SET i_MaHD = concat(repeat('0',8-LENGTH(convert(i_MaHD,char))), convert(i_MaHD,char));
	end while;
	set i_MaHD = concat('HD', i_MaHD);
	return i_MaHD;
end $$

drop function if exists f_AutoMaVX;
delimiter $$
create function f_AutoMaVX() returns char(10)
begin
	declare i_MaVX varchar(10) default '00000001';
	while exists (SELECT * FROM Vaccine WHERE MaVX = concat('VX', i_MaVX)) do
		SET i_MaVX = i_MaVX + 1;
		SET i_MaVX = concat(repeat('0',8-LENGTH(convert(i_MaVX,char))), convert(i_MaVX,char));
	end while;
	set i_MaVX = concat('VX', i_MaVX);
	return i_MaVX;
end $$

drop function if exists f_AutoMaDonDH;
delimiter $$
create function f_AutoMaDonDH() returns char(10)
begin
	declare i_MaDonDH varchar(10) default '00000001';
	while exists (SELECT * FROM dathang WHERE MaDonDH = concat('DH', i_MaDonDH)) do
		SET i_MaDonDH = i_MaDonDH + 1;
		SET i_MaDonDH = concat(repeat('0',8-LENGTH(convert(i_MaDonDH,char))), convert(i_MaDonDH,char));
	end while;
	set i_MaDonDH = concat('DH', i_MaDonDH);
	return i_MaDonDH;
end $$