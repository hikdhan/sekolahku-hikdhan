using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using sekolahku_jude.Model;
using Nuna.Lib.DataAccessHelper;
using Dapper;

namespace sekolahku_jude.DataAkses
{
    public class GuruDal
    {
        private string _connect;
       public GuruDal(){
            _connect = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
        }

        public void Insert(GuruModel model)
        {
            //  QUERY
            const string sql = @"
                INSERT INTO tb_guru
                VALUES (@GuruId, @GuruName)";

            //  PARAM
            var dp = new DynamicParameters();
            dp.AddParam("@GuruId", model.guru_id, System.Data.SqlDbType.VarChar);
            dp.AddParam("@GuruName", model.guru_name, System.Data.SqlDbType.VarChar);

            //  EXECUTE
            using (var conn = new SqlConnection(_connect))
            {
                conn.Execute(sql, dp);
            }
        }

        public void Update(GuruModel model)
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
            dp.AddParam("@GuruId", model.guru_id, System.Data.SqlDbType.VarChar);
            dp.AddParam("@GuruName", model.guru_name, System.Data.SqlDbType.VarChar);

            //  EXECUTE
            using (var conn = new SqlConnection(_connect))
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
            using (var conn = new SqlConnection(_connect))
            {
                conn.Execute(sql, dp);
            }
        }
        public GuruModel GetData(string guruId)
        {
            //  QUERY
            const string sql = @"
                SELECT  guru_nama AS guru_name, guru_id As guru_id
                FROM    tb_guru
                WHERE   guru_id= @GuruId ";

            //  PARAM
            var dp = new DynamicParameters();
            dp.AddParam("@GuruId", guruId, System.Data.SqlDbType.VarChar);

            //  EXECUTE
            using (var conn = new SqlConnection(_connect))
            {
                return conn.ReadSingle<GuruModel>(sql, dp);
            }
        }

        public IEnumerable<GuruModel> ListData()
        {
            //  QUERY
            const string sql = @"
                SELECT  GuruId, GuruName
                FROM    Guru ";

            //  EXECUTE
            using (var conn = new SqlConnection(_connect))
            {
                return conn.Read<GuruModel>(sql);
            }
        }
    }
}
