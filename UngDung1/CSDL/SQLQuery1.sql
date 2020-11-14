--Tạo CSDL bán hàng
--create database BanHang
--go
use BanHang
go
--Tạo bảng
--create table HangHoa(
--	MaHH nchar(50) primary key,
--	TenHH nchar(50),
--	Gia decimal(18,2),
--	SoLuong int,
--	QuyCachDongGoi nchar(50),
--)
--Thêm 1 dòng vào bảng
insert into HangHoa
(MaHH
,TenHH
,Gia
,SoLuong
,QuyCachDongGoi
)values(
	'hh003',
	N'Áo Somi',
	150000,
	10,
	N'Cái'
)