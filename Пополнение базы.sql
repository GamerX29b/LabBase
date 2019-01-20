USE Bank;
GO
/*Заполняем таблицу клиентов*/
SET NOCOUNT ON;
DELETE FROM [dbo].[client];
INSERT INTO [dbo].[client](id,adress,contact,telephone) VALUES (1, 'Павлова 50', 'Иванов Иван Иваныч', 88005553535);
INSERT INTO [dbo].[client](id,adress,contact,telephone) VALUES (2, 'Павлова 51', 'Петров Пётр Петрович', 88002000600);
INSERT INTO [dbo].[client](id,adress,contact,telephone) VALUES (3, 'Павлова 52', 'Максимов Максим Максимович', 88003131253);
INSERT INTO [dbo].[client](id,adress,contact,telephone) VALUES (4, 'Павлова 53', 'Александров Александр Александрович', 89842342354);
INSERT INTO [dbo].[client](id,adress,contact,telephone) VALUES (5, 'Павлова 54', 'Царь', 234225);
GO
/*Заполняем таблицу типов кредитов*/
SET NOCOUNT ON;
DELETE FROM [dbo].[credit_type];
INSERT INTO [dbo].[credit_type](id,type_credit) VALUES (1, 'Стандартный'),
(2, 'Ипотечный'),
(3, 'Валютный'),
(4, 'Ипотека');
GO
SET NOCOUNT ON;
DELETE FROM [dbo].[issuance_of_credit];
INSERT INTO [dbo].[issuance_of_credit] VALUES
(1, 15000, 8, '01/06/2019','12/01/2019', 1, 1),
(2, 2300000, 12, '01/06/2025','12/01/2019', 2, 3),
(3, 150000, 5, '01/06/2019','12/01/2019', 3, 2),
(4, 1500000, 6, '01/06/2019','12/01/2019', 4, 5)
GO
SET NOCOUNT ON;
DELETE FROM [dbo].[repayment];
INSERT INTO [dbo].[repayment] VALUES
(1, 1000, '12/02/2019', 1),
(2, 6000, '5/02/2019', 2),
(3, 6000, '12/03/2019', 2),
(4, 10000, '12/04/2019', 2),
(5, 4000, '12/02/2019', 3),
(6, 3000, '12/02/2019', 3),
(7, 4000, '12/02/2019', 3),
(8, 100000, '12/02/2019', 4)
GO
