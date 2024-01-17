# Delivery_WEB_API

Web-приложение для приемки заказа на доставку

## Требования

1. **.NET SDK 8.0**: Убедитесь, что у вас установлен .NET SDK версии 8.0. ( https://dotnet.microsoft.com/en-us/download/visual-studio-sdks )

2. **База данных MSSQL Server**: Проект использует локальную базу данных MSSQL Server. Убедитесь, что у вас установлен и настроен MSSQL Server.

## Установка и Запуск

1. **Клонирование репозитория**: Выполните следующую команду для клонирования репозитория:

    ```bash
    git clone https://github.com/qweabuzer/Delivery_WEB_API.git
    ```

2. **Открытие проекта**: Откройте проект в вашей среде разработки (например, Visual Studio).

3. **Настройка строки подключения**: Отредактируйте файл `appsettings.json` и укажите корректную строку подключения к вашей локальной базе данных MSSQL Server.

4. **Миграции БД**: Выполните миграции для создания структуры базы данных:

    ```bash
    dotnet ef database update
    ```

5. **Запуск проекта**: Запустите проект из вашей среды разработки или выполните следующую команду:

    ```bash
    dotnet run
    ```

6. **Открытие в браузере**: После успешного запуска, откройте браузер и перейдите по адресу (( https://localhost:7177 ) или ( http://localhost:5062 ).

## Пакеты NuGet

- Microsoft.EntityFrameworkCore
- Microsoft.EntityFrameworkCore.Design
- Microsoft.EntityFrameworkCore.SqlServer

