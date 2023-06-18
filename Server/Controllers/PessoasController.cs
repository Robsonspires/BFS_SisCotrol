
using BFS_SisControl.Server.DataContext;
using BFS_SisControl.Shared;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Runtime.ConstrainedExecution;

namespace BFS_SisControl.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PessoasController : ControllerBase
    {
        private readonly DbContexto _contexto;

        public PessoasController(DbContexto contexto)
        {
            _contexto = contexto;
        }


        [HttpGet("pessoas")]
        public async Task<ActionResult<List<TbPessoa>>> BuscaPessoas()
        {
            var pessoas = await _contexto.TbPessoas.ToListAsync();
            return Ok(pessoas);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<TbPessoa>> BuscaPessoa(int id)
        {
            var pessoa = await _contexto.TbPessoas
                    .FirstOrDefaultAsync(x => x.Id == id);
            if (pessoa == null)
            {
                return NotFound("Não encontramos a pessoa");
            }
            return Ok(pessoa);
        }

        [HttpPost]
        public async Task<ActionResult<List<TbPessoa>>> CreatePessoa(TbPessoa pessoa)
        {
            _contexto.TbPessoas.Add(pessoa);
            await _contexto.SaveChangesAsync();
            return Ok(await BuscaPessoas());
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<List<TbPessoa>>> UpdatePessoa(TbPessoa pessoa, int id)
        {
            var dbPessoa= await _contexto.TbPessoas
                .FirstOrDefaultAsync(x => x.Id == id);
            if (dbPessoa == null)
                return NotFound("Cadastro não encontrado");

            dbPessoa.Nome = pessoa.Nome;
            dbPessoa.DataNascimento = pessoa.DataNascimento;
            dbPessoa.Cpf = pessoa.Cpf;
            dbPessoa.Email = pessoa.Email;
            dbPessoa.Fone = pessoa.Fone;
            dbPessoa.CEP = pessoa.CEP;
            dbPessoa.Endereco = pessoa.Endereco;
            dbPessoa.Complemento = pessoa.Complemento;
            dbPessoa.Bairro = pessoa.Bairro;
            dbPessoa.Cidade = pessoa.Cidade;
            dbPessoa.UF = pessoa.UF;

            await _contexto.SaveChangesAsync();
            return Ok(await GetDbPessoas());
        }

        private async Task<List<TbPessoa>> GetDbPessoas()
        {
            return await _contexto.TbPessoas
                .ToListAsync();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<List<TbPessoa>>> DeletePessoa(int id)
        {
            var dbPessoa = await _contexto.TbPessoas
                .FirstOrDefaultAsync(x => x.Id == id);
            if (dbPessoa == null)
                return NotFound("Cadsatro não encontrado");

            _contexto.Remove(dbPessoa);
            await _contexto.SaveChangesAsync();

            return Ok(await GetDbPessoas());
        }
    }
}