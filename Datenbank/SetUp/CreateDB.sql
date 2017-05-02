USE PicDB
GO

----------------------------------------------
--Tabelle Pictures
----------------------------------------------

CREATE TABLE Pictures
(
  ID numeric(38,0) identity(1,1) PRIMARY KEY,
  Filename varchar(50) not null
);

----------------------------------------------
--Tabelle Photographers
----------------------------------------------

CREATE TABLE Photographers
(
  ID numeric(38,0) identity(1,1) PRIMARY KEY,
  Name varchar(100),
  Surname varchar(50) not null,
  Birthday datetime(0) null,
  Notes text null
);

----------------------------------------------
--Tabelle IPTC
----------------------------------------------

CREATE TABLE IPTC
(
  ID numeric(38,0) identity(1,1) PRIMARY KEY,
  ByLine varchar(100),
  Caption varchar(100),
  CopyrightNotice varchar(50),
  Headline varchar(50),
  Keywords varchar(50)
);

----------------------------------------------
--Tabelle EXIF
----------------------------------------------

CREATE TABLE EXIF
(
  ID numeric(38,0) identity(1,1) PRIMARY KEY,
  ExposureProgram varchar(10),
  --ExposureProgramResource varchar(20)
  ExposureTime float,
  Flash bit,
  FlahNumber float,
  ISORating varchar(10),
  
);
