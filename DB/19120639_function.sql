SET GLOBAL log_bin_trust_function_creators = 1;
drop function if exists f_AutoMaHD;
delimiter $$
create function f_AutoMaHD() returns char(10)
begin
	declare i_MaHD varchar(10) default '00000001';
	while exists (SELECT * FROM HoaDon WHERE MaHD = concat('HD', i_MaHD)) do
		SET i_MaHD = i_MaHD + 1;
		SET i_MaHD = concat(repeat('0',8-LENGTH(convert(i_MaHD,char))), convert(i_MaHD,char));
	end while;
	set i_MaHD = concat('HD', i_MaHD);
	return i_MaHD;
end $$