using BFS_SisControl.Shared;

namespace BFS_SisControl.Client.Servicos
{
    public interface IServicoPessoa
    {
        List<TbPessoa> TbPessoas { get; set; }

        Task GetPessoas();
        Task<TbPessoa> GetPessoa(int id);
        Task CreatePessoa(TbPessoa pessoa);
        Task UpdatePessoa(TbPessoa pessoa);
        Task DeletePessoa(int id);

    }
}