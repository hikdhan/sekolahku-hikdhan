﻿using Dapper;
using Nuna.Lib.DataAccessHelper;
using sekolahku_jude.Model;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace sekolahku_jude.DataAkses
{
    public class GuruDal
    {
        private string _connString;
        public GuruDal()
        {
            _connString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
        }

        public void Insert(Siswamodel model)
        {
            //  QUERY
            const string sql = @"
                INSERT INTO Guru(GuruId, GuruName)
                VALUES (@GuruId, @GuruName)";

            //  PARAM
            var dp = new DynamicParameters();
            dp.AddParam("@GuruId", model.GuruId, System.Data.SqlDbType.VarChar);
            dp.AddParam("@GuruName", model.GuruName, System.Data.SqlDbType.VarChar);

            //  EXECUTE
            using (var conn = new SqlConnection(_connString))
            {
                conn.Execute(sql, dp);
            }
        }

        public void Update(Siswamodel model)
        {
            //  QUERY
            const string sql = @"
                UPDATE
                    Guru
                SET
                    GuruName = @GuruName
                WHERE
                    GuruId = @GuruId ";

            //  PARAM
            var dp = new DynamicParameters();
            dp.AddParam("@GuruId", model.GuruId, System.Data.SqlDbType.VarChar);
            dp.AddParam("@GuruName", model.GuruName, System.Data.SqlDbType.VarChar);

            //  EXECUTE
            using (var conn = new SqlConnection(_connString))
            {
                conn.Execute(sql, dp);
            }
        }
        public void Delete(string guruId)
        {
            //  QUERY
            const string sql = @"
                DELETE FROM
                    Guru
                WHERE
                    GuruId = @GuruId ";

            //  PARAM
            var dp = new DynamicParameters();
            dp.AddParam("@GuruId", guruId, System.Data.SqlDbType.VarChar);

            //  EXECUTE
            using (var conn = new SqlConnection(_connString))
            {
                conn.Execute(sql, dp);
            }
        }
        public Siswamodel GetData(string guruId)
        {
            //  QUERY
            const string sql = @"
                SELECT  GuruId, GuruName
                FROM    Guru
                WHERE   GuruId = @GuruId ";

            //  PARAM
            var dp = new DynamicParameters();
            dp.AddParam("@GuruId", guruId, System.Data.SqlDbType.VarChar);

            //  EXECUTE
            using (var conn = new SqlConnection(_connString))
            {
                return conn.ReadSingle<Siswamodel>(sql, dp);
            }
        }

        public IEnumerable<Siswamodel> ListData()
        {
            //  QUERY
            const string sql = @"
                SELECT  GuruId, GuruName
                FROM    Guru ";

            //  EXECUTE
            using (var conn = new SqlConnection(_connString))
            {
                return conn.Read<Siswamodel>(sql);
            }
        }
    }
}
