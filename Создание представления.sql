USE Bank;
GO
CREATE VIEW Total_payout
AS
SELECT (summ+summ/100*procent)
AS Total_payout
FROM issuance_of_credit
GO

USE Bank;
GO
CREATE VIEW total_debt
AS
SELECT SUM(Total_payout)
AS Всего_долгов
FROM Total_payout 
GO
