USE Bank
GO
--���� ������� ����� ������������� �������� 
--�������� ����� �� ������� �� �������
CREATE TRIGGER minus_remainder ON [dbo].[repayment]
AFTER INSERT
AS
UPDATE [dbo].[issuance_of_credit]
SET remainder_of_credit = remainder_of_credit - inserted.summ
FROM inserted
WHERE id_credit = issuance_of_credit.id




DROP TRIGGER procent_remainder
--���� ������� ��� ������ ������������� ����������� ����� ������� �� ����� ���������
CREATE TRIGGER procent_remainder ON [dbo].[issuance_of_credit]
AFTER INSERT
AS
UPDATE [dbo].[issuance_of_credit]  --����� ��� ������, ����� �������� ������� �� ����������, ���� ����� �� ���� �����
SET [issuance_of_credit].remainder_of_credit = [issuance_of_credit].summ + 
(SELECT (issuance_of_credit.summ*(issuance_of_credit.procent/12)*(DATEDIFF(MONTH, data_issuance, [day_back]))) FROM issuance_of_credit
WHERE issuance_of_credit.id = inserted.id)
FROM inserted
WHERE issuance_of_credit.id = inserted.id