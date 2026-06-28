# 🏗️ .NET Clean Architecture Template

Готовый к использованию шаблон для создания микросервисов на .NET с архитектурой Clean Architecture.

### Sergey Zalygin

**👨‍💻 GitHub:** [@Azirit](https://github.com/Azirit)

## 📋 Что создаёт шаблон

При использовании команды `dotnet new Capi -n MyProject` создаётся следующая структура:

```
MyProject/
├── README.md                 # Инструкции по проекту
├── MyProject.API/            # Слой Web API
├── MyProject.Application/    # Бизнес-логика
├── MyProject.Domain/         # Доменные модели
└── MyProject.Infrastructure/ # Данные и внешние сервисы
```

## 🚀 Быстрый старт

### 1. Добавить источник GitHub Packages

Создайте **[Personal Access Token](https://github.com/settings/tokens/new)** на GitHub с правами `read:packages` и выполните:

```bash
dotnet nuget add source https://nuget.pkg.github.com/Azirit/index.json \
  --name github-azirit \
  --username Azirit \
  --password <YOUR_PERSONAL_ACCESS_TOKEN> \
  --store-password-in-clear-text
```

### 2. Установить шаблон

```bash
dotnet new install zalsergey.cleanarchitecture.template
```

### 3. Использовать шаблон

```bash
# Создать новый проект
dotnet new Capi -n MyMicroservice

# Перейти в проект и запустить
cd MyMicroservice
dotnet build
dotnet run --project MyMicroservice.API
```

## 🛠️ Управление шаблоном

- Проверить установку:
  ```bash
  dotnet new list
  ```
- Обновить шаблон:
  ```bash
  dotnet new install zalsergey.cleanarchitecture.template --force
  ```
- Удалить шаблон:
  ```bash
  dotnet new uninstall zalsergey.cleanarchitecture.template
  ```
- Удалить источник:
  ```bash
  dotnet nuget remove source github-azirit
  ```

## 📚 Дополнительные команды

```bash
# Посмотреть все источники NuGet
dotnet nuget list source
```

## 📦 Публикация новых версий (для автора)

1. Внесите изменения в шаблон:
   - Отредактируйте файлы в `working/content/Capi/`
   - Обновите `PackageVersion` в `Template.csproj`
2. Закоммитьте и создайте тег:

   ```bash
   git add .
   git commit -m "Update template: добавлена новая функциональность"
   git push origin master

   # Создать и запушить тег версии
   git tag v1.0.0
   git push origin v1.0.0
   ```

3. Автоматическая публикация  
   GitHub Actions автоматически опубликует пакет в GitHub Packages при создании тега.

   Проверить публикацию: **Actions** → статус workflow, **Packages** → новая версия.
