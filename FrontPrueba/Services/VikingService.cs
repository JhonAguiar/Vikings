using SharedModels;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using System.Collections.Generic;
using System;

namespace FrontPrueba.Services
{
    public class VikingService
    {
        private readonly HttpClient _httpClient;

        // URL de la API
        private const string apiUrl = "https://localhost:7002/api/Vikingos";

        public VikingService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        // Obtener la lista de vikingos desde el API
        public async Task<List<Viking>> GetAllVikingos()
        {
            try
            {
                return await _httpClient.GetFromJsonAsync<List<Viking>>(apiUrl);
            }
            catch (HttpRequestException e)
            {
                Console.WriteLine($"Error al obtener los vikingos: {e.Message}");
                return new List<Viking>(); // Devuelve una lista vacía en caso de error
            }
        }

        // Agregar un vikingo usando el API
        public async Task<bool> AddVikingo(Viking vikingo)
        {
            try
            {
                var response = await _httpClient.PostAsJsonAsync(apiUrl, vikingo);
                response.EnsureSuccessStatusCode();
                return true; // Indica éxito
            }
            catch (HttpRequestException e)
            {
                Console.WriteLine($"Error al agregar el vikingo: {e.Message}");
                return false; // Indica fallo
            }
        }

        // Actualizar un vikingo usando el API
        public async Task<bool> UpdateVikingo(Viking vikingo)
        {
            try
            {
                var response = await _httpClient.PutAsJsonAsync($"{apiUrl}/{vikingo.Id}", vikingo);
                response.EnsureSuccessStatusCode();
                return true; // Indica éxito
            }
            catch (HttpRequestException e)
            {
                Console.WriteLine($"Error al actualizar el vikingo: {e.Message}");
                return false; // Indica fallo
            }
        }

        // Eliminar un vikingo usando el API
        public async Task<bool> DeleteVikingo(int id)
        {
            try
            {
                var response = await _httpClient.DeleteAsync($"{apiUrl}/{id}");
                response.EnsureSuccessStatusCode();
                return true; // Indica éxito
            }
            catch (HttpRequestException e)
            {
                Console.WriteLine($"Error al eliminar el vikingo: {e.Message}");
                return false; // Indica fallo
            }
        }
    }
}