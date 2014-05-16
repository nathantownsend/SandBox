-- CREATED BY: Nathan Townsend
-- CREATED DATE: 5/16/2014
-- DO NOT MODIFY THIS CODE
-- CHANGES WILL BE LOST WHEN THE GENERATOR IS RUN AGAIN
-- GENERATION TOOL: Dalapi Code Generator (DalapiPro.com)



USE [SandBox]

-- Drop the procedure if it exists.
If OBJECT_ID('[dbo].[User_Update]') IS NOT NULL
    BEGIN
    DROP PROCEDURE [dbo].[User_Update]
    END
GO

CREATE PROCEDURE [dbo].[User_Update]
    @UserId Int,
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

    UPDATE [dbo].[User]
    SET
        [FirstName] = @FirstName,
        [LastName] = @LastName,
        [MiddleInitial] = @MiddleInitial,
        [EmailAddress] = @EmailAddress,
        [PhoneNumber] = @PhoneNumber,
        [Address1] = @Address1,
        [Address2] = @Address2,
        [City] = @City,
        [State] = @State,
        [ZipCode] = @ZipCode
    WHERE
        [UserId] = @UserId

    SELECT @@ROWCOUNT AS UPDATED; 
END