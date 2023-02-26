IF DB_ID('MedicalSystem') IS NOT NULL
   DROP DATABASE MedicalSystem;
    CREATE DATABASE MedicalSystem
      ON
        (NAME='DataFile_1'
          ,FILENAME='C:\医学数据库\DataFile_1.mdf')
      LOG ON
     (NAME='LogFile_1'
     ,FILENAME='C:\医学数据库\LogFile_1.ldf');
USE MedicalSystem;
IF OBJECT_ID('tb_OFFICETYPE') IS NOT NULL         
  DROP TABLE tb_OFFICETYPE;   
GO
CREATE TABLE tb_OFFICETYPE
	(OFFICETYPEID
		int identity(1,1)
		NOT NULL
		--CONSTRAINT pk_OFFICETYPE_OFFICETYPEID
		--PRIMARY KEY(OFFICETYPEID)
	,OFFICETYPENAME
	VARCHAR(100)
	NOT NULL);
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
IF OBJECT_ID('tb_OFFICE') IS NOT NULL         
  DROP TABLE tb_OFFICE;   
GO
CREATE TABLE tb_OFFICE
	(OFFICEID
		int identity(1,1)
		NOT NULL
		--CONSTRAINT pk_OFFICE_OFFICEID
		--PRIMARY KEY(OFFICEID)
	,OFFICENAME
	VARCHAR(100)
	NOT NULL
	,OFFICETYPEID
	 int 
	NOT NULL
	 --CONSTRAINT fk_OFFICE_OFFICETYPEID
		--	 FOREIGN KEY(OFFICETYPEID)
		--	 REFERENCES tb_OFFICETYPE(OFFICETYPEID)
		--	 ON DELETE CASCADE
		--     ON UPDATE CASCADE
	);
	INSERT INTO tb_OFFICE
(OFFICENAME,OFFICETYPEID)
VALUES
('呼吸内科','1')
,('神经外科','2');
IF OBJECT_ID('tb_Doctors') IS NOT NULL      
  DROP TABLE tb_Doctors;      
GO
CREATE TABLE tb_Doctors
	(DoctorID
		int identity(1,1)
		NOT NULL
		--CONSTRAINT pk_Doctors_DoctorID
		--	PRIMARY KEY(DoctorID)
	,DoctorName
		VARCHAR(100)
		NOT NULL
	,password
	    VARCHAR(100)
		NOT NULL
	,Gender
	bit
	NOT NULL
	,LEVEL
	 VARCHAR(100)
	 NOT NULL
	 ,OFFICEID
	 INT
	 NOT NULL
	 --CONSTRAINT fk_Doctors_OFFICEID
		--	 FOREIGN KEY(OFFICEID)
		--	 REFERENCES tb_OFFICE(OFFICEID)
		--	 ON DELETE CASCADE
		--     ON UPDATE CASCADE
	,RegisterTypeNo
	int
		NOT NULL
    -- CONSTRAINT fk_Doctors_RegisterTypeNo
			 --FOREIGN KEY(RegisterTypeNo)
			 --REFERENCES tb_RegisterType(RegisterTypeNo)
			 --ON DELETE CASCADE
		  --   ON UPDATE CASCADE
	);
	insert into tb_Doctors
(DoctorName,password,gender,level,officeid,RegisterTypeNo)
values
('小蔡',HASHBYTES('MD5','123456'),'1','副主任医师','1','1')
,('小元',HASHBYTES('MD5','123456'),'1','主任医师','2','1');
	
	IF OBJECT_ID('tb_PATIENTINFOR') IS NOT NULL         
  DROP TABLE tb_PATIENTINFOR;   
