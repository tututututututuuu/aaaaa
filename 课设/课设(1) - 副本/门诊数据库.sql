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
--IF OBJECT_ID('tb_Doctors') IS NOT NULL      
--  DROP TABLE tb_Doctors;      
--GO
--CREATE TABLE tb_Doctors
--	(DoctorID
--	VARCHAR(100)
--		NOT NULL
--		--int identity(1,1)
--		--NOT NULL
--		--CONSTRAINT pk_Doctors_DoctorID
--		--	PRIMARY KEY(DoctorID)
--	,DoctorName
--		VARCHAR(100)
--		NOT NULL
--	,password
--	    VARCHAR(100)
--		NOT NULL
--	,Gender
--	bit
--	NOT NULL
--	,LEVEL
--	 VARCHAR(100)
--	 NOT NULL
--	 ,OFFICEID
--	 INT
--	 NOT NULL
--	 --CONSTRAINT fk_Doctors_OFFICEID
--		--	 FOREIGN KEY(OFFICEID)
--		--	 REFERENCES tb_OFFICE(OFFICEID)
--		--	 ON DELETE CASCADE
--		--     ON UPDATE CASCADE
--	,RegisterTypeNo
--	int
--		NOT NULL
--    -- CONSTRAINT fk_Doctors_RegisterTypeNo
--			 --FOREIGN KEY(RegisterTypeNo)
--			 --REFERENCES tb_RegisterType(RegisterTypeNo)
--			 --ON DELETE CASCADE
--		  --   ON UPDATE CASCADE
--	);
--	INSERT INTO tb_Doctors
--(DoctorID,DoctorName,password,gender,level,officeid,RegisterTypeNo)
--values
--('001','小蔡',HASHBYTES('MD5','123456'),'1','副主任医师','1','1')
--,('002','小元',HASHBYTES('MD5','123456'),'1','主任医师','2','1');

--IF OBJECT_ID('tb_OFFICE') IS NOT NULL         
--  DROP TABLE tb_OFFICE;   
--GO
--CREATE TABLE tb_OFFICE
--	(OFFICEID
--		int identity(1,1)
--		NOT NULL
--		--CONSTRAINT pk_OFFICE_OFFICEID
--		--PRIMARY KEY(OFFICEID)
--	,OFFICENAME
--	VARCHAR(100)
--	NOT NULL
--	,OFFICETYPEID
--	 int 
--	NOT NULL
--	 --CONSTRAINT fk_OFFICE_OFFICETYPEID
--		--	 FOREIGN KEY(OFFICETYPEID)
--		--	 REFERENCES tb_OFFICETYPE(OFFICETYPEID)
--		--	 ON DELETE CASCADE
--		--     ON UPDATE CASCADE
--	);
--	INSERT INTO tb_OFFICE
--(OFFICENAME,OFFICETYPEID)
--VALUES
--('呼吸内科','1')
--,('神经外科','2');

CREATE TABLE tb_User
	(No
		CHAR(10)
		NOT NULL
		PRIMARY KEY
	,Password
		VARBINARY(128)
		NOT NULL);
INSERT tb_User
	(No,Password)
	VALUES
	('3210707001',HASHBYTES('MD5','7001'));