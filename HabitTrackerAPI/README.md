# 🚀 Habit Tracker - Трекер привычек

Full-stack приложение для отслеживания ежедневных привычек

---

## ✨ Особенности

- 📝 Создание и управление привычками
- 🗑️ Удаление привычек  
- 💾 Данные сохраняются в PostgreSQL
- 🐳 Docker контейнеризация
- 🌐 RESTful API

## 🛠️ Технологии

**Backend:** ASP.NET Core, Entity Framework, PostgreSQL  
**Frontend:** HTML, CSS, JavaScript  
**Infrastructure:** Docker, Docker Compose  

---

## 📁 Структура проекта

HabitTrackerAPI/
├── Controllers/ # API контроллеры
├── Models/ # Модели данных
├── Migrations/ # Миграции БД
├── Frontend/ # Фронтенд (HTML/CSS/JS)
│ └── index.html
├── Program.cs # Точка входа
├── appsettings.json # Конфигурация
└── HabitTrackerAPI.csproj

---

## 🚀 Запуск проекта

### Вариант 1: С Docker
```bash
docker-compose up -d