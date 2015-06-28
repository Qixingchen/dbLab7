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
