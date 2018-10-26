create database QLTHUVIEN

go
use QLTHUVIEN
go
create table BANGCAP
(
	MaBC char(3) primary key,
	TenBC nvarchar(50) not null
)
create table CHUCVU
(
	MaCV char(3) primary key,
	TenCV nvarchar(50) not null
)
create table BOPHAN
(
	MaBP char(3) primary key,
	TenBP nvarchar(50) not null
)
create table LOAIDOCGIA
(
	MaDG char(4) primary key,
	LoaiDG nvarchar(20) not null
)
create table THELOAISACH
(
	MaLoai char(2) primary key,
	TenTheLoai nvarchar(50) not null
)
go
create table NHANVIEN
(
	MaNV char(3) primary key,
	HoTen nvarchar(50) not null,
	NgaySinh datetime not null,
	DiaChi nvarchar(50),
	Email nvarchar(30),
	DienThoai nvarchar(14),
	BangCap char(3) references BANGCAP(MaBC) not null,
	BoPhan char(3) references BOPHAN(MaBP) not null,
	ChucVu char(3) references CHUCVU(MaCV) not NULL,
	Account VARCHAR(30) not NULL UNIQUE,
	Pass VARCHAR(20) not null
)
go 
create table DOCGIA
(
	MaDG char(3) primary key,
	HoTen nvarchar(50) not null,
	NgaySinh datetime not null,
	DiaChi nvarchar(50),
	Email nvarchar(30),
	LoaiDG char(4) not null references LOAIDOCGIA(MaDG),
	NgayLap datetime not null,
	NVLap char(3) references NHANVIEN(MaNV) not null
)
go
create table SACH
(
	MaSach char(3) primary key,
	TenSach nvarchar(50) not null,
	Loai char(2) references THELOAISACH(MaLoai) not null,
	TacGia nvarchar(30),
	NamXB int,
	NhaXB nvarchar(50),
	NgayNhap datetime not null,
	TriGia money not null,
	NVTiepNhan char(3) references NHANVIEN(MaNV) not null
)
go
create table MUONSACH
(
	MaPhieuMuon int primary key,
	MADG char(3) references DOCGIA(MaDG) not null,
	NGAYMUON datetime not null
)
go 
create table THONGKEMUONSACH
(
	MaPM int references MUONSACH(MaPhieuMuon),
	MaSach char(3) references SACH(MaSach),
	primary key (MaPM,MaSach)
)
go
create table CTMUONSACH
(
	MaPM int  references MUONSACH(MaPhieuMuon),
	MaDG char(3)  references DOCGIA(MaDG),
	SachMuon char(3) references SACH(MaSach),
	NgayMuon datetime not null,
	Han nvarchar(50),
	primary key (MaPM, MaDG, SachMuon)
)
go
insert into BANGCAP values ('BC1',N'Tú Tài')
insert into BANGCAP values ('BC2',N'Trung Cấp')
insert into BANGCAP values ('BC3',N'Cao Đẳng')
insert into BANGCAP values ('BC4',N'Đại Học')
insert into BANGCAP values ('BC5',N'Thạc Sĩ')
insert into BANGCAP values ('BC6',N'Tiến Sĩ')
go

insert into BOPHAN values ('BP1',N'Thủ Thư')
insert into BOPHAN values ('BP2',N'Thủ Kho')
insert into BOPHAN values ('BP3',N'Thủ Quỹ')
insert into BOPHAN values ('BP4',N'Ban Giám Đốc')
go

insert into CHUCVU values ('CV1',N'Giám Đốc')
insert into CHUCVU values ('CV2',N'Phó Giám Đốc')
insert into CHUCVU values ('CV3',N'Trưởng Phòng')
insert into CHUCVU values ('CV4',N'Phó Phòng')
insert into CHUCVU values ('CV5',N'Nhân Viên')
go

insert into LOAIDOCGIA values ('DGL1',N'Thanh Thiếu Niên')
insert into LOAIDOCGIA values ('DGL2',N'Thiếu Nhi')
go

insert into THELOAISACH values ('L1',N'Văn Học')
insert into THELOAISACH values ('L2',N'Tiểu thuyết')
insert into THELOAISACH values ('L3',N'Truyện Thiếu Nhi')
go

