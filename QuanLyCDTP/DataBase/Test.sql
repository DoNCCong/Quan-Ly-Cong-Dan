--select * from HonNhan where cccdNguoiChong={cccdNam} or cccdNguoiVo={cccdNu}


alter table SoHoKhau add NoiDangKy nvarchar(20)
select * from SoHoKhau;
select * from LoaiThue;
alter table SoHoKhau add NoiDangKy nvarchar(20)
update SoHoKhau set NoiDangKy=N'Hà Nội'
select * from TamTru
select * from KhaiSinh where MaSoTo = 1
select * from CongDan
select * from HonNhan
select * from KhaiSinh;
select * from CongDanTu;
Insert Into CongDan Values('{0}',N'{1}',N'{2}',N'{3}',N'{4}',N'{5}',N'{6}',N'{7}',N'{8}',N'{9}',N'{10}',N'{11}','{12}')

Insert Into CongDan(cccd,hoten,gioitinh,ngaysinh,quequan,thuongtru,tamtru,dantoc,honnhan,cccdCha,cccdMe,TienLuong,QuocTich) 
		Values('123456777',N'Đỗ Nam',N'Nam','2002-12-1',N'Bình Định',N'Bình Định',N'Sài Gòn','Kinh','Độc Thân','000','111','150000',N'Việt Nam')

--insert into KhaiSinh(MaSoTo,HovaTen,GioiTinh,NgayThangNamSinh,DanToc,QuocTich,NoiSinh,HoTenCha,DanTocCha,QuocTichCha,HoTenMe,DanTocMe,QuocTichMe,NguoiDangKy,CCCDCha,CCCDMe)
  --              Values('{0}',N'{1}',N'{2}',N'{3}',N'{4}',N'{5}',N'{6}',N'{7}',N'{8}',N'{9}',N'{10}',N'{11}',N'{12}',N'{13}',N'{14}',N'{15}')

select ngaymat from CongDanTu;

select * from KhaiSinh;
insert into CongDan(cccd,hoten,gioitinh,ngaysinh,quequan,thuongtru,tamtru,dantoc,honnhan,cccdCha,cccdMe)
	values('123456720',N'Đỗ Hào',N'Nam','2002-12-1',N'Bình Định',N'Bình Định',N'Sài Gòn','Kinh','Độc Thân','123456710','123456711');
insert into CongDan(cccd,hoten,gioitinh,ngaysinh,quequan,thuongtru,tamtru,dantoc,honnhan,cccdCha,cccdMe)
	values('123456721',N'Nguyễn Quỳnh',N'Nu','2003-12-2',N'Bình Định',N'Bình Định',N'Sài Gòn','Kinh','Độc Thân','123456715','123456788');

insert into HonNhan(cccdNguoiChong,cccdNguoiVo,NgayDangKy,NoiDangKy)
		values ('123456720','123456721','2023-12-2',N'Sài Gòn')

update CongDan set honnhan = N'Kết Hôn' where cccd='123456720' or cccd='123456721'
update CongDan set TienLuong = N'15000', QuocTich=N'Việt Nam' where cccd='123456720' or cccd='123456721'


select * from KhaiSinh
alter table KhaiSinh add
	NgayThangNamDK date,
	NoiDangKy nvarchar(20)
update KhaiSinh set NguoiDangKy='123456720', NgayThangNamDK='2023-05-02', NoiDangKy=N'Sài Gòn'
select * from HonNhan
alter table HonNhan add CCCDNguoiDangKy varchar(10);
update HonNhan set CCCDNguoiDangKy = 123456720

select * from CongDanTu;
select * from cccd;
select * from LoaiThue;
alter table LoaiThue add
	NgayThangNamDK date,
	NoiDangKy nvarchar(20)
alter table LoaiThue add
	CCCDcanbo varchar(10)
select * from LoaiThue
select * from CongDan
select * from SoHoKhau;
update LoaiThue set NgayThangNamDK='2023-05-02', NoiDangKy=N'Sài Gòn'
update LoaiThue set CCCDcanbo='123456711'



select t.MsHoKhau,c.hoten,ngaysinh,gioitinh,quequan,dantoc,thuongtru,QuocTich,t.Ngay,t.Thang,t.Nam,t.CCCDNguoiDangKy,NoiDangKy as CanBo from CongDan c
                                   join(select * from SoHoKhau where cccd = '{cccd}') t 
                                   on t.cccd = c.cccd 
                                   join(select cccd, hoten from CongDan) k
                                   on k.cccd = '1234'
select * from CongDanTu
alter table CongDanTu add NoiDangKy varchar(20)
update CongDanTu set NoiDangKy=N'Sài Gòn'
select * from SoHoKhau
select * from KhaiSinh
select MsHoKhau, k.hotendk,quequan,Ngay,Thang,Nam,CCCDNguoiDangKy,hoten as TruongCongAn,SoDangKy,k.dantoc,k.QuocTich,ngaysinh,k.gioitinh,DatO,NoiDangKy from SoHoKhau
                                join(select cccd, hoten from CongDan) c on SoHoKhau.CCCDNguoiDangKy = c.cccd
                                join(select cccd, hoten as hotendk, quequan, dantoc, ngaysinh, gioitinh, QuocTich from CongDan) k on SoHoKhau.cccd = k.cccd
                                where SoHoKhau.MsHoKhau = '1234'
                                union