GO
CREATE TABLE tb_PATIENTINFOR
	(MedicalCardId
		bigint identity(31907001,1)
		NOT NULL
		--CONSTRAINT pk_PATIENTINFOR_MedicalCardId
		--PRIMARY KEY(MedicalCardId)
	,PatientNAME
	VARCHAR(100)
	NOT NULL
	,pinying
	VARCHAR(200)
	NOT NULL
	,GENDER
	BIT
	NOT NULL
	,BIRTHDATE
	DATETIME
	NOT NULL
	,AGE
	INT 
	NOT NULL
	,NATIONALITY
	VARCHAR(100)
	NOT NULL
	,PROVINCE
	VARCHAR(100)
	NOT NULL
	,CITY
	VARCHAR(100)
	NOT NULL
	,ADDRESS
	VARCHAR(200)
	NOT NULL
	,TEL
	VARCHAR(11)
	NOT NULL
	,IDCARD
	VARCHAR(40)
	NOT NULL
	,PAYTYPE
	VARCHAR(100)
	NOT NULL
	,MARRYSITUATION
	VARCHAR(20)
	NOT NULL
	,registerTime
	datetime
	not null);


	IF OBJECT_ID('tb_PAYTYPE') IS NOT NULL         
  DROP TABLE tb_PAYTYPE;   
GO
CREATE TABLE tb_PAYTYPE
	(PAYTYPENO
	 int identity(1,1)
		NOT NULL
		--CONSTRAINT pk_PAYTYPE_PAYTYPENO
		--PRIMARY KEY(PAYTYPENO)
		,PAYTYPENAME
		VARCHAR(100)
		NOT NULL
		);
		
INSERT INTO tb_PAYTYPE
(PAYTYPENAME)
VALUES
('全自费')
,('医保');

		IF OBJECT_ID('tb_NATIONALITY') IS NOT NULL         
  DROP TABLE tb_NATIONALITY;   
GO
CREATE TABLE tb_NATIONALITY
	(NATIONALITY
	 VARCHAR(100)
		NOT NULL
		--CONSTRAINT pk_NATIONALITY_NATIONALITY
		--PRIMARY KEY(NATIONALITY)
		);
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

		IF OBJECT_ID('tb_PROVINCE') IS NOT NULL         
  DROP TABLE tb_PROVINCE;   
GO
CREATE TABLE tb_PROVINCE
	(PROVINCEID
	 VARCHAR(100)
		NOT NULL
		--CONSTRAINT pk_PROVINCE_PROVINCEID
		--PRIMARY KEY(PROVINCEID)
		,PROVINCENAME
	 VARCHAR(100)
		NOT NULL);
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
		IF OBJECT_ID('tb_CITY') IS NOT NULL         
  DROP TABLE tb_CITY;   
GO
CREATE TABLE tb_CITY
	(PROVINCEID
	 VARCHAR(100)
		NOT NULL
		,CITYNAME
	 VARCHAR(100)
		NOT NULL
		--CONSTRAINT pk_CITY_CITYNAME
		--PRIMARY KEY(CITYNAME)
		);
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



		IF OBJECT_ID('tb_MARRYSITUATION') IS NOT NULL         
  DROP TABLE tb_MARRYSITUATION;   
GO
CREATE TABLE tb_MARRYSITUATION
	(MARRYSITUATION
	 VARCHAR(100)
		NOT NULL
		--CONSTRAINT pk_MARRYSITUATION_MARRYSITUATION
		--PRIMARY KEY(MARRYSITUATION)
		);
		INSERT INTO tb_MARRYSITUATION
(MARRYSITUATION)
VALUES
('离婚')
,('已婚')
,('未婚');

		IF OBJECT_ID('tb_RegisterType') IS NOT NULL         
  DROP TABLE tb_RegisterType;   
GO
CREATE TABLE tb_RegisterType
	(RegisterTypeNo
	 int
		NOT NULL
		--CONSTRAINT pk_RegisterType_RegisterTypeNo
		--PRIMARY KEY(RegisterTypeNo)
		,RegisterTypeName
	   VARCHAR(100)
		NOT NULL
		,PRICE
		float
		NOT NULL);
		
