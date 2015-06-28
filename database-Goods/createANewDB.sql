USE [master]
GO

/****** Object:  Database [Goods]    Script Date: 2015/6/26 17:27:34 ******/
CREATE DATABASE [Goods]
GO

Use [Goods]
GO

create table inventoryInfo
(
	goodsid varchar(10) primary key,
	goodsname varchar(30) not null,
	reserve int not null
);

create table goodsInfo
(
	goodsid varchar(10) primary key,
	goodsname varchar(30) not null,
	goodsprice smallmoney not null,
	goodsphotoid varchar(10) not null
);

create table goodsphoto
(
	goodsphotoid varchar(10) primary key,
	photourl varchar(400)
);

create table loginuser
(
	userName varchar(30),
	userPwd varchar(30)
);

create table sellInfo
(
	sellid varchar(10) primary key,
	selltime datetime not null,
	sellcount smallint not null,
	payment smallmoney not null,
	goodsid varchar(10) not null,
	staffid varchar(10) not null
);

create table staffInfo
(
	staffid varchar(10) primary key,
	staffname varchar(30) not null,
	staffgender char(2) not null,
	staffage smallint not null,
	staffType varchar(10) not null
);

create table stockInfo
(
	stockid varchar(10) primary key,
	stocktime datetime not null,
	goodscount smallint not null,
	goodsid varchar(10) not null,
	staffid varchar(10) not null
);


GO

--key
Use Goods
GO

alter table goodsinfo
add foreign key(goodsphotoid) references goodsphoto(goodsphotoid);

alter table sellInfo
add foreign key(goodsid) references goodsinfo(goodsid);

alter table sellInfo
add foreign key(staffid) references staffinfo(staffid);

alter table stockinfo
add foreign key(staffid) references staffinfo(staffid);

alter table stockinfo
add foreign key(goodsid) references goodsinfo(goodsid);

Go

--trigger

Use [Goods]
GO

create trigger T_inventory on stockInfo
for insert,update
as
begin
	declare @goodsid varchar(10),@goodscount smallint;
	set @goodsid=(select goodsid from inserted);
	set @goodscount=(select goodscount from inserted);
	if exists(select * from inventoryInfo where goodsid=@goodsid)
		update inventoryInfo set reserve=reserve+@goodscount where goodsid=@goodsid;
	else
		insert into inventoryInfo 
			select goodsid,goodsname,@goodscount from goodsInfo where goodsid=@goodsid;
end;
GO

create trigger T_inventory_2 on sellInfo
for insert,update
as
begin
	declare @goodsid2 varchar(10),@sellcount2 smallint;
	set @goodsid2=(select goodsid from inserted);
	set @sellcount2=(select sellcount from inserted);
	update inventoryInfo set reserve=reserve-@sellcount2 where goodsid=@goodsid2;
end;

GO

--security

use Goods
GO
/*--说明
        在数据库Goods中创建:
	IT运维人员：对数据库Goods的所有权限（rootMa:123456）；
	负责人：对数据库Goods的所有查询权限（adminMa:123456）
	人事管理人员：对dbo.staffinfo,表的所有权限（staffMa:123456 ）；
	仓储管理人员：对dbo.stockinfo,dbo.goodsinfo,dbo.goodsphoto表的所有权限
	（stockMa:123456）；
	销售管理人员：对dbo.sellinfo,dbo.goodsinfo,dbo.goodsphoto表的所有权限
	（sellMa:123456）；
--*/


USE Goods

--添加登录
EXEC sp_addlogin 'rootMa','123456','Goods'
EXEC sp_addlogin 'adminMa','123456','Goods'
EXEC sp_addlogin 'staffMa','123456','Goods'
EXEC sp_addlogin 'stockMa','123456','Goods'
EXEC sp_addlogin 'sellMa','123456','Goods'

--为登录添加用户
EXEC sp_adduser 'rootMa','rootMa'
EXEC sp_adduser 'adminMa','adminMa'
EXEC sp_adduser 'staffMa','staffMa'
EXEC sp_adduser 'stockMa','stockMa'
EXEC sp_adduser 'sellMa','sellMa'


--授予用户对应权限
--rootMa
GRANT insert,select,update,delete ON staffinfo TO rootMa
GRANT insert,select,update,delete ON stockinfo TO rootMa
GRANT insert,select,update,delete ON goodsinfo TO rootMa
GRANT insert,select,update,delete ON goodsphoto TO rootMa
GRANT insert,select,update,delete ON sellinfo TO rootMa
GRANT insert,select,update,delete ON loginuser TO rootMa
GRANT insert,select,update,delete ON inventoryInfo TO rootMa

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


GO

--data

Use Goods
go

insert into staffinfo values('10001','rootMa','女',23,'root');
insert into staffinfo values('10002','sellMa','男',22,'sell');
insert into staffinfo values('10003','adminMa','女',17,'admin');
insert into staffinfo values('10004','staffMa','女',30,'staff');
insert into staffinfo values('10005','stockMa','男',29,'stock');

insert into goodsphoto values('30001','.\barcode\barcode1.jpg');
insert into goodsphoto values('30002','.\barcode\barcode1.jpg');
insert into goodsphoto values('30003','.\barcode\barcode2.jpg');
insert into goodsphoto values('30004','.\barcode\barcode2.jpg');

insert into goodsInfo values('20001','肥皂',200,'30001');
insert into goodsInfo values('20002','脸盆',222,'30002');
insert into goodsInfo values('20003','毛巾',249,'30003');
insert into goodsInfo values('20004','刷子',500,'30004');


insert into sellInfo values('40001','2015-06-23',2,6,'20001','10001');
insert into sellInfo values('40002','2015-05-23',2,40,'20002','10002');
insert into sellInfo values('40003','2015-04-23',2,34,'20003','10003');
insert into sellInfo values('40004','2015-03-23',2,16,'20004','10004');
insert into sellInfo values('40009','2015-06-23',2,6,'20001','10001');
insert into sellInfo values('40010','2015-05-23',2,40,'20002','10002');
insert into sellInfo values('40011','2015-04-23',2,34,'20003','10003');
insert into sellInfo values('40012','2015-03-23',2,16,'20004','10004');
insert into sellInfo values('40017','2015-06-23',2,6,'20001','10001');
insert into sellInfo values('40018','2015-05-23',2,40,'20002','10002');


insert into stockInfo values('50001','2014-12-20',100,'20001','10001');
insert into stockInfo values('50002','2014-12-19',100,'20002','10001');
insert into stockInfo values('50003','2014-12-18',100,'20003','10001');
insert into stockInfo values('50004','2014-12-20',100,'20004','10001');

