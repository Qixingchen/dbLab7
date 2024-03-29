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