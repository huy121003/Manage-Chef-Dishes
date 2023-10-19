INSERT INTO sinhvien (masv, hoten, ngaysinh)
VALUES ('SV001', 'Nguyễn Văn A', '2000-01-15'),
       ('SV002', 'Trần Thị B', '2001-03-20'),
       ('SV003', 'Lê Văn C', '1999-07-10');

insert into tLoai(MaLoai,TenLoai)
values('L01','Khai vị'),
	  ('L03','Tráng miệng'),
	  ('L04','Thịt'),
	  ('L05','Súp'),
	  ('L06','Canh'),
	  ('L07','Xào'),
	  ('L08','Chiên'),
	  ('L09','Luộc'),
	  ('L10','Hấp'),
	  ('L11','Nướng');
	  
select * from tLoai

insert into tCongDung(MaCongDung,TenCongDung)
values('CD01','Bổ sung Chất khoáng'),
	  ('CD02','Bổ sung Vitamin A'),
	  ('CD03','Bổ sung Vitamin B'),
	  ('CD04','Bổ sung Vitamin C'),
	  ('CD05','Bổ sung Vitamin D'),
	  ('CD06','Bổ sung Vitamin E'),
	  ('CD07','Bổ sung sắt'),
	  ('CD09','Bổ sung chất béo'),
	  ('CD010','Giải nhiệt'),
	  ('CD011','Bổ sung chất xơ');

INSERT INTO tNoiHoc (MaNoiHoc, TenNoiHoc)
VALUES ('NH01', 'Trường Đại học Sư phạm Kỹ thuật TPHCM (HUTECH)' ),
       ('NH02', 'Học viện Nghề ẩm thực Escoffier Vietnam' ),
       ('NH03', 'Trường Đại học Nông Lâm TP.HCM (NLU)' ),
	   ('NH04', 'Học viện Nghề bếp Quốc tế WhiteHat'),
	   ('NH05', 'Trung tâm Nghề nghiệp quốc tế - IHCC Vietnam'),
	   ('NH06', 'Trung tâm đào tạo Đầu bếp Bếp Á Châu'),
	   ('NH07', 'Học viện ẩm thực Le Cordon Bleu - Dusit'),
	   ('NH08', 'Trung tâm đào tạo nghề TPHCM (Vocational College in Ho Chi Minh City) '),
	   ('NH09', 'Học viện Kỹ thuật Mở FPT Polytechnic'),
	   ('NH10', 'Viện đào tạo nghề ẩm thực - Sài Gòn Professional Chef School (SGPCS)');
select * from tNoiHoc

INSERT INTO tDonViTinh (MaDonVi, TenDonViTinh)
VALUES ('DVT01','kg'),
       ('DVT02','g'),
	   ('DVT03','củ'),
	   ('DVT04','quả'),
	   ('DVT05','thìa'),
	   ('DVT06','l'),
	   ('DVT07','ml');
select * from tDonViTinh	  

INSERT INTO tXepLoai(MaXepLoai, TenXepLoai)
VALUES ('XL01','1 sao'),
       ('XL02','2 sao'),
	   ('XL03','3 sao'),
	   ('XL04','4 sao'),
	   ('XL05','5 sao');
select * from tXepLoai	 

INSERT INTO tTrinhDo(MaTrinhDo, TenTrinhDo)
VALUES ('TD01','Commis Chef (Cấp bậc mới bắt đầu)'),
       ('TD02','Chef de Partie (Phụ trách một phần công việc)'),
	   ('TD03','Sous Chef (Phụ bếp trưởng)'),
	   ('TD04','Executive Chef (Đầu bếp chính)'),
	   ('TD05','Chef de Cuisine (Đầu bếp chủ nhiệm)'),
	   ('TD06','Corporate Chef (Đầu bếp chính quản lý)');

	  
insert into tKhachHang(MaKhachHang,TenKhachHang,DiaChi,SoDienThoai)
values('KH01','Nguyễn Thị Thương','79 Đường cầu giấy,quận Cầu giấy,Hà Nội','0343310166'),
	  ('KH02','Phạm Thị Mai','69 Đường Nguyễn Phong Sắc,quận Cầu giấy,Hà Nội','0928173281'),
	  ('KH03','Nguyễn Xuân Trường','32 Đường Khương Trung,quận Cầu giấy,Hà Nội','0923473281'),
	  ('KH04','Bùi Thị Yến Nhi','132 Đường Cầu giấy, quận Cầu giấy,Hà Nội','03672238871'),
	  ('KH05','Nguyễn Thị Hoài Thương','12 Đường Phạm Văn Đồng,quận Nam Từ Liêm,Hà Nội','0334458821'),
	  ('KH06','Lê Thị Thảo','45 Đường Phạm Văn Đồng,quận Nam Từ Liêm,Hà Nội','0978298821'),
	  ('KH07','Bùi Thị Minh Trang','79 Đường Tố Hữu,quận Nam Từ Liêm,Hà Nội','0328722778'),
	  ('KH08','Phạm Như Lộc','22 Đường Lê Văn Lương,quận Nam Từ Liêm,Hà Nội','0337778212'),
	  ('KH09','Nguyễn Thị Thảo','32 Đường Lê Văn Lương,quận Nam Từ Liêm,Hà Nội','0379983728'),
	  ('KH10','Đỗ Thị Mỹ Linh','49 Đường Nguyễn Cơ Thạch,quận Nam Từ Liêm,Hà Nội','0334827366'),
	  ('KH11','Nguyễn Văn Nam','112 Đường Hòang Minh Giám,quận Nam Từ Liêm,Hà Nội','0923883992'),
	  ('KH12','Phạm Mai Ninh','12 Đường Phạm Văn Đồng,quận Nam Từ Liêm,Hà Nội','0983377182'),
	  ('KH13','Mai Thị Hoa','182 Đường Hoàng Diệu,quận Ba Đình,Hà Nội','0388873672'),
	  ('KH14','Hoàng Thị Hải Yến','72 Đường Hoàng Diệu,quận Ba Đình,Hà Nội','0911828341'),
	  ('KH15','Hoàng Văn Thái','133 Đường Hoàng Diệu,quận Ba Đình,Hà Nội','0922837112'),
	  ('KH16','Hoàng Như Ngọc','102 Đường Âu Cơ,quận Tây Hồ,Hà Nội','0371947228'),
	  ('KH17','Nguyễn Ngọc Linh','91 Đường Xuân Diệu, quận Tây Hồ ,Hà Nội','0398291020'),
	  ('KH18','Mai Thị Yến Linh','112 Đường Yên Phụ, quận Tây Hồ,Hà Nội','0300189291'),
	  ('KH19','Đào Huyền Trang','32 Đường Nguyễn Trãi, quận Thanh Xuân,Hà Nội','0318274883'),
	  ('KH20','Lê Mai Trang','72 Đường Lê Văn Lương,Quận Thanh Xuân,Hà Nội','0387362818');


