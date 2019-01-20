USE Bank
GO
IF OBJECT_ID('new_client', 'P') IS NOT NULL
DROP PROCEDURE new_client;
GO
--Хранимая процедура для добавления нового клиента... Просто сама генерит ID
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