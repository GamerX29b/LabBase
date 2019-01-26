USE Bank
GO
--Показать с помощью курсора кто просрочил  платежи 
DECLARE @Contact VARCHAR(40), 
@ID int = 1, --Это айдишник взятого кредита
@name varchar(40), --Имя человека который просрочил
@minimum int = null, --Это минимальный размер выплаты одного человека по кредиту
@issuance_of_credit int; --Это сколько минимально выплатил человек по кредиту
PRINT 'Люди просрочившие выплаты';
DECLARE cur CURSOR LOCAL FOR
/*Показать кто и сколько заплатил*/

SELECT @minimum = (SELECT MIN ((SELECT [dbo].[repayment].summ
FROM repayment, [dbo].[issuance_of_credit]
WHERE id_credit=[dbo].[issuance_of_credit].id and 
	  issuance_of_credit.id = @ID)))

/*Показать по сколько должен вы плачивать человек каждый месяц*/
SELECT @issuance_of_credit = (SELECT (summ/(DATEDIFF(MONTH, data_issuance, day_back)))
 FROM issuance_of_credit
 WHERE issuance_of_credit.id = @ID)

--Сравнивать, сколько человек должен платить в месяц и сколько он платил
IF @minimum < @issuance_of_credit
BEGIN
SELECT @name = (SELECT client.contact 
FROM client, issuance_of_credit
WHERE client.id = id_client and issuance_of_credit.id = @ID)

--WHILE @@FETCH_STATUS = 0

CLOSE cur;
DEALLOCATE cur;
PRINT @name;
END
GO