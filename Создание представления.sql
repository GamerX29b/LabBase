USE Bank;
GO
--ѕредставление показывающее сколько человек всего должен выплатить
CREATE VIEW Total_payout
AS
SELECT (summ+summ/100*procent)
AS Total_payout
FROM issuance_of_credit
GO
--Ёто представление показывает сумму всех выданных кредитов
USE Bank;
GO
CREATE VIEW total_debt
AS
SELECT SUM(Total_payout)
AS ¬сего_долгов
FROM Total_payout 
GO