insert into NHANVIEN values ('112', N'Lê Thị Hoa', '1989-12-11', N'Quãng Bình', 'lth@gmail.com', '12345678987', 'BC3', 'BP3', 'CV3','lethihoa','12345')
insert into NHANVIEN values ('123',	N'Phan Thế Hiển', '1986-11-01',	N'Nha Trang', 'pth@gmail.com', '12345679876', 'BC1',	'BP1',	'CV5','phanthehien','12345')
insert into NHANVIEN values ('133',	N'Hoàng Minh', '1989-12-11',	N'Buôn Ma Thuộc', 'hm@gmail.com',	'45677654321',	'BC2',	'BP2',	'CV4','hoangminh','12345')
insert into NHANVIEN values ('155',	N'Dương Thị Tùng', '1977-10-10', N'TPHCM', 'dtt@gmail.com', '0983821987', 'BC6', 'BP4', 'CV2','duongthitung','12345')
insert into NHANVIEN values ('159',	N'Nguyễn Thanh Tâm',	'1983-03-11', N'Nam ĐỊnh', 'ntt@gmail.com',	'45678998765',	'BC3',	'BP2',	'CV3','nguyenthanh','12345')
insert into NHANVIEN values ('177',	N'Mai Thanh Ngân', '1982-11-04', N'Bắc Giang', 'mtn@gmail.com',	'34548913774',	'BC2',	'BP1',	'CV4','maithanhngan','12345')
insert into NHANVIEN values ('179',	N'Nguyễn Khắc Sơn', '1978-03-12', N'Hà Nội',	'nks@gmail.com',	'0905224243',	'BC4',	'BP4',	'CV3','nguyenkhac','12345')
insert into NHANVIEN values ('184',	N'Lê Vĩnh Phúc',	'1985-07-03', N'Tây Ninh',	'lvp@gmail.com',	'87654334567',	'BC2',	'BP1',	'CV5','levinhphuc','12345')
insert into NHANVIEN values ('333',	N'Nguyễn Khắc Sinh',	'1975-12-11', N'Bình Dương',	'nks@gmail.com',	'45678987654',	'BC2',	'BP2',	'CV4','nguyenkhacsinh','12345')
go

insert into DOCGIA values ('D01',	N'Nguyễn Thanh Minh', '1982-01-02',	N'Bình Dương', 'tttt@gmail.com',	'DGL1',	'2017-04-05',	'177')
insert into DOCGIA values ('D02',	N'Mai Thanh Phươn', '1983-12-19',	N'Bình Dương', 'yhv@gmail.com',	'DGL1',	'2017-07-16',	'177')
insert into DOCGIA values ('D03',	N'Đỗ Thanh', '1997-12-06',	N'Đà Nẵng',	'yqp@gmail.com', 'DGL1', '2017-06-14',	'177')
insert into DOCGIA values ('D04',	N'Phạm Quyên', '1999-02-12',	N'Thuận AN',	'pqq@gmail.com', 'DGL2', '2017-09-11',	'177')
insert into DOCGIA values ('D05',	N'Lê Kiên', '1981-03-12',	N'Phú Giáo',	'lil@gmail.com', 'DGL1', '2017-06-13',	'123')
insert into DOCGIA values ('D06',	N'Võ Đức', '1991-05-19',	N'TPHCM', 'vd@gmail.com', 'DGL1', '2017-07-11',	'123')
insert into DOCGIA values ('D07',	N'Mỹ Lệ', '1998-12-16',	N'Trà Vinh',	'ml@gmail.com',	'DGL2',	'2017-09-22',	'123')
insert into DOCGIA values ('D08',	N'Lê Hưng', '1999-11-20',	N'Bình Dương', 'lngh@gmail.com',	'DGl2',	'2017-06-12',	'184')
insert into DOCGIA values ('D09',	N'Vũ Hán', '1999-02-19',	N'TPHCM', 'vha@gmail.com', 'DGL2', '2017-08-19',	'184')
insert into DOCGIA values ('D10',	N'Tịnh Yên',	'1998-04-15',	N'Tân Uyên',	'ty@gmail.com',	'DGL2',	'2017-10-01',	'184')
go