select MsHoKhau, HovaTen, NoiSinh, Ngay, Thang, Nam, NguoiDangKy, hoten as TruongCongAn, SoDangKy, DanToc, QuocTich, NgayThangNamSinh, GioiTinh, DatO,SoHoKhau.NoiDangKy as NoiDangKy from SoHoKhau
                                join (select *from KhaiSinh) t on SoHoKhau.MaSoTo = t.MaSoTo
                                join(select cccd, hoten from CongDan) c on SoHoKhau.CCCDNguoiDangKy = c.cccd
                                where SoHoKhau.MsHoKhau = '1234'
								--,hn.CCCDNguoiDangKy
select hn.cccdNguoiChong,cd1.hoten,cd1.ngaysinh,cd1.quequan,cd1.honnhan ,hn.cccdNguoiVo,cd2.hoten,cd2.ngaysinh,cd2.quequan,hn.NgayDangKy,hn.NoiDangKy From CongDan as cd1,CongDan,hn.CCCDNguoiDangKy as cd2,HonNhan as hn where hn.cccdNguoiChong=cd1.cccd and hn.cccdNguoiVo=cd2.cccd

/*Update KhaiSinh set HovaTen=N'{0}',GioiTinh=N'{1}',NgayThangNamSinh=N'{2}',DanToc=N'{3}'
                ,QuocTich=N'{4}',NoiSinh=N'{5}',HoTenCha=N'{6}',DanTocCha='{7}',QuocTichCha=N'{8}',HoTenMe=N'{9}',DanTocMe=N'{10}',QuocTichMe=N'{11}',NguoiDangKy=N'{12}',CCCDCha=N'{13}',CCCDMe=N'{14}',NgayThangNamDK=N'{15}', NoiDangKy=N'{16}'
                 where masoto='{17}'
,ks.Hoten, ks.Gioitinh, ks.NgayThangNamSinh, ks.Dantoc, ks.Quoctich,
             ks.Noisinh, ks.Hotencha, ks.Dantoccha, ks.Quoctichcha, ks.Hotenme, ks.Dantocme, ks.Quoctichme, ks.CCCDCanBo, ks.CCCDCha, ks.CCCDMe, ks.NgayThangNamDK, ks.NoiDangKy,ks.MaSoTo);*/
select hn.cccdNguoiChong,cd1.hoten,cd1.ngaysinh,cd1.quequan,cd1.honnhan ,hn.cccdNguoiVo,cd2.hoten,cd2.ngaysinh,cd2.quequan,hn.NgayDangKy,hn.NoiDangKy,hn.CCCDNguoiDangKy From CongDan as cd1,CongDan as cd2,HonNhan as hn where hn.cccdNguoiChong=cd1.cccd and hn.cccdNguoiVo=cd2.cccd


/*insert into CongDanTu(cccd,ngaymat,nguyennhan,ngaydk,thangdk,namdk,cccdCanbo,NoiDangKy) " +
                "values('{shk.Cccd}', '{shk.Ngaymat}', '{shk.Nguyennhan}', '{shk.Ngay}', '{shk.Thang}', '{shk.Nam}', '{shk.Cccdnguoidangky}','{shk.NoiDangKy}')"*/
select * from TamTru
select * from CongDan;
alter table CongDan add  NoiDangKy nvarchar(20)
alter table CongDan add  CCCDNguoiDangKy nvarchar(20), NgayThangNamDK varchar(10)
alter table CongDan drop column  NoiDangKy, CCCDNguoiDangKy, NgayThangNamDK
update CongDan set NoiDangKy=N'Sài Gòn'
update CongDan set CCCDNguoiDangKy=N'123456711'
update CongDan set NgayThangNamDK=N'2002-12-2'

select * from KhaiSinh
select * from HonNhan
select * from CongDan
alter table KhaiSinh add primary key (MaSoTo)
alter table HonNhan alter column cccdNguoiChong varchar(10) not null
alter table HonNhan alter column cccdNguoiVo varchar(10) not null
alter table HonNhan add CONSTRAINT keyhonnhan primary key (cccdNguoiChong,cccdNguoiVo)
alter table CongDan add primary key (cccd)

select * from SoHoKhau
drop table SoHoKhau

delete from SoHoKhau


alter table SoHoKhau alter column MsHoKhau nvarchar(10) not null
alter table SoHoKhau alter column MaSoTo int not null
alter table SoHoKhau alter column cccd nvarchar(10) not null
alter table SoHoKhau add primary key (MsHoKhau,MaSoTo,cccd)


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
	