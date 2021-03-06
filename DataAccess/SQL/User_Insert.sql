-- CREATED BY: Nathan Townsend
-- CREATED DATE: 5/16/2014
-- DO NOT MODIFY THIS CODE
-- CHANGES WILL BE LOST WHEN THE GENERATOR IS RUN AGAIN
-- GENERATION TOOL: Dalapi Code Generator (DalapiPro.com)



USE [SandBox]

-- Drop the procedure if it exists.
If OBJECT_ID('[dbo].[User_Insert]') IS NOT NULL
    BEGIN
    DROP PROCEDURE [dbo].[User_Insert]
    END
GO

CREATE PROCEDURE [dbo].[User_Insert]
    @FirstName VarChar(50),
    @LastName VarChar(50),
    @MiddleInitial Char(1) = null,
    @EmailAddress VarChar(150) = null,
    @PhoneNumber VarChar(20) = null,
    @Address1 VarChar(100),
    @Address2 VarChar(100) = null,
    @City VarChar(50),
    @State Char(2),
    @ZipCode VarChar(10)
AS

BEGIN
    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON;

    INSERT INTO [dbo].[User]
	(
        [FirstName],
        [LastName],
        [MiddleInitial],
        [EmailAddress],
        [PhoneNumber],
        [Address1],
        [Address2],
        [City],
        [State],
        [ZipCode]
    ) VALUES (
        @FirstName,
        @LastName,
        @MiddleInitial,
        @EmailAddress,
        @PhoneNumber,
        @Address1,
        @Address2,
        @City,
        @State,
        @ZipCode
	)

	-- return the new identity value
	SELECT SCOPE_IDENTITY()

END