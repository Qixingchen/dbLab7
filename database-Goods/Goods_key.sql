alter table goodsinfo
add foreign key(goodsphotoid) references goodsphoto(goodsphotoid);

alter table goodsphoto
add foreign key(goodsid) references goodsinfo(goodsid);

alter table sellInfo
add foreign key(goodsid) references goodsinfo(goodsid);

alter table sellInfo
add foreign key(staffid) references staffinfo(staffid);

alter table stockinfo
add foreign key(staffid) references staffinfo(staffid);

alter table stockinfo
add foreign key(goodsid) references goodsinfo(goodsid);