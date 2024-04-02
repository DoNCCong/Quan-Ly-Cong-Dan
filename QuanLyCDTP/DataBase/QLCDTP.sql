Create DataBase QLCongDanTP
go
use QLCongDanTP
go 
Create Table TaiKhoan
(
  MaNV nchar(6) primary key,
  MatKhau nchar(20),
  HoTen nvarchar(40),
  ChiNhanh nvarchar(50),
  SoDT nvarchar(10),
  LoaiTK nvarchar(15)
)
go
insert into TaiKhoan values
('nv01','anhhuy123',N'Đặng Nguyễn Quang Huy',N'Thành Phố Thủ Đức,TP HCM','0395012039',N'Nhân Viên'),
('nv02','Cong12',N'Đỗ Ngọc Chí Công',N'Thành Phố Thủ Đức,TP HCM','0334012311',N'Nhân Viên'),
('nv03','Luan34',N'Trần Văn Luân',N'Thành Phố An Giang','0320128971',N'Quản Lý')
