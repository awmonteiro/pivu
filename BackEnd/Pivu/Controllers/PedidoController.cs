using Dapper;
using Microsoft.AspNetCore.Mvc;
using Oracle.ManagedDataAccess.Client;
using Pivu.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pivu.Controllers
{
    public class PedidoController : Controller
    {
        public async Task<IActionResult> Index()
        {
            IEnumerable<Cervejaria> cervejarias;
            var PivuDBcn = new OracleConnection("Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521)))(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=XEPDB1)));User Id=pivu;Password=pivu21;");
            using (PivuDBcn)
            {
                cervejarias = await PivuDBcn.QueryAsync<Cervejaria>("SELECT * FROM CERVEJARIA");
            }
            return View(cervejarias);
        }

        public IActionResult Cadastro()
        {
            return View();
        }

        public async Task<IActionResult> CervejariaAsync(int ID)
        {
            IEnumerable<Produto> produtos_cervejaria;
            var PivuDBcn = new OracleConnection("Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521)))(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=XEPDB1)));User Id=pivu;Password=pivu21;");
            using (PivuDBcn)
            {
                var sql = @$"select  p.cervejaria_id_cervejaria,p.nome,p.estilo,p.descricao,p.ibu,p.abv,p.id_produto,c.id_cervejaria,c.nome
                                            from produto p
                                            join cervejaria c on c.id_cervejaria = p.cervejaria_id_cervejaria
                                            where c.id_cervejaria = {ID}";
                produtos_cervejaria = await PivuDBcn.QueryAsync<Produto, Cervejaria, Produto>(sql, (produto, cervejaria) =>
                {
                    produto.Cervejaria = cervejaria;
                    return produto;
                },
                splitOn: "cervejaria_id_cervejaria,id_cervejaria");
            }
            return View(produtos_cervejaria);
        }


        public IActionResult Sacola()
        {
            return View();
        }


        public async Task<IActionResult> DetailsAsync(int id)
        {
            Produto Produto = new Produto();
            Cervejaria Cervejaria = new Cervejaria();
            Tamanho Tamanho = new Tamanho();
            
            IEnumerable<Produto> produto;
            var PivuDBcn = new OracleConnection("Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521)))(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=XEPDB1)));User Id=pivu;Password=pivu21;");
            using (PivuDBcn)
            {
                var sql = @$"select 
                            p.id_produto,p.nome,p.cervejaria_id_cervejaria,p.estilo,p.descricao,p.ibu,p.abv,
                            c.id_cervejaria,c.nome,
                            t.id_tamanho,t.volume                            
                            from produto p
                            join cervejaria c on c.id_cervejaria = p.cervejaria_id_cervejaria
                            join produto_tamanho pt on pt.produto_id_produto = p.id_produto
                            join tamanho t on t.id_tamanho = pt.tamanho_id_tamanho
                            where p.id_produto = {id}";

                produto = await PivuDBcn.QueryAsync<Produto, Cervejaria, Tamanho, Produto>(sql, (produto, cervejaria, tamanho) =>
                {
                    produto.Cervejaria = cervejaria;
                    produto.Tamanho = tamanho;
                    return produto;
                },
                splitOn: "id_produto,id_cervejaria,id_tamanho");
            }
            return PartialView("_DetailsPartial", produto);
        }

    }
}
