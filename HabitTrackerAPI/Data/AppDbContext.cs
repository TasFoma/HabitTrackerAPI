using Microsoft.EntityFrameworkCore;

namespace HabitTrackerAPI.Models;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }

    public DbSet<Habit> Habits { get; set; } // Создает таблицу Habits в БД
}