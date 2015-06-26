Use [master]
GO
--删除Login User
Drop Login [rootMa]
Drop Login adminMa
Drop Login staffMa
Drop Login stockMa
Drop Login sellMa
GO

Use [Goods]
GO
--删除触发器
drop trigger T_inventory
drop trigger T_inventory_2

--删除新增的用户
/****** Object:  Schema [rootTest]    Script Date: 2015/6/26 19:54:43 ******/
DROP SCHEMA [rootTest]
GO

drop user rootTest
drop login rootTset