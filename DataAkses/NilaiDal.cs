using Dapper;
using Nuna.Lib.DataAccessHelper;
using sekolahku_jude.Model;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;

namespace sekolahku_jude.DataAkses
{
    public class NilaiDal
    {
        private string _connstring;

        public NilaiDal()
        {
            _connstring = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
        }

        public void insert (NilaiModel model)
        {
            const string sql = @"
                             INSERT INTO NilaiSiswa (SiswaId,KelasId,MapelId,Nilai)
                             VALUES (@SiswaId,@KelasId,@MapelId,@Nilai)";

            var dp = new DynamicParameters();
            dp.AddParam("@SiswaId", model.SiswaId, System.Data.SqlDbType.VarChar);
            dp.AddParam("@KelasId", model.KelasId, System.Data.SqlDbType.VarChar);
            dp.AddParam("@MapelId", model.MapelId, System.Data.SqlDbType.VarChar);
            dp.AddParam("@Nilai", model.Nilai, System.Data.SqlDbType.VarChar);

            using (var conn = new SqlConnection(_connstring))
            {
                conn.Execute(sql, dp);
            }
        }

        public void Delete(string SiswaId, string KelasId)
        {
            const string sql = @"
                DELETE FROM
                    NilaiSiswa
                WHERE
                    SiswaId = @SiswaId
                    KelasId = @KelasId";
            var dp = new DynamicParameters();
            dp.AddParam("@SiswaId", SiswaId, System.Data.SqlDbType.VarChar);
            dp.AddParam("@KelasId", KelasId, System.Data.SqlDbType.VarChar);

            using (var conn = new SqlConnection(_connstring))
            {
                conn.Execute(sql, dp);
            }
        }

        public IEnumerable<NilaiModel> Listdata(string SiswaId, string KelasId)
        {
            const string sql = @"
                               SELECT 
                                    aa.SiswaId, aa.KelasId, aa.MapelId, aa.Nilai
                                     ISNULL(bb.SiswaName,'')SiswaName
                                     ISNULL(cc.KelasName,'')KelasName
                                     ISNULL(dd.MapelName,'')MapelName
                               FROM
                                    NilaiSiswa aa 
                                    LEFTJOIN Kelas bb ON aa.KelasId = bb.KelasId
                                    LEFTJOIN Mapel cc ON aa.MapelId = cc.MapelId
                                    LEFTJOIN Siswa dd ON aa.SiswaId = dd.SiswalId
                              WHERE
                                    aa.KelasId = @KelasId
                                    AND aa.Siswa = @SiswaId";

            var dp = new DynamicParameters();
            dp.AddParam("@SiswaId", SiswaId, System.Data.SqlDbType.VarChar);
            dp.AddParam("@KelasId", KelasId, System.Data.SqlDbType.VarChar);

            using (var conn = new SqlConnection(_connstring))
            {
                return conn.Read<NilaiModel>(sql, dp);
            }

        }



    }
}
