
-- -Them thong tin vao co so du lieu.
alter table KhaiSinh add
	CCCDCha varchar(10),
	CCCDMe varchar(10)
-- -Hien Thi Thong Tin

update KhaiSinh set CCCDCha='123456710', CCCDMe='123456711'


select * from TaiKhoan;
select * from KhaiSinh;
select * from CongDan;
select * from HonNhan;
select * from CongDanTu;
select * from SoHoKhau;
select * from TamTru;
select * from LichSuTamTru;
select * from Hochieu;
select * from nhatky;
select * from LoaiThue;
select * from HoaDonThue;
select * from TaiKhoan;
-- - 1.Bảng dữ liệu về người đăng nhập:
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


-- - 2.Bảng dữ liệu về Khai Sinh.
Create Table KhaiSinh
(
  MaSoTo int primary key,
  HovaTen nvarchar(50),
  GioiTinh nvarchar(20),
  NgayThangNamSinh date,
  DanToc nvarchar(15),
  QuocTich nvarchar(10),
  NoiSinh nvarchar(30),
  HoTenCha nvarchar(50),
  DanTocCha nvarchar(15),
  QuocTichCha nvarchar(10),
  HoTenMe nvarchar(50),
  DanTocMe nvarchar(15),
  QuocTichMe nvarchar(10),
  NguoiDangKy nvarchar(50),
)
insert into KhaiSinh (MaSoTo, HovaTen, GioiTinh, NgayThangNamSinh, DanToc, QuocTich, NoiSinh, HoTenCha, DanTocCha, QuocTichCha, HoTenMe, DanTocMe, QuocTichMe, NguoiDangKy) 
values
(1, N'Nguyễn Văn A', N'Nam', '01-02-2003', N'Kinh', N'Việt Nam', N'Hà Nội', N'Nguyễn Văn B', N'Kinh', N'Việt Nam', N'Phạm Thị C', N'Kinh', N'Việt Nam', N'Nguyễn Thị D'),
(2, N'Trần Thị E', N'Nữ', '02-03-2005', N'Tày', N'Việt Nam', N'Thái Nguyên', N'Trần Văn F', N'Tày', N'Việt Nam', N'Nguyễn Thị G', N'Tày', N'Việt Nam', N'Phạm Thị H'),
(3, N'Lê Văn I', N'Nam', '03-04-2001', N'Mường', N'Việt Nam', N'Hòa Bình', N'Lê Thị K', N'Mường', N'Việt Nam', N'Nguyễn Thị L', N'Mường', N'Việt Nam', N'Trần Thị M'),
(4, N'Nguyễn Thị N', N'Nữ', '1999-04-05', N'Hoa', N'Việt Nam', N'Bình Dương', N'Nguyễn Văn O', N'Hoa', N'Việt Nam', N'Trần Thị P', N'Hoa', N'Việt Nam', N'Phạm Văn Q'),
(5, N'Lê Thị R', N'Nữ', '2007-05-03', N'Khơ Mú', N'Việt Nam', N'Lai Châu', N'Lê Văn S', N'Khơ Mú', N'Việt Nam', N'Nguyễn Thị T', N'Khơ Mú', N'Việt Nam', N'Trần Văn U'),
(6, N'Phạm Văn V', N'Nam', '1998-06-07', N'Chăm', N'Việt Nam', N'Ninh Thuận', N'Phạm Thị X', N'Chăm', N'Việt Nam', N'Trần Văn Y', N'Chăm', N'Việt Nam', N'Nguyễn Thị Z')


-- - 3. Bảng dữ liệu về Công Dân.
create table CongDan(
	cccd varchar(10),
	hoten nvarchar(30),
	gioitinh nvarchar(5),
	ngaysinh varchar(10),
	ngaymat varchar(10),
	quequan nvarchar(50),
	thuongtru nvarchar(50),
	tamtru nvarchar(50),
	dantoc nvarchar(10),
	honnhan nvarchar(10),
	cccdCha varchar(10),
	cccdMe varchar(10),
	primary key (cccd)
);
insert into CongDan(cccd,hoten,gioitinh,ngaysinh,quequan,thuongtru,tamtru,dantoc,honnhan,cccdCha,cccdMe)
	values('123456789',N'Đỗ Nam',N'Nam','2002-12-1',N'Bình Định',N'Bình Định',N'Sài Gòn','Kinh','Độc Thân','000','111');
