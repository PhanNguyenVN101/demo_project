create database DEMO_TUAN02
go
use DEMO_TUAN02
go
create table SinhVien
(
	MaSV varchar(10) primary key,
	HoTen nvarchar(20),
	Phai nvarchar(20),
	SDT varchar(10),
)

insert into SinhVien
values
('SV01',N'Phan Minh Kỳ',N'Nam','0459025341'),
('SV02',N'Nguyễn Hải Tân',N'Nam','0729785341'),
('SV03',N'Đỗ Thị Ngọc',N'Nữ','0651025841'),
('SV04',N'Hàn Quốc Minh',N'Nam','0151125041'),
('SV05',N'Lý Thị Lan',N'Nữ','0922028741')

select * from SinhVien