insert into SACH values ('001',	N'Mẹ Ghẻ Con Ghẻ',	'L1',	N'Hồ Biểu Chánh',	'2011',	N'NXB Văn hóa - Nghệ thuật',	'2012-05-24',	'52000',	'133')
insert into SACH values ('002',	N'Gữi Những Năm Tháng Từng Bên',	'L2',	N'Decworm',	'2010',	N'NXB Thế giới',	'2011-08-04',	'60000',	'133')
insert into SACH values ('003',	N'Bức Thư Tỉnh Ủy',	'L1',	N'Vân Thảo',	'2013',	N'NXB Trẻ',	'2015-06-08',	'70000',	'159')
insert into SACH values ('004',	N'Cổ Tích Việt Nam Hay Nhất',	'L3',NULL,	'2011',	N'NXB Văn Học',	'2013-06-22',	'50000',	'333')
insert into SACH values ('005',	N'Cách Tân Nghệ Thuật Văn Học',	'L1',	N'Phùng Văn Tửu',	'2014',	N'NXB Văn học',	'2015-08-19',	'50000',	'159')
insert into SACH values ('006',	N'Tam Sinh Tâm Thế - Thập Lý Đào Hoa',	'L2',	N'Đường Thấp Công Tử',	'2012',	N'NXB Thế giới',	'2014-07-13',	'74000',	'133')
insert into SACH values ('007',	N'Tớ Là Mèo Pusheen',	'L3',	N'Claire Belton',	'2009',	N'NXB Trẻ',	'2013-10-12',	'80000',	'159')
insert into SACH values ('008',	N'Con Yêu Bố Chừng Nào',	'L3',	N'Sam McBratney',	'2012',	N'NXB Văn Học',	'2015-09-19',	'55000',	'333')
insert into SACH values ('009',	N'Bên Nhau Trọn Đời',	'L2',	N'Cố Mạn',	'2010',	N'NXB Văn Hóa - Nghệ Thuật',	'2014-06-17',	'75000',	'333')
insert into SACH values ('010',	N'Góc Nhìn Sử Việt',	'L1',	N'Hoàng Thị Thế',	'2013',	N'NXB Khoa Học Xã Hội',	'2015-12-18',	'65000',	'159')
insert into SACH values ('011',	N'Vì Vợ Là Vợ Anh',	'L2',	N'Lan Rùa', '2015',	N'NXB  Phụ nữ',	'2016-09-25',	'45000',	'133')
insert into SACH values ('012',	N'Chú Vịt Con Xấu Xí',	'L3',	N'Hans Chirstian Andersen',	'2010',	N'NXB Thiếu Nhi',	'2014-05-19',	'40000',	'159')
go

insert into MUONSACH values ('1',	'D08',	'2017-10-17')
insert into MUONSACH values ('2',	'D03',	'2017-06-22')
insert into MUONSACH values ('3',	'D02',	'2017-10-02')
insert into MUONSACH values ('4',	'D05',	'2017-07-01')
insert into MUONSACH values ('5',	'D09',	'2017-08-22')
insert into MUONSACH values ('6',	'D10',	'2017-10-05')
insert into MUONSACH values ('7',	'D03',	'2017-06-29')
insert into MUONSACH values ('8',	'D07',	'2017-09-22')
insert into MUONSACH values ('9',	'D04',	'2017-10-09')
insert into MUONSACH values ('10',	'D03',	'2017-07-12')
go

insert into THONGKEMUONSACH values ('1', '001')
insert into THONGKEMUONSACH values ('1', '002')
insert into THONGKEMUONSACH values ('1', '006')
insert into THONGKEMUONSACH values ('2', '001')
insert into THONGKEMUONSACH values ('2', '003')
insert into THONGKEMUONSACH values ('8', '008')
insert into THONGKEMUONSACH values ('6', '011')
insert into THONGKEMUONSACH values ('5','001')
insert into THONGKEMUONSACH values ('3','008')
insert into THONGKEMUONSACH values ('4', '004')
insert into THONGKEMUONSACH values ('9', '004')
insert into THONGKEMUONSACH values ('10', '002')
insert into THONGKEMUONSACH values ('7', '012')
insert into THONGKEMUONSACH values ('10', '005')
go

insert into CTMUONSACH values ('1', 'D08', '002', '2017-10-17', null)

go

create trigger QLDG 
on DOCGIA
for insert, update 
AS
begin
	begin tran tran1
	declare @ng date,@nl date, @tuoi int, @nvlap char(3)
	set @nl= (select NgayLap from inserted)
	set @ng = (select NgaySinh from inserted)
	set @tuoi = (DATEDIFF(yy,@ng,GETDATE()))
	set @nvlap =(select NVLap from inserted)
	if ( @tuoi >=18 and @tuoi<= 55 and exists(select * from NHANVIEN where BoPhan='BP1' and MaNV=@nvlap) and @nl<GETDATE() and @nl>@ng)
		 begin
			print 'thanh cong'
			commit tran tran1
		 end
	else 
	begin 
	print 'loi'
	rollback tran tran1
	end