insert into CongDan(cccd,hoten,gioitinh,ngaysinh,quequan,thuongtru,tamtru,dantoc,honnhan,cccdCha,cccdMe)
	values('123456788',N'Nguyễn Thị Oanh',N'Nu','1975-12-2',N'Bình Định',N'Bình Định',N'Sài Gòn','Kinh','Độc Thân','','');
insert into CongDan(cccd,hoten,gioitinh,ngaysinh,quequan,thuongtru,tamtru,dantoc,honnhan,cccdCha,cccdMe)
	values('123456710',N'Đỗ Nam Hai',N'Nam','2002-12-1',N'Bình Định',N'Bình Định',N'Sài Gòn','Kinh','Độc Thân','','');
insert into CongDan(cccd,hoten,gioitinh,ngaysinh,quequan,thuongtru,tamtru,dantoc,honnhan,cccdCha,cccdMe)
	values('123456711',N'Do Thi Huye',N'Nu','2002-12-2',N'Bình Định',N'Bình Định',N'Sài Gòn','Kinh','Độc Thân','123456788','');
	insert into CongDan(cccd,hoten,gioitinh,ngaysinh,quequan,thuongtru,tamtru,dantoc,honnhan,cccdCha,cccdMe)
	values('000',N'Do Cha',N'Nam','2002-12-2',N'Bình Định',N'Bình Định',N'Sài Gòn','Kinh','Độc Thân','','');
insert into CongDan(cccd,hoten,gioitinh,ngaysinh,quequan,thuongtru,tamtru,dantoc,honnhan,cccdCha,cccdMe)
	values('111',N'Do Thi Me',N'Nu','2002-12-2',N'Bình Định',N'Bình Định',N'Sài Gòn','Kinh','Độc Thân','','');
insert into CongDan(cccd,hoten,gioitinh,ngaysinh,quequan,thuongtru,tamtru,dantoc,honnhan,cccdCha,cccdMe)
	values('123456715',N'Đỗ Test',N'Nam','2002-12-1',N'Bình Định',N'Bình Định',N'Sài Gòn','Kinh','Độc Thân','000','111');
insert into CongDan(cccd,hoten,gioitinh,ngaysinh,quequan,thuongtru,tamtru,dantoc,honnhan,cccdCha,cccdMe)
	values('123456716',N'Nguyễn Thị Thu',N'Nu','1975-12-2',N'Bình Định',N'Bình Định',N'Sài Gòn','Kinh','Độc Thân','','');


--Xoá cột ngaymat
alter table CongDan
drop  column ngaymat
--chèn thêm cột tiền lương
alter table CongDan add TienLuong float
--chèn thêm cột QuocTich
alter table CongDan add QuocTich nvarchar(15)


update CongDan set QuocTich=N'Việt Nam'
update CongDan Set TienLuong=150000
update CongDan set honnhan=N'Kết Hôn' where cccd='113426729';

-- - 4. Bảng Dữ Liệu về Hôn Nhân.

Create Table HonNhan
(
   cccdNguoiChong varchar(10),
   cccdNguoiVo varchar(10),
   NgayDangKy date,
   NoiDangKy nvarchar(30)
)

-- - 5. Bang Du Lieu Khai Tu. 
create table CongDanTu(
	cccd varchar(10),
	ngaymat nvarchar(10),
	nguyennhan nvarchar(100),
	ngaydk nvarchar(4),
	thangdk nvarchar(4),
	namdk nvarchar(4),
	cccdCanbo nvarchar(10)
);

