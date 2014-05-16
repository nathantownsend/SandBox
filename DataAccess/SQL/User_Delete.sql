-- CREATED BY: Nathan Townsend
-- CREATED DATE: 5/16/2014
-- DO NOT MODIFY THIS CODE
-- CHANGES WILL BE LOST WHEN THE GENERATOR IS RUN AGAIN
-- GENERATION TOOL: Dalapi Code Generator (DalapiPro.com)



USE [SandBox]

-- Drop the procedure if it exists.
If OBJECT_ID('[dbo].[User_Delete]') IS NOT NULL
    BEGIN
    DROP PROCEDURE [dbo].[User_Delete]
    END
GO

CREATE PROCEDURE [dbo].[User_Delete]
    @UserId Int
AS

BEGIN
    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON;

    DELETE 
        [dbo].[User]
    WHERE
        [UserId] = @UserId

    SELECT @@ROWCOUNT AS DELETED; 
END