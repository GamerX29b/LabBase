USE Bank
GO
--�������� � ������� ������� ��� ���������  ������� 
DECLARE @Contact VARCHAR(40), 
@ID int = 1, --��� �������� ������� �������
@name varchar(40), --��� �������� ������� ���������
@minimum int = null, --��� ����������� ������ ������� ������ �������� �� �������
@issuance_of_credit int; --��� ������� ���������� �������� ������� �� �������
PRINT '���� ������������ �������';
DECLARE cur CURSOR LOCAL FOR
/*�������� ��� � ������� ��������*/

SELECT @minimum = (SELECT MIN ((SELECT [dbo].[repayment].summ
FROM repayment, [dbo].[issuance_of_credit]
WHERE id_credit=[dbo].[issuance_of_credit].id and 
	  issuance_of_credit.id = @ID)))

/*�������� �� ������� ������ �� ��������� ������� ������ �����*/
SELECT @issuance_of_credit = (SELECT (summ/(DATEDIFF(MONTH, data_issuance, day_back)))
 FROM issuance_of_credit
 WHERE issuance_of_credit.id = @ID)

--����������, ������� ������� ������ ������� � ����� � ������� �� ������
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