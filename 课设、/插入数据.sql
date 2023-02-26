USE MedicalSystem;
insert into tb_Doctors
(DoctorName,password,gender,level,officeid,RegisterTypeNo)
values
('小蔡',HASHBYTES('MD5','123456'),'1','副主任医师','1','1')
,('小元',HASHBYTES('MD5','123456'),'1','主任医师','2','1');
INSERT INTO tb_OFFICE
(OFFICENAME,OFFICETYPEID)
VALUES
('呼吸内科','1')
,('神经外科','2');
INSERT INTO tb_OFFICETYPE
(OFFICETYPENAME)
VALUES
('内科')
,('外科')
,('妇产科')
,('儿科')
,('五官科')
,('肿瘤科')
,('医学影像科')
,('麻醉医学科')
,('其他科');

INSERT INTO tb_PAYTYPE
(PAYTYPENAME)
VALUES
('全自费')
,('医保');


INSERT INTO tb_NATIONALITY
(NATIONALITY)
VALUES
('中国')
,('日本')
,('韩国')
,('美国')
,('法国')
,('英国')
,('瑞典');

INSERT INTO tb_PROVINCE
(PROVINCEID,PROVINCENAME)
VALUES
('1','北京市')
,('2','上海市')
,('3','浙江省')
,('4','福建省')
,('6','广东省')
,('7','天津市')
,('8','江苏省')
,('9','湖北省')
,('10','湖南省')
,('11','重庆市');

INSERT INTO tb_CITY
(PROVINCEID,CITYNAME)
VALUES
('1','北京市')
,('2','上海市')
,('3','杭州市')
,('3','湖州市')
,('3','嘉兴市')
,('3','金华市')
,('3','丽水市')
,('3','宁波市')
,('3','绍兴市')
,('3','台州市')
,('3','温州市')
,('4','福州市')
,('4','龙岩市')
,('4','南平市')
,('4','宁德市')
,('4','莆田市')
,('4','泉州市')
,('4','三明市')
,('4','厦门市')
,('4','漳州市')
,('6','惠州市')
,('6','佛山市')
,('6','广州市')
,('6','东莞市')
,('6','汕头市')
,('6','韶关市')
,('6','深圳市')
,('6','阳江市')
,('6','云浮市')
,('6','湛江市')
,('6','中山市')
,('6','珠海市')
,('7','天津市')
,('8','淮安市')
,('8','常州市')
,('8','南通市')
,('8','南京市')
,('8','宿迁市')
,('8','苏州市')
,('8','泰州市')
,('8','无锡市')
,('8','徐州市')
,('8','盐城市')
,('8','扬州市')
,('8','镇江市')
,('9','黄石市')
,('9','黄冈市')
,('9','鄂州市')
,('9','随州市')
,('9','天门市')
,('9','武汉市')
,('9','咸宁市')
,('9','襄阳市')
,('9','孝感市')
,('9','宜昌市')
,('10','益阳市')
,('10','常德市')
,('10','长沙市')
,('10','衡阳市')
,('10','怀化市')
,('10','邵阳市')
,('10','娄底市')
,('10','湘潭市')
,('10','岳阳市')
,('10','张家界市')
,('10','株洲市')
,('11','重庆市');

INSERT INTO tb_MARRYSITUATION
(MARRYSITUATION)
VALUES
('离婚')
,('已婚')
,('未婚');


--INSERT INTO tb_PAYTYPE
--(PAYTYPENAME)
--VALUES
--('医保')
--,('自费');

INSERT INTO tb_RegisterType
(RegisterTypeNo,RegisterTypeName,PRICE)
VALUES
(1,'专家号',100),
(2,'普通挂号',30);

INSERT INTO  tb_ProjectCategory
(ProjectCategoryNo ,ProjectCategory)
VALUES
(1,'辅助检查分类');

INSERT INTO  tb_Category
(CategoryNo ,Category,ProjectCategoryNo)
VALUES
(1,'检验',1)
,(2,'B超',1)
,(3,'心电图',1)
,(4,'X光片',1)
;
INSERT INTO  tb_Category
(CategoryNo ,Category,ProjectCategoryNo)
VALUES
(5,'彩超',1)
INSERT INTO  tb_List
(ListNo ,List,CategoryNo)
VALUES
(1,'血常规',1)
,(2,'尿常规',1)
,(3,'B超',2)
,(4,'心电图',3)
,(5,'X光片',4)
,(6,'彩超',5);

INSERT INTO  tb_Content
(ContentNo ,Content,ListNo)
VALUES
(1,'尿毒症检查',2)
,(2,'尿路不畅检查',2)
,(3,'腹部B超',3)
,(4,'泌尿系统B超',3)
,(5,'体表肿物及变',3)
,(6,'常规心电图',4)
,(7,'动态心电图',4)
,(8,'运动平板心电图',4)
,(9,'甲状腺超声',6)
,(10,'前列腺超声',6)
,(11,'肝胆脾肾超声',6);
INSERT INTO  tb_Content
(ContentNo ,Content,ListNo)
VALUES
(12,'血常规',1);


INSERT INTO tb_DrugsCategory
(DrugsCategoryNo,NAME)
VALUES
(1,'中药')
,(2,'西药')
,(3,'外用药物');

BULK INSERT tb_Drugs
	FROM 'E:\医学数据库\Medicine.csv'
	WITH
		(FIELDTERMINATOR=','
		,ROWTERMINATOR='\n'
		,FIRSTROW=2);

		INSERT INTO tb_Per
		(PerNo,Name)
		VALUES
		(1,'克')
		,(2,'丸')
		,(3,'片')
		,(4,'支')
		,(5,'袋')
		,(6,'ml');