-- -6. Bang Du Lieu Ve SoHoKhau
Create Table SoHoKhau
(
  MsHoKhau nchar(20),
  MaSoTo int,
  cccd nvarchar(50),
  DoUuTien int
)
alter table SoHoKhau add
	Ngay int,
	Thang int,
	Nam int,
	CCCDNguoiDangKy varchar(10),
	SoDangKy varchar (10)
	
-- Trong Bang So Ho Khau Cap Nhat Them Dat O
alter table SoHoKhau add
	DatO nvarchar(20)

drop table SoHoKhau

insert into SoHoKhau(MsHoKhau,MaSoTo,cccd,DoUuTien,Ngay,Thang,Nam,CCCDNguoiDangKy,SoDangKy)
			values('1234',3,'111',1,11,11,2003,'123456710','04');
insert into SoHoKhau(MsHoKhau,MaSoTo,cccd,DoUuTien,Ngay,Thang,Nam,CCCDNguoiDangKy,SoDangKy)
			values('1234',9,null,2,1,11,2003,'123456710','04');

update SoHoKhau set DatO=N'330 LDH VN'

-- - 7. Bảng cơ sơ dữ liệu về TamTru

Create Table TamTru
(
   MaSoTo nvarchar(10) primary key,
   HoTen nvarchar(20),
   NgaySinh date,
   ThuongTru  nvarchar(30),
   TamTru nvarchar(30),
   CMND nvarchar(15),
   Lydo nvarchar(50),
   TenCanBo nvarchar(50),
   NoiDangKy nvarchar(50),
   NgayDangKy date,
   NgayKetThuc date ,
)

INSERT INTO TamTru (MaSoTo, HoTen, NgaySinh, ThuongTru, TamTru, CMND, Lydo, TenCanBo, NoiDangKy, NgayDangKy, NgayKetThuc)
VALUES 
('TT001', 'Nguyen Van A', '1990-01-01', '123 Nguyen Trai, Q1', '456 Le Loi, Q1', '123456789', 'Cong tac', 'Tran Thi An', 'Quan 1, TP. Ho Chi Minh', '2022-01-01', '2022-06-30'),
('TT002', 'Tran Van B', '1995-02-02', '789 Nguyen Hue, Q2', '101 Nguyen Thai Hoc, Q2', '234567890', 'Nghi hoc', 'Le Thi Binh', 'Quan 2, TP. Ho Chi Minh', '2022-02-01', '2022-07-31'),
('TT003', 'Pham Thi C', '1998-03-03', '111 Tran Hung Dao, Q3', '222 Nguyen Cong Tru, Q3', '345678901', 'Om dau', 'Nguyen Van C', 'Quan 3, TP. Ho Chi Minh', '2022-03-01', '2022-08-31'),
('TT004', 'Le Van D', '2000-04-04', '333 Nam Ky Khoi Nghia, Q4', '444 Vo Van Tan, Q4', '456789012', 'Di du lich', 'Pham Thi D', 'Quan 4, TP. Ho Chi Minh', '2022-04-01', '2022-09-30'),
('TT005', 'Hoang Thi E', '1993-05-05', '555 Nguyen Thi Minh Khai, Q5', '666 Ly Thuong Kiet, Q5', '567890123', 'Sinh hoat', 'Tran Van E', 'Quan 5, TP. Ho Chi Minh', '2022-05-01', '2022-10-31'),
('TT006', 'Nguyen Van F', '1988-06-06', '777 Tran Hung Dao, Q6', '888 Cao Thang, Q6', '678901234', 'Kham suc khoe', 'Le Thi F', 'Quan 6, TP. Ho Chi Minh', '2022-06-01', '2022-11-30'),
('TT007', 'Tran Thi G', '1999-07-07', '999 Nguyen Dinh Chieu, Q7', '111 Duong Dinh Nghe, Q7', '789012345', 'Lam viec', 'Pham Van G', 'Quan 7, TP. Ho Chi Minh', '2022-07-01', '2022-12-31');

