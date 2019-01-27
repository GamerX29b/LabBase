USE Bank
GO
IF OBJECT_ID('new_client', 'P') IS NOT NULL
DROP PROCEDURE new_client;
GO
--Хранимая процедура для добавления нового клиента. Сама генерирует ID
CREATE PROCEDURE new_client (
	
	@adress varchar(40) = null,
	@contact varchar(40) = null,
	@telephone varchar(40) = null)
	AS
	BEGIN
		DECLARE 
		@id int  = null
		SET 
		@id = 1+(SELECT MAX(id) FROM client)
		
		INSERT INTO [dbo].[client] VALUES (@id,@adress,@contact,@telephone);
		END
		GO

IF OBJECT_ID('new_client_type', 'P') IS NOT NULL
DROP PROCEDURE new_client_type;
GO
--Хранимая процедура для добавления нового типа кредита. Сама генерирует ID
CREATE PROCEDURE new_client_type (
	
	@type_credit varchar(40) = null)
	AS
	BEGIN
		DECLARE 
		@id int  = null
		SET 
		@id = 1+(SELECT MAX(id) FROM client)
		
		INSERT INTO [dbo].[credit_type] VALUES (@id,@type_credit);
		END
		GO

		IF OBJECT_ID('new_credit', 'P') IS NOT NULL
DROP PROCEDURE new_credit;
GO
--Хранимая процедура для выдачи нового кредита. Сама генерирует ID
CREATE PROCEDURE new_credit (
	
	@summ money = null,
	@procent int = null,
	@day_back date = null,
	@data_issuamce date = null,
	@id_type int = null,
	@id_client int = null)
	AS
	BEGIN
		DECLARE 
		@id int  = null
		SET 
		@id = 1+(SELECT MAX(id) FROM client)
		
		INSERT INTO [dbo].[issuance_of_credit] VALUES (@id, @summ,@procent,@day_back,@data_issuamce,@id_type,@id_client,@summ);
		END
		GO

IF OBJECT_ID('new_repayment', 'P') IS NOT NULL
DROP PROCEDURE new_repayment;
GO
--Хранимая процедура для добавления нового клиента. Сама генерирует ID
CREATE PROCEDURE new_repayment (
	
	@summ money  = null,
	@date date = null,
	@id_credit int = null)
	AS
	BEGIN
		DECLARE 
		@id int  = null
		SET 
		@id = 1+(SELECT MAX(id) FROM client)
		
		INSERT INTO [dbo].[client] VALUES (@id,@summ,@date,@id_credit);
		END
		GO