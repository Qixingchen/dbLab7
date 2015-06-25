select goodsname,stocktime,stockinfo.goodscount,staffname from stockInfo,staffInfo,goodsInfo 
where stockinfo.staffid = staffinfo.staffid and stockinfo.goodsid = goodsinfo.goodsid

/*--˵��
        �����ݿ�Goods�д���:
	IT��ά��Ա�������ݿ�Goods������Ȩ�ޣ�rootMa:123456����
	�����ˣ������ݿ�Goods�����в�ѯȨ�ޣ�adminMa:123456��
	���¹�����Ա����dbo.staffinfo,�������Ȩ�ޣ�staffMa:123456 ����
	�ִ�������Ա����dbo.stockinfo,dbo.goodsinfo,dbo.goodsphoto�������Ȩ��
	��stockMa:123456����
	���۹�����Ա����dbo.sellinfo,dbo.goodsinfo,dbo.goodsphoto�������Ȩ��
	��sellMa:123456����
--*/


USE Goods

--��ӵ�¼
EXEC sp_addlogin 'rootMa','123456','Goods'
EXEC sp_addlogin 'adminMa','123456','Goods'
EXEC sp_addlogin 'staffMa','123456','Goods'
EXEC sp_addlogin 'stockMa','123456','Goods'
EXEC sp_addlogin 'sellMa','123456','Goods'

--Ϊ��¼����û�
EXEC sp_adduser 'rootMa','rootMa'
EXEC sp_adduser 'adminMa','adminMa'
EXEC sp_adduser 'staffMa','staffMa'
EXEC sp_adduser 'stockMa','stockMa'
EXEC sp_adduser 'sellMa','sellMa'


--�����û���ӦȨ��
--rootMa
GRANT insert,select,update,delete ON staffinfo TO rootMa
GRANT insert,select,update,delete ON stockinfo TO rootMa
GRANT insert,select,update,delete ON goodsinfo TO rootMa
GRANT insert,select,update,delete ON goodsphoto TO rootMa
GRANT insert,select,update,delete ON sellinfo TO rootMa
GRANT insert,select,update,delete ON loginuser TO rootMa

--adminMa
GRANT select ON staffinfo TO adminMa
GRANT select ON stockinfo TO adminMa
GRANT select ON goodsinfo TO adminMa
GRANT select ON goodsphoto TO adminMa
GRANT select ON sellinfo TO adminMa

--staffMa
GRANT insert,select,update,delete ON staffinfo TO staffMa
--stockMa
GRANT insert,select,update,delete ON stockinfo TO stockMa
GRANT insert,select,update,delete ON goodsinfo TO stockMa
GRANT insert,select,update,delete ON goodsphoto TO stockMa
--sellMa
GRANT insert,select,update,delete ON goodsinfo TO sellMa
GRANT insert,select,update,delete ON goodsphoto TO sellMa
GRANT insert,select,update,delete ON sellinfo TO sellMa

--��¼�û���
create table loginuser
(
	userName varchar(30),
	userPwd varchar(30)
)

insert into loginuser values('rootMa','123456');
insert into loginuser values('adminMa','123456');
insert into loginuser values('staffMa','123456');
insert into loginuser values('stockMa','123456');
insert into loginuser values('sellMa','123456');