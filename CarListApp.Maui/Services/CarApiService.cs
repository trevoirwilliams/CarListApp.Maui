using CarListApp.Maui.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace CarListApp.Maui.Services
{
    public class CarApiService
    {
        HttpClient _httpClient;
        public static string BaseAddress = DeviceInfo.Platform == DevicePlatform.Android ? "http://10.0.2.2:8099" : "http://localhost:8099";
        public string StatusMessage;

        public CarApiService()
        {
            _httpClient = new() { BaseAddress = new Uri(BaseAddress) };
        }

        public async Task <List<Car>> GetCars()
        {
            try
            {
                var response = await _httpClient.GetStringAsync("/cars");
                return JsonConvert.DeserializeObject<List<Car>>(response);
            }
            catch (Exception ex)
            {
                StatusMessage = "Failed to retrieve data.";
            }

            return null;
        }

        public async Task<Car> GetCar(int id)
        {
            try
            {
                var response = await _httpClient.GetStringAsync("/cars/" + id);
                return JsonConvert.DeserializeObject<Car>(response);
            }
            catch (Exception ex)
            {
                StatusMessage = "Failed to retrieve data.";
            }

            return null;
        }

        public async Task AddCar(Car car)
        {
            try
            {
                var response = await _httpClient.PostAsJsonAsync("/cars/", car);
                response.EnsureSuccessStatusCode();
                StatusMessage = "Insert Successful";
            }
            catch (Exception ex)
            {
                StatusMessage = "Failed to add data.";
            }
        }

        public async Task DeleteCar(int id)
        {
            try
            {

                var response = await _httpClient.DeleteAsync("/cars/" + id);
                response.EnsureSuccessStatusCode();
                StatusMessage = "Delete Successful";
            }
            catch (Exception ex)
            {
                StatusMessage = "Failed to delete data.";
            }
        }

        public async Task UpdateCar(int id, Car car)
        {
            try
            {
                var response = await _httpClient.PutAsJsonAsync("/cars/" + id, car);
                response.EnsureSuccessStatusCode();
                StatusMessage = "Update Successful";
            }
            catch (Exception ex)
            {
                StatusMessage = "Failed to update data.";
            }
        }
    }
}
