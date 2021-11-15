using System.Collections.Generic;
using System.Threading.Tasks;
using MVP.Models;
using SQLite;

namespace MVP.Database
{
    public class DatabaseQuerys
    {
        #region Creacion - Tabla - DbPath 
        readonly SQLiteAsyncConnection _database;

        public DatabaseQuerys(string dbPath)
        {
            _database = new SQLiteAsyncConnection(dbPath);


            #region Creacion - Tablas
            // podría crear una tabla para cada resultado
            //_database.CreateTableAsync<UserModel>().Wait();
            _database.CreateTableAsync<ResultadoModel>().Wait();
            #endregion
        }

        #endregion


        #region CRUD - RESULTADO TABLE

        /* METOD-O SELECT SEARCH BAR()*/
        public Task<ResultadoModel> GetResultadoModelAynsc(int id)
        {
            return _database.Table<ResultadoModel>()
                            .Where(i => i.ResultadoID == id)
                            .FirstOrDefaultAsync();
        }

        /* METOD-O SELECT ()*/
        public Task<List<ResultadoModel>> GetResultadoModel()
        {
            return _database.Table<ResultadoModel>().ToListAsync();
        }

        /* METOD-O GUARDAR Y ACTUALIZAR ()*/
        public Task<int> SaveResultadoModelAsync(ResultadoModel resultadoModel)
        {
            if (resultadoModel.ResultadoID != 0)
            {
                return _database.UpdateAsync(resultadoModel);
            }
            else
            {
                return _database.InsertAsync(resultadoModel);
            }
        }

        /* METOD-O ELIMINAR () */
        public Task<int> DeleteResultadoModelAsync(ResultadoModel resultadoModel)
        {
            return _database.DeleteAsync(resultadoModel);
        }

        public Task<List<ResultadoModel>> GetResultadoValidate(string temp, string peso)
        {
            return _database.QueryAsync<ResultadoModel>("SELECT * FROM ResultadoModel WHERE Temperatura = '" + temp + "' AND Peso = '" + peso + "'");
        }

        public Task<List<ResultadoModel>> GetResultadoSignoVital(string temp)
        {
            return _database.QueryAsync<ResultadoModel>("SELECT * FROM ResultadoModel WHERE SignoVital = '" + temp + "'");
        }

        #endregion



    }
}
