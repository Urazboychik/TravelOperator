namespace TravelOperator.Models;

public class DashboardViewModel
{
    public IReadOnlyList<TourPackage> Tours { get; init; } = [];

    public IReadOnlyList<BookingRequest> Requests { get; init; } = [];

    public IReadOnlyList<PartnerAgency> Agencies { get; init; } = [];

    public decimal RevenuePipeline => Requests.Sum(request => request.TotalAmount);

    public int ConfirmedTravelers => Requests
        .Where(request => request.Stage.Equals("Confirmed", StringComparison.OrdinalIgnoreCase))
        .Sum(request => request.Travelers);

    public int AvailableSeats => Tours.Sum(tour => tour.AvailableSeats);

    public int OpenRequests => Requests.Count(request => !request.Stage.Equals("Confirmed", StringComparison.OrdinalIgnoreCase));

    public decimal PaidRevenue => Requests
        .Where(request => request.Stage.Equals("Confirmed", StringComparison.OrdinalIgnoreCase))
        .Sum(request => request.TotalAmount);

    public double AverageLoad => Tours.Count == 0
        ? 0
        : Tours.Average(tour => (double)tour.BookedSeats / tour.Capacity);

    public IReadOnlyList<AdminModule> Modules { get; init; } =
    [
        new("✈", "Каталог туров", "Маршруты, сезоны, цены, квоты", "48 активных позиций", "↑ 12%"),
        new("◈", "Бронирования", "Заявки, ваучеры, списки гостей", "126 операций", "24 новых"),
        new("◎", "CRM и лиды", "Клиенты, сегменты, история касаний", "3 840 контактов", "18 горячих"),
        new("₽", "Финансы", "Счета, оплаты, комиссии, долги", "7,8 млн ₽", "92% оплат"),
        new("▣", "Поставщики", "Отели, трансферы, гиды, ограничения продаж", "64 контракта", "5 рисков"),
        new("↗", "Партнерский портал", "Агентские цены, лимиты, промокоды", "31 агент", "8 заявок")
    ];

    public IReadOnlyList<OperationTask> OperationTasks { get; init; } =
    [
        new("Подтвердить квоты отеля Cosmos Collection", "Контракты", "Сегодня 16:00", "Высокий"),
        new("Сформировать список гостей по Altai Adventure", "Бронирования", "Завтра 10:30", "Средний"),
        new("Проверить задолженность Sun Route", "Финансы", "Сегодня", "Высокий"),
        new("Запустить рассылку раннего бронирования", "Маркетинг", "Пятница", "Низкий")
    ];

    public IReadOnlyList<SupplierStatus> Suppliers { get; init; } =
    [
        new("Grand Baikal Hotel", "Отель", "Подтверждено", 96, "12 номеров в квоте"),
        new("AeroTransfer Pro", "Транспорт", "Внимание", 72, "нужно подтвердить график водителей"),
        new("Local Guides Altai", "Гиды", "Подтверждено", 89, "6 гидов доступны"),
        new("Visa Support Center", "Визы", "На проверке", 64, "требуется обновить SLA")
    ];

    public IReadOnlyList<FinanceSnapshot> Finance { get; init; } =
    [
        new("Оплачено клиентами", 4_280_000, "+18%"),
        new("К оплате поставщикам", 1_740_000, "-6%"),
        new("Комиссии агентствам", 620_000, "+9%"),
        new("Просроченная дебиторка", 310_000, "-14%")
    ];

    public IReadOnlyList<MarketingCampaign> Campaigns { get; init; } =
    [
        new("Лето на Черном море", "Email + Telegram", 48, 12),
        new("Алтай для корпоративных групп", "Партнерский портал", 34, 7),
        new("Золотое кольцо Премиум", "Ретаргетинг", 29, 5)
    ];

    public IReadOnlyList<ActivityEvent> Activity { get; init; } =
    [
        new("Создана групповая заявка на 12 туристов", "2 минуты назад"),
        new("Партнер Travel North получил агентский прайс", "18 минут назад"),
        new("Обновлена сезонная цена Black Sea Family", "1 час назад"),
        new("Финансы подтвердили оплату Altai Adventure", "3 часа назад")
    ];
}

public record AdminModule(string Icon, string Title, string Description, string Metric, string Accent);

public record OperationTask(string Title, string Department, string Due, string Priority);

public record SupplierStatus(string Name, string Type, string Status, int Score, string Note);

public record FinanceSnapshot(string Title, decimal Amount, string Trend);

public record MarketingCampaign(string Name, string Channel, int Leads, int Bookings);

public record ActivityEvent(string Text, string Time);
