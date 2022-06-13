using CarListApp.Maui.Models;
using SQLite;

namespace CarListApp.Maui.Services
{
    public class CarDatabaseService
    {
        SQLiteConnection conn;
        string _dbPath;
        public string StatusMessage;
        int result = 0;
        public CarDatabaseService(string dbPath)
        {
            _dbPath = dbPath;
        }

        private void Init()
        {
            if (conn != null)
                return;

            conn = new SQLiteConnection(_dbPath);
            conn.CreateTable<Car>();
        }

        public List<Car> GetCars()
        {
            try
            {
                Init();
                return conn.Table<Car>().ToList();
            }
            catch (Exception)
            {
                StatusMessage = "Failed to retrieve data.";
            }

            return new List<Car>();
        }

        public Car GetCar(int id)
        {
            try
            {
                Init();
                return conn.Table<Car>().FirstOrDefault(q => q.Id == id);
            }
            catch (Exception)
            {
                StatusMessage = "Failed to retrieve data.";
            }

            return null;
        }

        public int DeleteCar(int id)
        {
            try
            {
                Init();
                return conn.Table<Car>().Delete(q => q.Id == id);
            }
            catch (Exception)
            {
                StatusMessage = "Failed to delete data.";
            }

            return 0;
        }

        public void AddCar(Car car)
        {
            try
            {
                Init();

                if (car == null)
                    throw new Exception("Invalid Car Record");

                result = conn.Insert(car);
                StatusMessage = result == 0 ? "Insert Failed" : "Insert Successful";
            }
            catch (Exception ex)
            {
                StatusMessage = "Failed to Insert data.";
            }
        }

        public void UpdateCar(Car car)
        {
            try
            {
                Init();

                if (car == null)
                    throw new Exception("Invalid Car Record");

                result = conn.Update(car);
                StatusMessage = result == 0 ? "Update Failed" : "Update Successful";
            }
            catch (Exception ex)
            {
                StatusMessage = "Failed to Update data.";
            }
        }
    }
}
