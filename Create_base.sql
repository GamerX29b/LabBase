USE master
GO
IF DB_ID('Bank') IS NOT NULL
DROP DATABASE Bank;
GO
CREATE DATABASE Bank
ON PRIMARY (NAME = Bank_data, FILENAME = 'D:\Base\Bank.mdf',
		MAXSIZE = UNLIMITED)
LOG ON (NAME = Bank_log, FILENAME = 'D:\Base\Bank.mdf',
		MAXSIZE = 30 MB)
COLLATE Cyrillic_General_CI_AS;
GO