INSERT INTO tb_RegisterType
(RegisterTypeNo,RegisterTypeName,PRICE)
VALUES
(1,'专家号',100),
(2,'普通挂号',30);
		
		IF OBJECT_ID('tb_Register') IS NOT NULL         
  DROP TABLE tb_Register;   
GO
CREATE TABLE tb_Register
	(RegisterNo
	  bigint identity(1,1)
		NOT NULL
		--CONSTRAINT pk_Register_RegisterNo
		--PRIMARY KEY(RegisterNo)
		,PatientNAME
	 VARCHAR(100)
	NOT NULL
	,MedicalCardId
		bigint 
		NOT NULL
		--CONSTRAINT fk_Register_MedicalCardId
		--	 FOREIGN KEY(MedicalCardId)
		--	 REFERENCES tb_PATIENTINFOR(MedicalCardId)
		--	 ON DELETE CASCADE
		--     ON UPDATE CASCADE
	,OFFICEID
		int 
		NOT NULL
		--CONSTRAINT fk_Register_OFFICEID
		--	 FOREIGN KEY(OFFICEID)
		--	 REFERENCES tb_OFFICE(OFFICEID)
		--	 ON DELETE CASCADE
		--     ON UPDATE CASCADE
		,
		RegisterTypeNo
	VARCHAR(20)
		NOT NULL
		,DoctorName
		VARCHAR(100)
		NOT NULL,
		PRICE
		float
		NOT NULL
		,registerTime
		DATE
		NOT NULL
		,ISCHECKED
		BIT default(0)
		NOT NULL);
		IF OBJECT_ID('tb_MedicalRecord') IS NOT NULL         
  DROP TABLE tb_MedicalRecord;   
GO
CREATE TABLE tb_MedicalRecord
	(MedicalRecordNO
	 int identity(1,1)
		NOT NULL
		--CONSTRAINT pk_MedicalRecord_MedicalRecordNO
		--PRIMARY KEY(MedicalRecordNO)
		,
		MedicalCardId
		bigint 
		NOT NULL
		--CONSTRAINT fk_MedicalCardId
		--	 FOREIGN KEY(MedicalCardId)
		--	 REFERENCES tb_PATIENTINFOR(MedicalCardId)
		--	 ON DELETE CASCADE
		--     ON UPDATE CASCADE
	    ,
	    DoctorName
		VARCHAR(100)
		NOT NULL
		,RecordOFFICE
		VARCHAR(100)
		NOT NULL
		,
		RecordTime
		DATETIME
		NOT NULL
		,ChiefComplaint
		NVARCHAR(max)
		NOT NULL
		,PresentIllness
		NVARCHAR(max)
		NOT NULL
		,historicaldisease
		NVARCHAR(max)
		NOT NULL
		,Allergic
		NVARCHAR(max)
		NOT NULL
		,examinePhysique
		NVARCHAR(max)
		NOT NULL
		,primarydiognosis
		NVARCHAR(max)
		NOT NULL
		,DealOpinion
		NVARCHAR(max)
		NOT NULL
		);


		IF OBJECT_ID('tb_ProjectCategory') IS NOT NULL         
  DROP TABLE tb_ProjectCategory;   
GO
CREATE TABLE tb_ProjectCategory
	(ProjectCategoryNo
	 int
		NOT NULL
		--CONSTRAINT pk_ProjectCategory_ProjectCategoryNo
		--PRIMARY KEY(ProjectCategoryNo)
		,
		ProjectCategory
		varchar(20)
		NOT NULL
	   );
	   INSERT INTO  tb_ProjectCategory
(ProjectCategoryNo ,ProjectCategory)
VALUES
(1,'辅助检查分类');

	   IF OBJECT_ID('tb_Category') IS NOT NULL         
  DROP TABLE tb_Category;   
