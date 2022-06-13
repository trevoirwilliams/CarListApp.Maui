using Microsoft.EntityFrameworkCore;

public class CarListDbContext : DbContext
{
    public CarListDbContext(DbContextOptions<CarListDbContext> options) : base(options)
    {

    }

    public DbSet<Car> Cars { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Car>().HasData(
            new Car
            {
                Id = 1,
                Make = "Honda",
                Model = "Fit",
                Vin="ABC"
            },
            new Car
            {
                Id = 2,
                Make = "Honda",
                Model = "Civic",
                Vin = "ABC2"
            },
            new Car
            {
                Id = 3,
                Make = "Honda",
                Model = "Stream",
                Vin = "ABC1"
            },
            new Car
            {
                Id = 4,
                Make = "Nissan",
                Model = "Note",
                Vin = "ABC4"
            },
            new Car
            {
                Id = 5,
                Make = "Nissan",
                Model = "Atlas",
                Vin = "ABC5"
            },
            new Car
            {
                Id = 6,
                Make = "Nissan",
                Model = "Dualis",
                Vin = "ABC6"
            },
            new Car
            {
                Id = 7,
                Make = "Nissan",
                Model = "Murano",
                Vin = "ABC7"
            },
            new Car
            {
                Id = 8,
                Make = "Audi",
                Model = "A5",
                Vin = "ABC8"
            },
            new Car
            {
                Id = 9,
                Make = "BMW",
                Model = "M3",
                Vin = "ABC9"
            },
            new Car
            {
                Id = 10,
                Make = "Jaguar",
                Model = "F-Pace",
                Vin = "ABC10"
            }
        );
    }
}