end

go
create trigger QLSACH
on SACH
for insert, update
AS
begin
	begin tran tran1
	declare @namxb int, @th int, @nn int
	set @nn = (select year(NgayNhap) from inserted)
	set @namxb =(select NamXB from inserted)
	set @th = YEAR(getdate())-@namxb
	if (@th<=8  and exists (select MaNV from inserted, NHANVIEN where BoPhan='BP2' and NVTiepNhan=MaNV) and @nn>=@namxb)
		commit tran tran1
	else rollback tran tran1
end

go
create trigger QLMS
on MUONSACH 
for insert, update
AS
begin
	begin tran tran1
	declare @ngaylapthe date = (select NgayLap from DOCGIA, inserted where DOCGIA.MaDG= inserted.MADG)
	declare @hanmuon int = datediff(dd,@ngaylapthe, getdate())
	declare @MaDG char(3) = (select MADG from inserted)
	declare @nm date = (select NGAYMUON from inserted)
	declare @nl date = (select NgayLap from inserted, DOCGIA where inserted.MaDG=DOCGIA.MaDG)
	declare @mapn int =(select MaPhieuMuon from inserted)
	if(@nl>@nm or @hanmuon>183 or @nm>GETDATE() or exists (select SachMuon from CTMUONSACH a, inserted b where  a.MaDG=b.MADG and getdate()-a.NgayMuon >4)
		or (select COUNT(*) from CTMUONSACH where MaDG=@madg group by MaDG)>=5)
		begin
		print 'loi'
		rollback tran tran1
		end
	else commit tran tran1
end
go

create trigger QLCTMS
on THONGKEMUONSACH
for insert, update
AS
begin
	begin tran tran1
	declare @ma char(3) = (select MaSach from inserted)
	declare @madg char(3) = (select MADG from MUONSACH, inserted where MaPM=MaPhieuMuon)

	if( (select COUNT(*) from  CTMUONSACH where SachMuon= @ma)>1)
	begin
		print 'loi'
		rollback tran tran1
	end
	else commit tran tran1	
end
go

create trigger QLCTMS2
on CTMUONSACH
for insert, update 
AS
begin
	begin tran tran1
	declare @ngaylapthe date = (select NgayLap from DOCGIA, inserted where DOCGIA.MaDG= inserted.MADG)
	declare @ma char(3) = (select SachMuon from inserted)
	declare @nm date = (select NGAYMUON from inserted)
	declare @madg char(3) = (select inserted.MaDG from MUONSACH, inserted where MaPM=MaPhieuMuon)
	declare @nlpm date = (select MUONSACH.NGAYMUON from MUONSACH,inserted where MaPhieuMuon=MaPM)
	declare @mapm int =(select MaPM from inserted)

	if (datediff(dd,@nm, GETDATE())>4)
		update CTMUONSACH set Han=N'Quá Hạn' from inserted b where CTMUONSACH.MaDG=b.MaDG and CTMUONSACH.MaPM=b.MaPM and CTMUONSACH.MaPM=b.MaPM and CTMUONSACH.SachMuon=b.SachMuon
	else update CTMUONSACH set Han=N'Còn Hạn' from inserted b where CTMUONSACH.MaDG=b.MaDG and CTMUONSACH.MaPM=b.MaPM and CTMUONSACH.MaPM=b.MaPM and CTMUONSACH.SachMuon=b.SachMuon
	
	if((select COUNT(*) from CTMUONSACH where SachMuon= @ma)>2 or (select COUNT(*) from CTMUONSACH where MaDG=@madg group by MaDG)>5
		or @nlpm!=@nm or not exists (select * from THONGKEMUONSACH where MaPM=@mapm) 
		or not exists (select * from THONGKEMUONSACH where MaPM=@mapm and MaSach=@ma))
	begin
		print 'loi'
		rollback tran tran1
	end
	else commit tran tran1
END

SELECT COUNT(*) FROM NHANVIEN WHERE Account ='lethihoa' AND Pass ='12345'
UPDATE dbo.NHANVIEN SET Pass ='123456' WHERE Account=''