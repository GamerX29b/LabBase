USE Bank;
GO
/*Просто покажем самый большой выданный кредит*/
SELECT MAX([dbo].[issuance_of_credit].summ)
FROM [dbo].[issuance_of_credit]
/*Показать кто и сколько заплатил*/
SELECT [dbo].[repayment].summ, contact
FROM client, repayment, [dbo].[issuance_of_credit]
WHERE client.id=id_client and id_credit=[dbo].[issuance_of_credit].id
/*Показать по сколько должен выплачивать человек каждый месяц*/
SELECT contact, (summ/(DATEDIFF(MONTH, data_issuance, [day_back])))
 AS 'Выплата в месяц'
 FROM client, issuance_of_credit
 WHERE client.id = id_client