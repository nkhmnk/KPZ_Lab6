# RecipeBookApp

**RecipeBookApp** — це WinForms-застосунок для зберігання, перегляду, пошуку, редагування та видалення кулінарних рецептів із підтримкою категорій, улюблених рецептів та підключенням до MySQL-бази даних.

##  Функціонал

- Авторизація користувача
- Перегляд списку всіх рецептів
- Фільтрація за категоріями
- Перегляд детальної інформації про рецепт
- Додавання нового рецепту
- Редагування існуючого рецепту
- Видалення рецепту (разом із інгредієнтами та записами в улюблених)
- Пошук рецептів
- Додавання рецепту до улюблених
- Перегляд улюблених рецептів

##  Запуск проєкту локально

### Необхідне середовище

- Windows OS
- Visual Studio 2022+
- MySQL Server
- MySQL Connector for .NET

### Кроки запуску

1. Клонувати репозиторій:

```bash
git clone https://github.com/yourusername/RecipeBookApp.git
```

2. Відкрити проєкт у Visual Studio.

3. Переконатись, що у вас запущено MySQL-сервер.

4. Створити базу даних `recipebookdb` та таблиці (`Recipes`, `RecipeIngredients`, `FavoriteRecipes`, `Users`), використовуючи SQL-скрипти з папки `newBD.sql`.

5. Встановити правильні параметри підключення в `Form1.cs`:

```csharp
string connectionString = "Server=localhost;Database=recipebookdb;Uid=root;Pwd=;";
```

6. Запустити проєкт.

---

##  Programming Principles

У застосунку дотримано наступних принципів програмування:

1. **DRY (Don’t Repeat Yourself)**  
   — Повторювані дії винесено у методи: `LoadRecipes`, `LoadCategories`, `HighlightActiveButton`.

2. **KISS (Keep It Simple, Stupid)**  
   — Простота реалізації (відсутність надлишкових перевантажень, мінімальна кількість залежностей).

3. **SRP (Single Responsibility Principle)**  
   — Кожна форма відповідає за конкретну функціональність (наприклад, `Form1`, `EditRecipeForm`, `AddRecipeForm`).

4. **YAGNI (You Ain’t Gonna Need It)**  
   — Впроваджено тільки необхідний функціонал, без зайвих абстракцій.

5. **Fail Fast**  
   — Винятки ловляться одразу після виникнення (наприклад, при підключенні до БД).

---

##  Design Patterns

У проєкті використано наступні патерни проєктування:

1. **MVC (Model-View-Controller)**  
   - Відокремлення UI (`Form1`, `AddRecipeForm`, `EditRecipeForm`) від логіки роботи з даними (запити до БД).

2. **Repository Pattern (спрощено)**  
   - Методи доступу до БД згруповано у вигляді логічних блоків: `LoadRecipes`, `LoadFavoriteRecipes`, `DeleteRecipe`.

3. **Command Pattern (спрощено, через обробники подій)**  
   - Кнопки виконують певні команди (наприклад, `btnAddRecipe_Click`, `btnDeleteRecipe_Click`).

---

##  Refactoring Techniques

Під час розробки застосовано такі техніки рефакторингу:

1. **Extract Method**  
   — Виділено окремі методи, наприклад, `LoadRecipes`, `LoadCategories`, `DeleteRecipe`.

2. **Rename Method**  
   — Назви методів інформативні: `btnAddRecipe_Click`, `HighlightActiveButton`.

3. **Replace Magic Numbers with Named Constants**  
   — Координати кнопок винесено як параметри.

4. **Decompose Conditional**  
   — Уникнуто вкладених умов через ранній вихід (`return`).

5. **Encapsulate Field**  
   — Використання `private` полів: `loggedInUserId`, `activeCategoryButton`.

---

##  Структура проєкту

```
RecipeBookApp/
│
├── Form1.cs                 # Основна форма з логікою для рецептів
├── AddRecipeForm.cs         # Додавання рецепту
├── EditRecipeForm.cs        # Редагування рецепту
├── RecipeDetailsForm.cs     # Перегляд деталей
├── SearchRecipeForm.cs      # Пошук
├── IngredientAmountForm.cs  # Кількість даного інгрідієнта
├── RegisterForm.cs          # Реєстрація
└── LoginForm.cs             # Вхід
```

---

##  Автор

- **Ім'я:** Надія Хоменко  
- **Варіант:** №27  
- **Мова:** C#, WinForms + MySQL

---
