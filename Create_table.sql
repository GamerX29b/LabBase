CREATE TABLE client (
id int NOT NULL,
adress varchar(40),
contact varchar(40),
telephone varchar(40)
primary key (id)
 )

 CREATE TABLE issuance_of_credit (
id int NOT NULL,
summ int,
procent int,
day_back date,
data_issuance date,
id_type int
primary key (id)
 )

 CREATE TABLE repayment (
id int NOT NULL,
summ int,
date_rep date,
id_credit int
primary key (id)
 )

 CREATE TABLE credit_type (
id int NOT NULL,
type_credit varchar(40)
primary key (id)
 )