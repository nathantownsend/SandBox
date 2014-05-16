// CREATED BY: Nathan Townsend
// CREATED DATE: 5/16/2014
// DO NOT MODIFY THIS CODE
// CHANGES WILL BE LOST WHEN THE GENERATOR IS RUN AGAIN
// GENERATION TOOL: Dalapi Code Generator (DalapiPro.com)



using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using SandBox.DAL;
using SandBox.DO.dbo;

namespace SandBox.DAL.dbo
{
    /// <summary>
    /// Provides data access methods for the User database table
    /// </summary>
    /// <remarks>
    public partial class User
    {
        
        /// <summary>
        /// Creates a new User record
        /// </summary>
        public static int Create(UserDO DO)
        {
            SqlParameter _FirstName = new SqlParameter("FirstName", SqlDbType.VarChar);
            SqlParameter _LastName = new SqlParameter("LastName", SqlDbType.VarChar);
            SqlParameter _MiddleInitial = new SqlParameter("MiddleInitial", SqlDbType.Char);
            SqlParameter _EmailAddress = new SqlParameter("EmailAddress", SqlDbType.VarChar);
            SqlParameter _PhoneNumber = new SqlParameter("PhoneNumber", SqlDbType.VarChar);
            SqlParameter _Address1 = new SqlParameter("Address1", SqlDbType.VarChar);
            SqlParameter _Address2 = new SqlParameter("Address2", SqlDbType.VarChar);
            SqlParameter _City = new SqlParameter("City", SqlDbType.VarChar);
            SqlParameter _State = new SqlParameter("State", SqlDbType.Char);
            SqlParameter _ZipCode = new SqlParameter("ZipCode", SqlDbType.VarChar);
            
            _FirstName.Value = DO.FirstName;
            _LastName.Value = DO.LastName;
            _MiddleInitial.Value = DO.MiddleInitial;
            _EmailAddress.Value = DO.EmailAddress;
            _PhoneNumber.Value = DO.PhoneNumber;
            _Address1.Value = DO.Address1;
            _Address2.Value = DO.Address2;
            _City.Value = DO.City;
            _State.Value = DO.State;
            _ZipCode.Value = DO.ZipCode;
            
            SqlParameter[] _params = new SqlParameter[] {
                _FirstName,
                _LastName,
                _MiddleInitial,
                _EmailAddress,
                _PhoneNumber,
                _Address1,
                _Address2,
                _City,
                _State,
                _ZipCode
            };

            return DataCommon.ExecuteScalar("[dbo].[User_Insert]", _params, "dbo");
            
        }


        /// <summary>
        /// Updates a User record and returns the number of records affected
        /// </summary>
        public static int Update(UserDO DO)
        {
            SqlParameter _UserId = new SqlParameter("UserId", SqlDbType.Int);
            SqlParameter _FirstName = new SqlParameter("FirstName", SqlDbType.VarChar);
            SqlParameter _LastName = new SqlParameter("LastName", SqlDbType.VarChar);
            SqlParameter _MiddleInitial = new SqlParameter("MiddleInitial", SqlDbType.Char);
            SqlParameter _EmailAddress = new SqlParameter("EmailAddress", SqlDbType.VarChar);
            SqlParameter _PhoneNumber = new SqlParameter("PhoneNumber", SqlDbType.VarChar);
            SqlParameter _Address1 = new SqlParameter("Address1", SqlDbType.VarChar);
            SqlParameter _Address2 = new SqlParameter("Address2", SqlDbType.VarChar);
            SqlParameter _City = new SqlParameter("City", SqlDbType.VarChar);
            SqlParameter _State = new SqlParameter("State", SqlDbType.Char);
            SqlParameter _ZipCode = new SqlParameter("ZipCode", SqlDbType.VarChar);
            
            _UserId.Value = DO.UserId;
            _FirstName.Value = DO.FirstName;
            _LastName.Value = DO.LastName;
            _MiddleInitial.Value = DO.MiddleInitial;
            _EmailAddress.Value = DO.EmailAddress;
            _PhoneNumber.Value = DO.PhoneNumber;
            _Address1.Value = DO.Address1;
            _Address2.Value = DO.Address2;
            _City.Value = DO.City;
            _State.Value = DO.State;
            _ZipCode.Value = DO.ZipCode;
            
            SqlParameter[] _params = new SqlParameter[] {
                _UserId,
                _FirstName,
                _LastName,
                _MiddleInitial,
                _EmailAddress,
                _PhoneNumber,
                _Address1,
                _Address2,
                _City,
                _State,
                _ZipCode
            };

            return DataCommon.ExecuteScalar("[dbo].[User_Update]", _params, "dbo");
        }


