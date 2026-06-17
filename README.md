<div align="center">

<img src=".github/assets/banner.svg" alt="TravelOperator" width="100%"/>

<br/><br/>

# TravelOperator

**Современная веб-платформа для туристического оператора**  
Витрина туров, B2B-презентация и административная панель в одном приложении.

<br/>

**Дипломный проект** · КГАПОУ «ККОТИП» · разработчик **Уразбой Шеркулов**

<br/>

[![Live Demo](https://img.shields.io/badge/🌍_Live_Demo-Hugging_Face-FFD21E?style=for-the-badge&logo=huggingface&logoColor=black)](https://krammyyds-traveloperator.hf.space)
[![.NET 8](https://img.shields.io/badge/.NET-8.0-512BD4?style=for-the-badge&logo=dotnet&logoColor=white)](https://dotnet.microsoft.com/)
[![ASP.NET Core MVC](https://img.shields.io/badge/ASP.NET_Core-MVC-0EA5E9?style=for-the-badge)](https://learn.microsoft.com/aspnet/core/mvc/)
[![EF Core](https://img.shields.io/badge/Entity_Framework-Core-6DB33F?style=for-the-badge)](https://learn.microsoft.com/ef/core/)
[![SQLite](https://img.shields.io/badge/SQLite-DB-003B57?style=for-the-badge&logo=sqlite&logoColor=white)](https://www.sqlite.org/)
[![Docker](https://img.shields.io/badge/Docker-Ready-2496ED?style=for-the-badge&logo=docker&logoColor=white)](https://www.docker.com/)

<br/>

[Открыть демо](https://krammyyds-traveloperator.hf.space) · [ER-модель](#-er-модель-базы-данных) · [Схемы](#-схемы-и-диаграммы) · [Быстрый старт](#-быстрый-старт) · [Автор](#-автор)

</div>

---

## О проекте

**TravelOperator** — дипломный проект веб-приложения для автоматизации работы туроператора, выполненный в **КГАПОУ «ККОТИП»**. Система объединяет публичную витрину, каталог из **9 направлений**, страницу тура с программой по дням и операционную админ-панель с KPI, заявками и финансовыми срезами.

Проект демонстрирует полный цикл: от выбора тура туристом до аналитики для руководителя.

| Роль | Что видит пользователь |
|------|------------------------|
| **Турист** | Главная, каталог, карточка тура, учебная заявка |
| **Предприниматель** | B2B-страница с модулями CRM, финансов и партнёрского портала |
| **Менеджер** | Админ-панель: продажи, туры, операции, финансы |
| **Руководитель** | KPI: выручка, загрузка, свободные места, воронка заявок |

| Показатель | Значение |
|------------|----------|
| Направлений в каталоге | 9 |
| Фотографий туров | 69 (локально в `wwwroot`) |
| Дней программы | от 4 до 10 на тур |
| Таблиц в SQLite | 3 |
| Вкладок админ-панели | 6 |
| Демо-заявок в БД | 3 (New / Negotiation / Confirmed) |

---

## Скриншоты

<table>
  <tr>
    <td width="50%" align="center">
      <img src=".github/assets/preview-home.png" alt="Главная страница" width="100%"/>
      <br/><sub><b>Главная</b> — витрина и поиск направлений</sub>
    </td>
    <td width="50%" align="center">
      <img src=".github/assets/preview-catalog.png" alt="Каталог туров" width="100%"/>
      <br/><sub><b>Каталог</b> — 9 направлений с карточками</sub>
    </td>
  </tr>
  <tr>
    <td width="50%" align="center">
      <img src=".github/assets/preview-tour.png" alt="Страница тура" width="100%"/>
      <br/><sub><b>Тур</b> — программа по дням и уникальные фото</sub>
    </td>
    <td width="50%" align="center">
      <img src=".github/assets/preview-admin.png" alt="Админ-панель" width="100%"/>
      <br/><sub><b>Админка</b> — обзор, метрики и вкладки</sub>
    </td>
  </tr>
</table>

<details>
<summary><b>Админ-панель: вход и продажи</b></summary>
<br/>
<table>
  <tr>
    <td width="50%" align="center">
      <img src=".github/assets/preview-login.png" alt="Вход в админку" width="100%"/>
      <br/><sub><b>Вход</b> — авторизация по паролю</sub>
    </td>
    <td width="50%" align="center">
      <img src=".github/assets/preview-sales.png" alt="Раздел продаж" width="100%"/>
      <br/><sub><b>Продажи</b> — воронка заявок</sub>
    </td>
  </tr>
</table>
</details>

---

## Возможности

- **Публичная витрина** с адаптивной вёрсткой и тёмной премиальной темой
- **Каталог из 9 туров**: Байкал, Алтай, Камчатка, Сочи, Грузия, Каппадокия, Дагестан, Карелия, Узбекистан
- **Программа 4–10 дней** с отдельным фото на каждый день (`ProgramImages`)
- **69 локальных фотографий** в `wwwroot/images/tours/` — без внешних CDN
- **Админ-панель** с 6 вкладками: Обзор, Продажи, Туры, Операции, Финансы, Система
- **SQLite + EF Core** с автосозданием БД и демо-данными при старте
- **Сессионная авторизация** администратора с CSRF-защитой
- **Docker** и CI/CD на Hugging Face Spaces

---

## Архитектура

```mermaid
flowchart TB
    subgraph Client["Браузер"]
        UI[HTML / CSS / admin.js]
    end

    subgraph App["ASP.NET Core 8 MVC"]
        HC[HomeController]
        RV[Razor Views]
        VM[DashboardViewModel]
        TC[TourCatalog]
    end

    subgraph Data["Данные"]
        DB[(SQLite)]
        EF[EF Core DbContext]
    end

    UI --> HC
    HC --> RV
    HC --> VM
    HC --> TC
    HC --> EF
    EF --> DB
    TC -. маркетинг .-> RV
    DB -. операции .-> VM
```

<img src=".github/assets/diagram-architecture.png" alt="Схема архитектуры TravelOperator" width="100%"/>

---

## ER-модель базы данных

Операционные данные хранятся в SQLite (`traveloperator.db`). Маркетинговый каталог `TourCatalog` вынесен в статический класс и не дублируется в БД.

```mermaid
erDiagram
    TOUR_PACKAGE {
        int Id PK
        string Name
        string Destination
        string TourType
        date StartDate
        date EndDate
        decimal PricePerPerson
        int Capacity
        int BookedSeats
        string Status
    }

    PARTNER_AGENCY {
        int Id PK
        string Name
        string City
        string ContactPerson
        string Email
        decimal CommissionRate
        int ActiveRequests
    }

    BOOKING_REQUEST {
        int Id PK
        string CustomerName
        string TourName
        string AgencyName
        int Travelers
        decimal TotalAmount
        string Stage
        datetime CreatedAt
    }

    TOUR_PACKAGE ||--o{ BOOKING_REQUEST : "TourName (логическая связь)"
    PARTNER_AGENCY ||--o{ BOOKING_REQUEST : "AgencyName (логическая связь)"
```

<img src=".github/assets/er-model.png" alt="ER-модель базы данных traveloperator.db" width="85%"/>

### Таблица `Tours` → `TourPackage`

| Поле | Тип | Описание |
|------|-----|----------|
| `Id` | int | Первичный ключ |
| `Name` | string | Название тура |
| `Destination` | string | Направление |
| `TourType` | string | Тип тура |
| `StartDate` / `EndDate` | DateOnly | Даты заезда и выезда |
| `PricePerPerson` | decimal | Цена за человека |
| `Capacity` | int | Квота мест |
| `BookedSeats` | int | Забронировано мест |
| `Status` | string | Статус (`Active`, `Hot` и др.) |

### Таблица `Agencies` → `PartnerAgency`

| Поле | Тип | Описание |
|------|-----|----------|
| `Id` | int | Первичный ключ |
| `Name` | string | Название агентства |
| `City` | string | Город |
| `ContactPerson` | string | Контактное лицо |
| `Email` | string | E-mail |
| `CommissionRate` | decimal | Комиссия, % |
| `ActiveRequests` | int | Активные заявки |

### Таблица `BookingRequests` → `BookingRequest`

| Поле | Тип | Описание |
|------|-----|----------|
| `Id` | int | Первичный ключ |
| `CustomerName` | string | Имя клиента |
| `TourName` | string | Название тура |
| `AgencyName` | string | Партнёрский канал |
| `Travelers` | int | Число туристов |
| `TotalAmount` | decimal | Сумма заявки |
| `Stage` | string | Стадия воронки |
| `CreatedAt` | DateTime | Дата создания (UTC) |

### Стадии заявок

| Stage | Отображение в UI | Смысл |
|-------|------------------|-------|
| `New` | Новая | Заявка только поступила |
| `Negotiation` | Переговоры | Менеджер ведёт диалог с клиентом |
| `Confirmed` | Подтверждено | Сделка закрыта |

---

## Схемы и диаграммы

### Сценарий бронирования

```mermaid
sequenceDiagram
    actor T as Турист
    participant C as Каталог Offers
    participant P as Страница Tour
    participant M as Модальное окно
    participant A as Админ-панель

    T->>C: Открыть /Home/Offers
    C->>P: Перейти по slug тура
    P->>M: Нажать «Забронировать»
    M->>T: Учебное уведомление об успехе
    Note over M: Запись в SQLite не создаётся (учебный режим)
    A->>A: Менеджер видит заявки из DemoData
```

<img src=".github/assets/diagram-booking-flow.png" alt="Сценарий оформления заявки" width="90%"/>

### Маршруты приложения

| Маршрут | Представление | Назначение |
|---------|---------------|------------|
| `/Home/Customer` | Customer.cshtml | Главная витрина |
| `/Home/Offers` | Offers.cshtml | Каталог туров |
| `/Home/Tour?id={slug}` | Tour.cshtml | Карточка тура |
| `/Home/Business` | Business.cshtml | B2B-презентация |
| `/Home/Admin` | Admin.cshtml | Админ-панель |
| `POST /Home/AdminLogin` | — | Вход администратора |

### Вкладки админ-панели

| Вкладка | Содержимое |
|---------|------------|
| **Обзор** | KPI, модульная доска, операционная лента |
| **Продажи** | Таблица `BookingRequest`, стадии воронки |
| **Туры** | Список `TourPackage`, загрузка и даты |
| **Операции** | Задачи, поставщики, CRM-модули |
| **Финансы** | Срезы оплат, комиссии, кампании |
| **Система** | Настройки, роли, демо-переключатели |

### Поток деплоя

```mermaid
flowchart LR
    A[GitHub Push] --> B[GitHub Actions]
    B --> C[Docker Build]
    C --> D[Hugging Face Space]
    D --> E[https://krammyyds-traveloperator.hf.space]
```

### Фрагмент контроллера

<img src=".github/assets/code-homecontroller.png" alt="Фрагмент HomeController.cs" width="90%"/>

---

## Стек технологий

| Слой | Технологии |
|------|------------|
| Backend | ASP.NET Core 8, MVC, C# 12 |
| Данные | Entity Framework Core, SQLite |
| Frontend | Razor, HTML5, CSS3, Vanilla JS |
| DevOps | Docker, GitHub Actions, Hugging Face Spaces |
| UI | Кастомный CSS без Bootstrap-шаблонов |

---

## Направления в каталоге

| Тур | Дней | Уровень |
|-----|------|---------|
| Байкал: лед и Ольхон | 7 | Комфорт |
| Алтай Adventure | 9 | Активный |
| Камчатка: вулканы | 10 | Экспедиция |
| Сочи для семьи | 8 | Семейный |
| Грузия: вино и горы | 7 | Гастро |
| Каппадокия | 6 | Премиум |
| Дагестан | 6 | Культура |
| Карелия | 4 | Комфорт |
| Узбекистан Silk Road | 8 | Культура |

---

## Быстрый старт

**Требования:** [.NET SDK 8.0](https://dotnet.microsoft.com/download)

```bash
git clone https://github.com/Urazboychik/TravelOperator.git
cd TravelOperator
dotnet restore
dotnet run
```

Откройте в браузере: **http://localhost:5000**

При первом запуске SQLite-база создаётся автоматически и заполняется демо-данными.

---

## Админ-панель

1. На любой публичной странице нажмите **шестерёнку** в шапке
2. Введите пароль:

```
1254
```

3. Откроется `/Home/Admin` с вкладками продаж, туров и аналитики

---

## Структура проекта

```text
TravelOperator/
├── Controllers/           # HomeController — маршруты и логика
├── Data/                  # DbContext, DemoData.Seed
├── Models/                # TourPackage, BookingRequest, TourCatalog
├── Views/                 # Razor: Customer, Offers, Tour, Admin...
├── wwwroot/
│   ├── css/               # site.css, admin.css
│   ├── js/                # admin.js — вкладки, модалки
│   └── images/tours/      # 69 фото туров + thumbs
├── .github/
│   ├── assets/            # Скриншоты и баннер README
│   └── workflows/         # Деплой HF / Render / Fly.io
├── Dockerfile
└── Program.cs
```

---

## Деплой

### Hugging Face Spaces (рекомендуется)

**Live:** [krammyyds-traveloperator.hf.space](https://krammyyds-traveloperator.hf.space)

1. Токен: [huggingface.co/settings/tokens](https://huggingface.co/settings/tokens) (право **write**)
2. GitHub → Settings → Secrets → `HF_TOKEN`
3. Push в `main` или Actions → **Deploy to Hugging Face Space**

### Локальный публичный URL (без регистрации)

```powershell
powershell -ExecutionPolicy Bypass -File .\start-public.ps1
```

Поднимает туннель **localhost.run** — адрес появится в консоли.

### Render / Fly.io

См. workflow-файлы в `.github/workflows/` и `fly.toml`.

---

## Автор

<div align="center">

### Уразбой Шеркулов

**Разработчик** · дипломный проект  
**КГАПОУ «ККОТИП»**  
*Разработка веб-приложения для автоматизации работы туристического оператора*

<br/>

[![GitHub](https://img.shields.io/badge/GitHub-Urazboychik-181717?style=for-the-badge&logo=github)](https://github.com/Urazboychik)
[![Live Demo](https://img.shields.io/badge/Demo-TravelOperator-0EA5E9?style=for-the-badge)](https://krammyyds-traveloperator.hf.space)

</div>

| | |
|---|---|
| **Учебное заведение** | КГАПОУ «ККОТИП» |
| **Разработчик** | Уразбой Шеркулов |
| **Тип работы** | Дипломный проект (ВКР) |
| **Тема** | Веб-платформа TravelOperator для туроператора |
| **Репозиторий** | [github.com/Urazboychik/TravelOperator](https://github.com/Urazboychik/TravelOperator) |
| **Демо** | [krammyyds-traveloperator.hf.space](https://krammyyds-traveloperator.hf.space) |

---

<div align="center">

**Если проект полезен — поставьте звезду на GitHub**

<br/>

[![GitHub stars](https://img.shields.io/github/stars/Urazboychik/TravelOperator?style=social)](https://github.com/Urazboychik/TravelOperator/stargazers)

<br/>

<sub>КГАПОУ «ККОТИП» · Уразбой Шеркулов · ASP.NET Core 8</sub>

</div>
