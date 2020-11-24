/****** Script for SelectTopNRows command from SSMS  ******/
-- 10 sp có đơn giá lớn nhất
select top(10) *
from HangHoa
order by DonGia asc

--10 sản phẩm có đơn giá nhỏ nhất
select top(10) *
from HangHoa
order by DonGia asc

-- tìm sản phẩm theo tên "chai"
select * from HangHoa
where TenHH like 'ch%'
-- tìm sp có mã là "1029"
select * from HangHoa
where MaHH = 1001
-- tìm sp có mã loại là "1000"
select * from HangHoa
where MaLoai = 1000 or MaLoai = 1001 or MaLoai = 1002
-- cách 2
select * from HangHoa
where MaLoai in(1000,1001,1002)

select * from HangHoa
where MaLoai not in(1000,1001,1002)

-- tìm hàng hóa có đơn giá lớn nhất
select * from HangHoa where DonGia = (select top(1) DonGia from HangHoa order by DonGia desc)

-- tìm hàng hóa có đơn giá từ 50 đến 100
select * from HangHoa where DonGia -->= 50 and DonGia <=100
between 50 and 100

-- đếm số loại sp trong bảng hàng hóa
select COUNT(*), MaLoai from HangHoa group by MaLoai

select COUNT(*) as Tổng from HangHoa where MaLoai = 1000

-- tổng số lần xem
select SUM(SoLanXem) from HangHoa

select a.*, b.TenLoai, c.TenCongTy from HangHoa as a, Loai as b, NhaCungCap as c
where a.MaLoai = b.MaLoai and a.MaNCC = c.MaNCC
and c.TenCongTy like '%nokia%' and b.TenLoai like '%seafood%'

delete from Loai where MaLoai = 1007