GO
CREATE TABLE tb_Category
	(CategoryNo
	 int
		NOT NULL
		--CONSTRAINT pk_Category_CategoryNo
		--PRIMARY KEY(CategoryNo)
		,
		Category
		varchar(100)
		NOT NULL
		,ProjectCategoryNo
		int
		NOT NULL
		--CONSTRAINT fk_ProjectCategoryNo
		--	 FOREIGN KEY(ProjectCategoryNo)
		--	 REFERENCES tb_ProjectCategory(ProjectCategoryNo)
		--	 ON DELETE CASCADE
		--     ON UPDATE CASCADE
	   );
	   INSERT INTO  tb_Category
(CategoryNo ,Category,ProjectCategoryNo)
VALUES
(1,'检验',1)
,(2,'B超',1)
,(3,'心电图',1)
,(4,'X光片',1)

	   IF OBJECT_ID('tb_List') IS NOT NULL         
  DROP TABLE tb_List;   
GO
CREATE TABLE tb_List
	(ListNo
	 int
		NOT NULL
		--CONSTRAINT pk_List_ListNo
		--PRIMARY KEY(ListNo)
		,
		List
		varchar(100)
		NOT NULL
		,CategoryNo
		int
		NOT NULL
		--CONSTRAINT fk_CategoryNo
		--	 FOREIGN KEY(CategoryNo)
		--	 REFERENCES tb_Category(CategoryNo)
		--	 ON DELETE CASCADE
		--     ON UPDATE CASCADE
			 );
			 INSERT INTO  tb_List
(ListNo ,List,CategoryNo)
VALUES
(1,'血常规',1)
,(2,'尿常规',1)
,(3,'B超',2)
,(4,'心电图',3)
,(5,'X光片',4)
,(6,'彩超',5);

			 IF OBJECT_ID('tb_Content') IS NOT NULL         
  DROP TABLE tb_Content;   
GO
CREATE TABLE tb_Content
	(ContentNo
	 int
		NOT NULL
		--CONSTRAINT pk_Content_ContentNo
		--PRIMARY KEY(ContentNo)
		,
		Content
		varchar(100)
		NOT NULL
		,ListNo
		int
		NOT NULL
		--CONSTRAINT fk_ListNo
		--	 FOREIGN KEY(ListNo)
		--	 REFERENCES tb_List(ListNo)
		--	 ON DELETE CASCADE
		--     ON UPDATE CASCADE
			 );
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





			  IF OBJECT_ID('tb_AuxiliaryExamination') IS NOT NULL         
  DROP TABLE tb_AuxiliaryExamination;   
GO
CREATE TABLE tb_AuxiliaryExamination
	(AuxiliaryExaminationNo
	 int identity(1,1)
		NOT NULL
		--CONSTRAINT pk_AuxiliaryExamination_AuxiliaryExaminationNo
		--PRIMARY KEY(AuxiliaryExaminationNo)
		,
		MedicalCardId
		bigint 
		NOT NULL
		--CONSTRAINT fk_ExamMedicalCardId
		--	 FOREIGN KEY(MedicalCardId)
		--	 REFERENCES tb_PATIENTINFOR(MedicalCardId)
		--	 ON DELETE CASCADE
		--     ON UPDATE CASCADE
		,Content
		varchar(100)
		NOT NULL
		,billingDate
		DATE
		NOT NULL
		,BILLINGDOCTOR
		VARCHAR(100)
		NOT NULL
		,BILLINGOFFICE
		VARCHAR(100)
		NOT NULL
		,CHECKOFFICEID
		int
		NOT NULL
		--CONSTRAINT fk_CHECKOFFICEID
		--	 FOREIGN KEY(CHECKOFFICEID)
		--	 REFERENCES tb_OFFICE(OFFICEID)
		--	 ON DELETE CASCADE
		--     ON UPDATE CASCADE
	    ,ChiefComplaint
		NVARCHAR(max)
		NOT NULL
		,PresentIllness
		NVARCHAR(max)
		NOT NULL
		,CHECKPURPOSE
		NVARCHAR(max)
		NOT NULL
		,ISPAID
		BIT default(0)
		NOT NULL
		);
		IF OBJECT_ID('tb_DrugsCategory') IS NOT NULL         
  DROP TABLE tb_DrugsCategory;   