-- -8: Bảng cơ sở dữ liệu về lịch sử tạm trú.
Create Table LichSuTamTru
(
   SoThuTu int primary key identity,
   MasoTo nvarchar(20),
   HoTen nvarchar(20),
   NgaySinh date,
   ThuongTru  nvarchar(30),
   TamTru nvarchar(30),
   CMND nvarchar(15),
   Lydo nvarchar(50),
   TenCanBo nvarchar(50),
   NoiDangKy nvarchar(50),
    NgayDangKy date ,
   NgayKetThuc date,
)

--9: Bảng cơ sở dữ liệu về Hộ Chiếu
CREATE TABLE Hochieu (
  ID INT PRIMARY KEY NOT NULL,
  SoDoc VARCHAR(20) NOT NULL,
  NgayCap DATE NOT NULL,
  NoiCap VARCHAR(100) NOT NULL,
  HoTen VARCHAR(50) NOT NULL,
  GioiTinh NVARCHAR(10) NOT NULL,
  NgaySinh DATE NOT NULL,
  DiaChi VARCHAR(100) NOT NULL,
  SoDienThoai VARCHAR(20) NOT NULL
)
-- Chèn dữ liệu vào bảng nhankhau_hochieu
INSERT INTO Hochieu(ID, SoDoc, NgayCap, NoiCap, HoTen, GioiTinh, NgaySinh, DiaChi, SoDienThoai)
VALUES 
(1, 'HD123456', '2022-03-15', 'TP.HCM', 'Nguyen Van A', 'Nam', '1990-05-10', '123 Nguyen Hue, Q.1, TP.HCM', '0901234567'),
(2, 'HD654321', '2022-04-20', 'Ha Noi', 'Tran Thi B', 'Nu', '1995-01-01', '456 Tran Hung Dao, Q.5, TP.HCM', '0987654321'),
(3, 'HD789456', '2022-02-05', 'Da Nang', 'Le Van C', 'Nam', '1985-11-30', '789 Le Duan, Q.3, TP.HCM', '0912345678'),
(4, 'HD159753', '2022-03-01', 'Can Tho', 'Pham Thi D', 'Nu', '2000-12-25', '1 Nguyen Trai, Q.5, TP.HCM', '0888888888');
go
CREATE TABLE nhatky (
  Stt int primary key,
  ID INT  NOT NULL,
  noiden NVARCHAR(50) NOT NULL,
  ngaydi DATE NOT NULL,
  ngayden DATE NOT NULL,
  FOREIGN KEY (ID) REFERENCES Hochieu(ID)
);
INSERT INTO   nhatky (Stt,ID, noiden, ngaydi, ngayden) 
VALUES 
(1,1, 'Japan', '2022-02-01', '2022-02-07'), 
(2,1, 'South Korea', '2022-02-08', '2022-02-14'), 
(3,2, 'United States', '2022-03-10', '2022-03-25'), 
(4,2, 'Canada', '2022-03-26', '2022-03-30'), 
(5,3, 'Australia', '2022-01-01', '2022-01-10'), 
(6,3, 'New Zealand', '2022-01-11', '2022-01-15')


-- 10. Bảng cơ sở dữ liệu về thuế.
CREATE TABLE LoaiThue (
   MaLoaiThue int PRIMARY KEY,
   TenLoaiThue nvarchar(50),
   MucThue float
);
CREATE TABLE HoaDonThue (
   MaHoaDon int PRIMARY KEY,
   MaCD varchar(10) REFERENCES CongDan(CCCD),
   MaLoaiThue int REFERENCES LoaiThue(MaLoaiThue),
   NgayLapHoaDon date,
   SoTienThue float
);
INSERT INTO LoaiThue (MaLoaiThue, TenLoaiThue, MucThue)
VALUES 
(1, N'Thuế thu nhập cá nhân', 0.1),
(2, N'Thuế giá trị gia tăng', 0.05), 
(3, N'Thuế thu nhập doanh nghiệp', 0.2);
INSERT INTO HoaDonThue (MaHoaDon, MaCD, MaLoaiThue, NgayLapHoaDon, SoTienThue)
VALUES

(6, '123456590', 2, '2022-04-20', 500000);

