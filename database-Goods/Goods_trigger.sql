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