GO
CREATE TABLE tb_DrugsCategory
	(DrugsCategoryNo
	 int
		NOT NULL
		--CONSTRAINT pk_DrugsCategory_DrugsCategoryNo
		--PRIMARY KEY(DrugsCategoryNo)
		,
		NAME
		varchar(100) 
		NOT NULL);
		INSERT INTO tb_DrugsCategory
(DrugsCategoryNo,NAME)
VALUES
(1,'中药')
,(2,'西药')
,(3,'外用药物');
		IF OBJECT_ID('tb_Drugs') IS NOT NULL         
  DROP TABLE tb_Drugs;   
GO
CREATE TABLE tb_Drugs
	(PreMeNo
	 int
		NOT NULL
		--CONSTRAINT pk_Drugs_PreMeNo
		--PRIMARY KEY(PreMeNo)
		,
		MeNAME
		varchar(100) 
		NOT NULL
		,PinYin
		varchar(100)
		NOT NULL
		,CaNo
		int
		--CONSTRAINT fk_CaNo
		--	 FOREIGN KEY(CaNo)
		--	 REFERENCES tb_DrugsCategory(DrugsCategoryNo)
		--	 ON DELETE CASCADE
		--     ON UPDATE CASCADE
	    ,MePrice
		INT
		NOT NULL
		,MedicationMode
		NVARCHAR(100)
		NOT NULL
		,EachDose
		NVARCHAR(100)
		NOT NULL
		,Frequency
		NVARCHAR(100)
		NOT NULL
		);

		IF OBJECT_ID('tb_Per') IS NOT NULL         
  DROP TABLE tb_Per;   
GO
CREATE TABLE tb_Per
	(PerNo
	 int
		NOT NULL
		--CONSTRAINT pk_tb_Per_PerNo
		--PRIMARY KEY(PerNo)
		,Name
	   varchar(50)
	   NOT NULL);
	   		INSERT INTO tb_Per
		(PerNo,Name)
		VALUES
		(1,'克')
		,(2,'丸')
		,(3,'片')
		,(4,'支')
		,(5,'袋')
		,(6,'ml');

	   IF OBJECT_ID('tb_Prescription') IS NOT NULL         
  DROP TABLE tb_Prescription;   
GO
CREATE TABLE tb_Prescription
	(PrescriptionNo
	 int identity(1,1)
		NOT NULL
		--CONSTRAINT pk_tb_Prescription_PrescriptionNo
		--PRIMARY KEY(PrescriptionNo)
		,MeNAME
		varchar(100) 
		NOT NULL
	    ,MePrice
		INT
		NOT NULL
		,MedicationMode
		NVARCHAR(100)
		NOT NULL
		,
		MedicalCardId
		bigint 
		NOT NULL
	    ,EachDose
		varchar(10)
		NOT NULL
		,EachdosePer
		int
		NOT NULL
		--CONSTRAINT fk_EachdosePer
		--	 FOREIGN KEY(EachdosePer)
		--	 REFERENCES tb_Per(PerNo)
		--	 ON DELETE CASCADE
		--     ON UPDATE CASCADE
        ,Frequency
		varchar(100)
		not null
		,totalprice
		int
		not null);


			   IF OBJECT_ID('tb_PresDrugs') IS NOT NULL         
  DROP TABLE tb_PresDrugs;   
GO
CREATE TABLE tb_PresDrugs
	(
		MeNAME
		varchar(100) 
		NOT NULL
	    ,MePrice
		INT
		NOT NULL
		,MedicationMode
		NVARCHAR(100)
		NOT NULL
		,Frequency
		varchar(100)
		not null
	);