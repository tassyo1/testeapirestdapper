using Dapper;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace TesteAPIRESTDapper.Data
{
    public class CotacoesDAO
    {
        private IConfiguration _configuracoes;
        public CotacoesDAO(IConfiguration config)
        {
            _configuracoes = config;
        }

        public Cotacao Obter(string idMoeda)
        {
            using(SqlConnection conexao = new SqlConnection(_configuracoes.GetConnectionString("BaseCotacoes")))
            {
                return conexao.QueryFirstOrDefault<Cotacao>(
                    "SELECT "+
                        "Sigla, "+
                        "NomeMoeda, "+
                        "UltimaCotacao, "+
                        "Valor "+
                    "FROM dbo.Cotacoes "+
                    "WHERE Sigla = @SiglaMoeda ", new { SiglaMoeda = idMoeda}
                    );
            }
        }
    }
}
