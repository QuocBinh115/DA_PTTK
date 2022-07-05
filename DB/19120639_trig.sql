use qltc;

drop trigger if exists trg_ThanhTienHD_update;
delimiter $$
create trigger trg_ThanhTienHD_update
before update on ct_hoadon
for each row
begin
	call sp_ThanhTienHD(new.MaGT, new.SoLuong, new.ThanhTien);
end $$

drop trigger if exists trg_ThanhTienHD_insert;
delimiter $$
create trigger trg_ThanhTienHD_insert
before insert on ct_hoadon
for each row
begin
	call sp_ThanhTienHD(new.MaGT, new.SoLuong, new.ThanhTien);
end $$

drop trigger if exists trg_TongTienHD_insert;
delimiter $$
create trigger trg_TongTienHD_insert
before insert on ct_hoadon
for each row
begin
	call sp_TongTienHD(new.MaHD);
end $$

drop trigger if exists trg_TongTienHD_update;
delimiter $$
create trigger trg_TongTienHD_update
before update on ct_hoadon
for each row
begin
	call sp_TongTienHD(new.MaHD);
end $$

drop trigger if exists trg_TongTienDH_update;
delimiter $$
create trigger trg_TongTienDH_update
before update on ct_dondh
for each row
begin
	call sp_TongTienDH(new.MaDonDH);
end $$

drop trigger if exists trg_TongTienDH_insert;
delimiter $$
create trigger trg_TongTienDH_insert
before insert on ct_dondh
for each row
begin
	call sp_TongTienDH(new.MaDonDH);
end $$