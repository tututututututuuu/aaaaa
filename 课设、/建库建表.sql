IF DB_ID('MedicalSystem') IS NOT NULL
   DROP DATABASE MedicalSystem;
    CREATE DATABASE MedicalSystem
      ON
        (NAME='DataFile_1'
          ,FILENAME='C:\ҽѧ���ݿ�\DataFile_1.mdf')
      LOG ON
     (NAME='LogFile_1'
     ,FILENAME='C:\ҽѧ���ݿ�\LogFile_1.ldf');
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
('�ڿ�')
,('���')
,('������')
,('����')
,('��ٿ�')
,('������')
,('ҽѧӰ���')
,('����ҽѧ��')
,('������');
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
('�����ڿ�','1')
,('�����','2');
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
('С��',HASHBYTES('MD5','123456'),'1','������ҽʦ','1','1')
,('СԪ',HASHBYTES('MD5','123456'),'1','����ҽʦ','2','1');
	
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
('ȫ�Է�')
,('ҽ��');

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
('�й�')
,('�ձ�')
,('����')
,('����')
,('����')
,('Ӣ��')
,('���');

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
('1','������')
,('2','�Ϻ���')
,('3','�㽭ʡ')
,('4','����ʡ')
,('6','�㶫ʡ')
,('7','�����')
,('8','����ʡ')
,('9','����ʡ')
,('10','����ʡ')
,('11','������');
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
('1','������')
,('2','�Ϻ���')
,('3','������')
,('3','������')
,('3','������')
,('3','����')
,('3','��ˮ��')
,('3','������')
,('3','������')
,('3','̨����')
,('3','������')
,('4','������')
,('4','������')
,('4','��ƽ��')
,('4','������')
,('4','������')
,('4','Ȫ����')
,('4','������')
,('4','������')
,('4','������')
,('6','������')
,('6','��ɽ��')
,('6','������')
,('6','��ݸ��')
,('6','��ͷ��')
,('6','�ع���')
,('6','������')
,('6','������')
,('6','�Ƹ���')
,('6','տ����')
,('6','��ɽ��')
,('6','�麣��')
,('7','�����')
,('8','������')
,('8','������')
,('8','��ͨ��')
,('8','�Ͼ���')
,('8','��Ǩ��')
,('8','������')
,('8','̩����')
,('8','������')
,('8','������')
,('8','�γ���')
,('8','������')
,('8','����')
,('9','��ʯ��')
,('9','�Ƹ���')
,('9','������')
,('9','������')
,('9','������')
,('9','�人��')
,('9','������')
,('9','������')
,('9','Т����')
,('9','�˲���')
,('10','������')
,('10','������')
,('10','��ɳ��')
,('10','������')
,('10','������')
,('10','������')
,('10','¦����')
,('10','��̶��')
,('10','������')
,('10','�żҽ���')
,('10','������')
,('11','������');



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
('���')
,('�ѻ�')
,('δ��');

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
(1,'ר�Һ�',100),
(2,'��ͨ�Һ�',30);
		
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
(1,'����������');

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
(1,'����',1)
,(2,'B��',1)
,(3,'�ĵ�ͼ',1)
,(4,'X��Ƭ',1)

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
(1,'Ѫ����',1)
,(2,'�򳣹�',1)
,(3,'B��',2)
,(4,'�ĵ�ͼ',3)
,(5,'X��Ƭ',4)
,(6,'�ʳ�',5);

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
(1,'��֢���',2)
,(2,'��·�������',2)
,(3,'����B��',3)
,(4,'����ϵͳB��',3)
,(5,'������Ｐ��',3)
,(6,'�����ĵ�ͼ',4)
,(7,'��̬�ĵ�ͼ',4)
,(8,'�˶�ƽ���ĵ�ͼ',4)
,(9,'��״�ٳ���',6)
,(10,'ǰ���ٳ���',6)
,(11,'�ε�Ƣ������',6);
INSERT INTO  tb_Content
(ContentNo ,Content,ListNo)
VALUES
(12,'Ѫ����',1);





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
(1,'��ҩ')
,(2,'��ҩ')
,(3,'����ҩ��');
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
		(1,'��')
		,(2,'��')
		,(3,'Ƭ')
		,(4,'֧')
		,(5,'��')
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