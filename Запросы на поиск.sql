USE Bank;
GO
/*������ ������� ����� ������� �������� ������*/
SELECT MAX([dbo].[issuance_of_credit].summ)
FROM [dbo].[issuance_of_credit]
/*�������� ��� � ������� ��������*/
SELECT [dbo].[repayment].summ, contact
FROM client, repayment, [dbo].[issuance_of_credit]
WHERE client.id=id_client and id_credit=[dbo].[issuance_of_credit].id
/*�������� �� ������� ������ ����������� ������� ������ �����*/
SELECT contact, (summ/(DATEDIFF(MONTH, data_issuance, [day_back])))
 AS '������� � �����'
 FROM client, issuance_of_credit
 WHERE client.id = id_client