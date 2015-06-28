Use Goods
go

insert into staffinfo values('10001','rootMa','Å®',23,'root');
insert into staffinfo values('10002','sellMa','ÄÐ',22,'sell');
insert into staffinfo values('10003','adminMa','Å®',17,'admin');
insert into staffinfo values('10004','staffMa','Å®',30,'staff');
insert into staffinfo values('10005','stockMa','ÄÐ',29,'stock');

insert into goodsphoto values('30001','.\barcode\barcode1.jpg');
insert into goodsphoto values('30002','.\barcode\barcode1.jpg');
insert into goodsphoto values('30003','.\barcode\barcode2.jpg');
insert into goodsphoto values('30004','.\barcode\barcode2.jpg');

insert into goodsInfo values('20001','·ÊÔí',200,'30001');
insert into goodsInfo values('20002','Á³Åè',222,'30002');
insert into goodsInfo values('20003','Ã«½í',249,'30003');
insert into goodsInfo values('20004','Ë¢×Ó',500,'30004');


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
