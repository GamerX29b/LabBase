USE Bank
GO
/*Таблица клиентов*/
IF EXISTS (SELECT* FROM sys.tables WHERE NAME = 'client') 
DROP TABLE client;
GO
CREATE TABLE client (
id int NOT NULL,
adress varchar(40),
contact varchar(40),
telephone varchar(40)
primary key (id)
 )
GO
/*Таблица типов кредита*/
IF EXISTS (SELECT* FROM sys.tables WHERE NAME = 'credit_type') 
DROP TABLE credit_type;
GO
  CREATE TABLE credit_type (
id int NOT NULL,
type_credit varchar(40)
primary key (id)
 )
GO
/*Таблица выдачи кредитов*/
IF EXISTS (SELECT* FROM sys.tables WHERE NAME = 'issuance_of_credit') 
DROP TABLE issuance_of_credit;
GO
 CREATE TABLE issuance_of_credit (
id int NOT NULL,
summ int,
procent int,
day_back date,
data_issuance date,
id_type int,
id_client int
primary key (id)
FOREIGN KEY (id_client) REFERENCES Client (id) 
ON UPDATE CASCADE ON DELETE CASCADE,
FOREIGN KEY (id_type) REFERENCES credit_type (id) 
ON UPDATE CASCADE ON DELETE CASCADE);
 GO
 /*Таблица выплат*/
 IF EXISTS (SELECT* FROM sys.tables WHERE NAME = 'repayment') 
DROP TABLE repayment;
GO
 CREATE TABLE repayment (
id int NOT NULL,
summ int,
date_rep date,
id_credit int
primary key (id)
FOREIGN KEY (id_credit) REFERENCES issuance_of_credit (id)
ON UPDATE CASCADE ON DELETE CASCADE);
 




