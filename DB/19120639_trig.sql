use qltc;

-- ThanhTienHD
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

-- TongTienDH
drop trigger if exists trg_TongTienDH_update;
delimiter $$
create trigger trg_TongTienDH_update
after update on ct_dondh
for each row
begin
	call sp_TongTienDH(new.MaDonDH);
end $$

drop trigger if exists trg_TongTienDH_insert;
delimiter $$
create trigger trg_TongTienDH_insert
after insert on ct_dondh
for each row
begin
	call sp_TongTienDH(new.MaDonDH);
end $$

drop trigger if exists trg_TongTienDH_delete;
delimiter $$
create trigger trg_TongTienDH_delete
after delete on ct_dondh
for each row
begin
	call sp_TongTienDH(old.MaDonDH);
end $$

-- TongTienHD
-- CTHD
drop trigger if exists trg_TongTienHD_CTHD_insert;
delimiter $$
create trigger trg_TongTienHD_CTHD_insert
after insert on ct_hoadon
for each row
begin
	call sp_TongTienHD(new.MaHD);
end $$

drop trigger if exists trg_TongTienHD_CTHD_update;
delimiter $$
create trigger trg_TongTienHD_CTHD_update
after update on ct_hoadon
for each row
begin
	call sp_TongTienHD(new.MaHD);
end $$

drop trigger if exists trg_TongTienHD_CTHD_delete;
delimiter $$
create trigger trg_TongTienHD_CTHD_delete
after delete on ct_hoadon
for each row
begin
	call sp_TongTienHD(old.MaHD);
end $$

-- CTDH
drop trigger if exists trg_TongTienHD_DatHang_insert;
delimiter $$
create trigger trg_TongTienHD_DatHang_insert
after insert on dathang
for each row
begin
	call sp_TongTienHD(new.MaHD);
end $$

drop trigger if exists trg_TongTienHD_DatHang_update;
delimiter $$
create trigger trg_TongTienHD_DatHang_update
after update on dathang
for each row
begin
	call sp_TongTienHD(new.MaHD);
end $$

drop trigger if exists trg_TongTienHD_DatHang_delete;
delimiter $$
create trigger trg_TongTienHD_DatHang_delete
after delete on dathang
for each row
begin
	call sp_TongTienHD(old.MaHD);
end $$