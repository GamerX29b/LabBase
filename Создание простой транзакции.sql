USE Bank
GO
--По идее, вся оплата должна происходить транзакциями
--Это явная транзакция
SET NOCOUNT ON;
BEGIN TRAN pay_credit
INSERT [dbo].[repayment] VALUES (9, 100000, '12/03/2019', 4);
PRINT @@TRANCOUNT;
SAVE TRAN point_pay;
INSERT [dbo].[repayment] VALUES (10, 100000, '12/04/2019', 4);
ROLLBACK TRAN point_pay;
COMMIT TRAN pay_credit;
SELECT * FROM [repayment]

--Неявная транзакция
SET IMPLICIT_TRANSACTIONS ON;
SET NOCOUNT ON;
INSERT [dbo].[repayment] VALUES (9, 100000, '12/03/2019', 4);
PRINT @@TRANCOUNT;
SAVE TRAN point_pay;
INSERT [dbo].[repayment] VALUES (10, 100000, '12/04/2019', 4);
ROLLBACK TRAN point_pay;
COMMIT TRAN;
PRINT @@TRANCOUNT;
SELECT * FROM [repayment]