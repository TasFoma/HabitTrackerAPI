namespace HabitTrackerAPI.Models;

public class Habit
{
    public int Id { get; set; } // Первичный ключ
    public string? Name { get; set; } // Название привычки
    public string? Description { get; set; } // Описание
    public int FrequencyPerDay { get; set; } // Сколько раз в день нужно выполнять
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow; // Дата создания
}
