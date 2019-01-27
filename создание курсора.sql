USE Bank
GO
--�������� � ������� ������� ��� �� �����������
DECLARE @Contact VARCHAR(40), 
@return varchar(40) = 1, --��� �������� ������� �������
@name varchar(40), --��� �������� ������� ���������
@issuance_of_credit varchar(40); --��� ������� ���������� �������� ������� �� �������
PRINT '���� ������������ �������';
DECLARE cur CURSOR LOCAL FOR
/*�������� ��� ��� ��� �� ������� ������*/

SELECT [contact], [remainder_of_credit]
FROM [dbo].[issuance_of_credit], [dbo].[client]
WHERE [dbo].[client].id = id_client and [remainder_of_credit] > 0
OPEN cur;
FETCH NEXT FROM cur INTO @name, @issuance_of_credit
--����������, ������� ������� ������ ������� � ����� � ������� �� ������
WHILE @@FETCH_STATUS = 0
BEGIN
	SELECT @return = @issuance_of_credit + ' ' + @name
	PRINT @return;
	FETCH NEXT FROM cur INTO @name, @issuance_of_credit
END

CLOSE cur;
DEALLOCATE cur;
GO
/*�������� �� ������� ������ �� ��������� ������� ������ �����
SELECT @issuance_of_credit = (SELECT (summ/(DATEDIFF(MONTH, data_issuance, day_back)))
 FROM issuance_of_credit
 WHERE issuance_of_credit.id = @ID)*/
 USE Bank
 CREATE TABLE Debtors (
 ID_credit int NOT NULL,
 debt money  NOT NULL
 PRIMARY KEY(ID_credit)
 )
 /*�������� �������� ���������*/
 IF OBJECT_ID ('Debtor', 'P') IS NOT NULL
	DROP PROCEDURE Debtor;
GO
CREATE PROCEDURE Debtor
AS
BEGIN
	DECLARE @ID_credit int, @debt money;
	DECLARE cur CURSOR  LOCAL FOR
		/*���������� ��� ��� �� �������� � ����*/
		SELECT id, remainder_of_credit
		FROM [issuance_of_credit]
		WHERE day_back < GETDATE() and [remainder_of_credit] > 0;
	OPEN Cur;
	FETCH NEXT FROM cur
	INTO @ID_credit, @debt;
	WHILE @@FETCH_STATUS = 0
		BEGIN
			INSERT INTO Debtors VALUES
				( @ID_credit, @debt)
				FETCH NEXT FROM cur INTO  @ID_credit, @debt;
		END;
	CLOSE cur;
	DEALLOCATE cur;
END
GO
/*���������� �������� ���������*/
USE Bank
GO
EXECUTE Debtor;
SELECT * FROM Debtors
GO
