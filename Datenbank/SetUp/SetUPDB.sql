USE Master

IF EXISTS(SELECT * FROM sysdatabases WHERE name = 'PicDB')
  DROP DATABASE PicDB
GO

---------------------------------------------------------------------------------------------------
--Dateipfad entspricht MSSQL12 Express Edition, bei Verwendung anderer Edition entsprechend �ndern
---------------------------------------------------------------------------------------------------
CREATE DATABASE PicDB

ON PRIMARY (
  Name = 'PicDB_DATA',
  Filename='E:\Program Files\Microsoft SQL Server\MSSQL13.MSSQLSERVER\MSSQL\DATA\PicDB_DATA.mdf'
  --Filename='C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\PicDB_DATA.mdf',
  Size = 10MB,
  Filegrowth = 10%
)
LOG ON (
  Name = 'PicDB_LOG',
  Filename='E:\Program Files\Microsoft SQL Server\MSSQL13.MSSQLSERVER\MSSQL\DATA\PicDB_LOG.ldf'
  --Filename='C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\PicDB_LOG.ldf',
  Size = 10MB,
  Filegrowth = 10%
)
