﻿using Microsoft.Data.SqlClient;
using MySqlDotnetCore.Connection;
using MySqlDotnetCore.Models;
using System.Collections.Generic;
using System.Data;

namespace MySqlDotnetCore.Context
{
    public class StaffDBContext
    {
        readonly SQLServer mssql = new SQLServer();

        #region GRIDVIEW
        public IEnumerable<StaffInfo> GetStaffInfo()
        {
            var StaffInfoList = new List<StaffInfo>();

            Models.Connection connection = mssql.GetConnection();

            using (SqlConnection conn = new SqlConnection(connection.connectionstring))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("spGetStaffInfo", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    var StaffInfo = new StaffInfo();

                    StaffInfo.StaffName = dr["staff_name"].ToString();
                    StaffInfo.StaffNo = dr["staff_id"].ToString();

                    StaffInfoList.Add(StaffInfo);
                }

                conn.Close();
            }

            return StaffInfoList;
        }
        #endregion
    }
}
