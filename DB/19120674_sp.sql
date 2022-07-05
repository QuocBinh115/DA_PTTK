USE QLTC;

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
