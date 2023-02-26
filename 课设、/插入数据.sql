USE MedicalSystem;
insert into tb_Doctors
(DoctorName,password,gender,level,officeid,RegisterTypeNo)
values
('С��',HASHBYTES('MD5','123456'),'1','������ҽʦ','1','1')
,('СԪ',HASHBYTES('MD5','123456'),'1','����ҽʦ','2','1');
INSERT INTO tb_OFFICE
(OFFICENAME,OFFICETYPEID)
VALUES
('�����ڿ�','1')
,('�����','2');
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

INSERT INTO tb_PAYTYPE
(PAYTYPENAME)
VALUES
('ȫ�Է�')
,('ҽ��');


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

INSERT INTO tb_MARRYSITUATION
(MARRYSITUATION)
VALUES
('���')
,('�ѻ�')
,('δ��');


--INSERT INTO tb_PAYTYPE
--(PAYTYPENAME)
--VALUES
--('ҽ��')
--,('�Է�');

INSERT INTO tb_RegisterType
(RegisterTypeNo,RegisterTypeName,PRICE)
VALUES
(1,'ר�Һ�',100),
(2,'��ͨ�Һ�',30);

INSERT INTO  tb_ProjectCategory
(ProjectCategoryNo ,ProjectCategory)
VALUES
(1,'����������');

INSERT INTO  tb_Category
(CategoryNo ,Category,ProjectCategoryNo)
VALUES
(1,'����',1)
,(2,'B��',1)
,(3,'�ĵ�ͼ',1)
,(4,'X��Ƭ',1)
;
INSERT INTO  tb_Category
(CategoryNo ,Category,ProjectCategoryNo)
VALUES
(5,'�ʳ�',1)
INSERT INTO  tb_List
(ListNo ,List,CategoryNo)
VALUES
(1,'Ѫ����',1)
,(2,'�򳣹�',1)
,(3,'B��',2)
,(4,'�ĵ�ͼ',3)
,(5,'X��Ƭ',4)
,(6,'�ʳ�',5);

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


INSERT INTO tb_DrugsCategory
(DrugsCategoryNo,NAME)
VALUES
(1,'��ҩ')
,(2,'��ҩ')
,(3,'����ҩ��');

BULK INSERT tb_Drugs
	FROM 'E:\ҽѧ���ݿ�\Medicine.csv'
	WITH
		(FIELDTERMINATOR=','
		,ROWTERMINATOR='\n'
		,FIRSTROW=2);

		INSERT INTO tb_Per
		(PerNo,Name)
		VALUES
		(1,'��')
		,(2,'��')
		,(3,'Ƭ')
		,(4,'֧')
		,(5,'��')
		,(6,'ml');