using BFS_SisControl.Shared;
using Microsoft.AspNetCore.Components;
using System.Net.Http.Json;

namespace BFS_SisControl.Client.Servicos.ServicoPessoa
{
    public class ServicoPessoa : IServicoPessoa
    {
        private readonly NavigationManager _navigationManager;
        private readonly HttpClient _http;

        public ServicoPessoa(NavigationManager navigationManager, HttpClient http)
        {
            _navigationManager = navigationManager;
            _http = http;
        }

        public List<TbPessoa> TbPessoas { get; set; } = new List<TbPessoa>();

        public async Task CreatePessoa(TbPessoa pessoa)
        {
            var result = await _http.PostAsJsonAsync("api/pessoa", pessoa);
            await SetPessoas(result);
        }

        private async Task SetPessoas(HttpResponseMessage result)
        {
            var resposta = await result.Content.ReadFromJsonAsync<List<TbPessoa>>();
            TbPessoas = resposta;
            _navigationManager.NavigateTo("api/pessoas");
        }

        public async Task DeletePessoa(int id)
        {
            var result = await _http.DeleteAsync($"api/pessoa/{id}");
            await SetPessoas(result);
        }
        public async Task UpdatePessoa(TbPessoa pessoa)
        {
            var result = await _http.PutAsJsonAsync($"api/pessoa/{pessoa.Id}", pessoa);
            await SetPessoas(result);
        }
        public async Task<TbPessoa> GetPessoa(int id)
        {
            var result = await _http.GetFromJsonAsync<TbPessoa>($"api/pessoa/{id}");
            if (result != null)
                return result;
            throw new Exception("Não foi possível encontrar o cadastro");
        }

        public async Task GetPessoas()
        {
            var result = await _http.GetFromJsonAsync<List<TbPessoa>>("api/pessoas");
            if (result != null)
                TbPessoas = result;
        }



    }
}