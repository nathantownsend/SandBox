// CREATED BY: Nathan Townsend
// CREATED DATE: 5/16/2014
// DO NOT MODIFY THIS CODE
// CHANGES WILL BE LOST WHEN THE GENERATOR IS RUN AGAIN
// GENERATION TOOL: Dalapi Code Generator (DalapiPro.com)



using System;
using System.ComponentModel.DataAnnotations;

namespace SandBox.DO.dbo
{
    /// <summary>
    /// Encapsulates a row of data in the User table
    /// </summary>
    public partial class UserDO
    {

        public virtual Int32 UserId {get; set;}
        public virtual String FirstName {get; set;}
        public virtual String LastName {get; set;}
        public virtual String MiddleInitial {get; set;}
        public virtual String EmailAddress {get; set;}
        public virtual String PhoneNumber {get; set;}
        public virtual String Address1 {get; set;}
        public virtual String Address2 {get; set;}
        public virtual String City {get; set;}
        public virtual String State {get; set;}
        public virtual String ZipCode {get; set;}

    }
}