Imports SandBox.DO.dbo
Imports SandBox.DAL.dbo

Public Class UserBLL

    ''' <summary>
    ''' Creates a new user in the database and returns the updated data object
    ''' </summary>
    ''' <param name="NewUser"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function Create(ByVal NewUser As UserDO) As UserDO
        NewUser.UserId = User.Create(NewUser)
        Return NewUser
    End Function

    ''' <summary>
    ''' Deletes a user
    ''' </summary>
    ''' <param name="Data"></param>
    ''' <remarks></remarks>
    Public Shared Sub Delete(ByVal Data As UserDO)
        User.Delete(Data)
    End Sub


    ''' <summary>
    ''' Gets a user by id
    ''' </summary>
    ''' <param name="UserId"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function GetUser(ByVal UserId As Integer) As UserDO
        Return User.GetByPK(UserId).FirstOrDefault()
    End Function



    ''' <summary>
    ''' Gets all users in the system
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function GetAll() As List(Of UserDO)
        Return User.GetAll().ToList()
    End Function


    ''' <summary>
    ''' Updates a user record
    ''' </summary>
    ''' <param name="data"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function Update(ByVal data As UserDO) As UserDO
        User.Update(data)
        Return data
    End Function




End Class