        /// <summary>
        /// Deletes a User record
        /// </summary>
        public static int Delete(UserDO DO)
        {
            SqlParameter _UserId = new SqlParameter("UserId", SqlDbType.Int);
            
            _UserId.Value = DO.UserId;
            
            SqlParameter[] _params = new SqlParameter[] {
                _UserId
            };

            return DataCommon.ExecuteScalar("[dbo].[User_Delete]", _params, "dbo");
        }


        /// <summary>
        /// Gets all User records
        /// </summary>
        public static UserDO[] GetAll()
        {
            SafeReader sr = DataCommon.ExecuteSafeReader("[dbo].[User_GetAll]", new SqlParameter[] { }, "dbo");
            
            List<UserDO> objs = new List<UserDO>();
            
            while(sr.Read()){

                UserDO obj = new UserDO();
                
                obj.UserId = sr.GetInt32(sr.GetOrdinal("UserId"));
                obj.FirstName = sr.GetString(sr.GetOrdinal("FirstName"));
                obj.LastName = sr.GetString(sr.GetOrdinal("LastName"));
                obj.Address1 = sr.GetString(sr.GetOrdinal("Address1"));
                obj.City = sr.GetString(sr.GetOrdinal("City"));
                obj.State = sr.GetString(sr.GetOrdinal("State"));
                obj.ZipCode = sr.GetString(sr.GetOrdinal("ZipCode"));
                if (sr.IsDBNull(sr.GetOrdinal("MiddleInitial"))) { obj.MiddleInitial = null; } else { obj.MiddleInitial = sr.GetString(sr.GetOrdinal("MiddleInitial")); }
                if (sr.IsDBNull(sr.GetOrdinal("EmailAddress"))) { obj.EmailAddress = null; } else { obj.EmailAddress = sr.GetString(sr.GetOrdinal("EmailAddress")); }
                if (sr.IsDBNull(sr.GetOrdinal("PhoneNumber"))) { obj.PhoneNumber = null; } else { obj.PhoneNumber = sr.GetString(sr.GetOrdinal("PhoneNumber")); }
                if (sr.IsDBNull(sr.GetOrdinal("Address2"))) { obj.Address2 = null; } else { obj.Address2 = sr.GetString(sr.GetOrdinal("Address2")); }


                objs.Add(obj);
            }

            return objs.ToArray();
        }


        /// <summary>
        /// Selects User records by PK
        /// </summary>
        public static UserDO[] GetByPK(Int32 UserId)
        {

            SqlParameter _UserId = new SqlParameter("UserId", SqlDbType.Int);
			
            _UserId.Value = UserId;
			
            SqlParameter[] _params = new SqlParameter[] {
                _UserId
            };

            SafeReader sr = DataCommon.ExecuteSafeReader("[dbo].[User_GetByPK]", _params, "dbo");

            List<UserDO> objs = new List<UserDO>();
			
            while(sr.Read())
            {
                UserDO obj = new UserDO();
				
                obj.UserId = sr.GetInt32(sr.GetOrdinal("UserId"));
                obj.FirstName = sr.GetString(sr.GetOrdinal("FirstName"));
                obj.LastName = sr.GetString(sr.GetOrdinal("LastName"));
                obj.Address1 = sr.GetString(sr.GetOrdinal("Address1"));
                obj.City = sr.GetString(sr.GetOrdinal("City"));
                obj.State = sr.GetString(sr.GetOrdinal("State"));
                obj.ZipCode = sr.GetString(sr.GetOrdinal("ZipCode"));
                if (sr.IsDBNull(sr.GetOrdinal("MiddleInitial"))) { obj.MiddleInitial = null; } else { obj.MiddleInitial = sr.GetString(sr.GetOrdinal("MiddleInitial")); }
                if (sr.IsDBNull(sr.GetOrdinal("EmailAddress"))) { obj.EmailAddress = null; } else { obj.EmailAddress = sr.GetString(sr.GetOrdinal("EmailAddress")); }
                if (sr.IsDBNull(sr.GetOrdinal("PhoneNumber"))) { obj.PhoneNumber = null; } else { obj.PhoneNumber = sr.GetString(sr.GetOrdinal("PhoneNumber")); }
                if (sr.IsDBNull(sr.GetOrdinal("Address2"))) { obj.Address2 = null; } else { obj.Address2 = sr.GetString(sr.GetOrdinal("Address2")); }

                objs.Add(obj);
            }

            return objs.ToArray();
        }




        /// <summary>
        /// Truncates the User Table
        /// </summary>
        public static void Truncate()
        {
            DataCommon.TruncateTable("dbo", "User");
        }

    }
}