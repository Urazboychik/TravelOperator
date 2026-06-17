namespace TravelOperator.Models;

public record TourCatalogItem(
    string Slug,
    string Name,
    string Place,
    string Duration,
    string Price,
    string Season,
    string Level,
    string Rating,
    string Description,
    string[] Tags,
    string[] Images,
    string[] Program,
    string Includes);

public static class TourCatalog
{
    public static IReadOnlyList<TourCatalogItem> Items { get; } =
    [
        new(
            "baikal-ice-olkhon",
            "Байкал: лед и Ольхон",
            "Россия, Байкал",
            "7 дней",
            "96 000 ₽",
            "февраль - март",
            "Комфорт",
            "4.9",
            "Зимний Байкал с прозрачным льдом, гротами, мысом Хобой и камерными вечерами на Ольхоне.",
            ["ледовые пещеры", "Ольхон", "хивус"],
            [
                TourImageAssets.BaikalIce,
                TourImageAssets.BaikalOlkhon,
                TourImageAssets.BaikalShamanka
            ],
            ["Иркутск и переезд к Малому морю", "Ледовые гроты и прогулка по прозрачному льду", "Хивус, Ольхон и мыс Хобой", "Этно-ужин и возвращение"],
            "проживание, трансферы, гид, завтраки, экскурсии по программе"),
        new(
            "altai-adventure",
            "Алтай Adventure",
            "Россия, Алтай",
            "9 дней",
            "146 000 ₽",
            "июнь - сентябрь",
            "Активный",
            "4.8",
            "Горные перевалы, бирюзовые озера, рафтинг и lodge-отели среди алтайских пейзажей.",
            ["горы", "рафтинг", "lodge"],
            [
                TourImageAssets.AltaiMountains,
                TourImageAssets.AltaiRiver,
                TourImageAssets.AltaiRoad
            ],
            ["Горно-Алтайск и заселение", "Чуйский тракт и панорамные остановки", "Рафтинг и треккинг к озерам", "Свободный день в lodge-отеле"],
            "проживание, трансферы, инструкторы, страховка, завтраки"),
        new(
            "kamchatka-volcano",
            "Камчатка: вулканы",
            "Россия, Камчатка",
            "10 дней",
            "248 000 ₽",
            "июль - сентябрь",
            "Экспедиция",
            "4.9",
            "Вулканы, Тихий океан, термальные источники и вертолетная опция в Долину гейзеров.",
            ["вулканы", "океан", "термы"],
            [
                TourImageAssets.KamchatkaVolcano,
                TourImageAssets.KamchatkaOcean,
                TourImageAssets.KamchatkaThermal
            ],
            ["Петропавловск-Камчатский", "Подъем к вулканическим плато", "Океанская прогулка", "Термальные источники"],
            "гиды, трансферы, проживание, завтраки, групповое снаряжение"),
        new(
            "dagestan-canyon",
            "Дагестан: горы и Каспий",
            "Россия, Дагестан",
            "6 дней",
            "82 000 ₽",
            "апрель - октябрь",
            "Легкий",
            "4.7",
            "Сулакский каньон, древние аулы, бархан Сарыкум, Каспий и кавказская кухня.",
            ["каньон", "аулы", "гастрономия"],
            [
                TourImageAssets.DagestanCanyon,
                TourImageAssets.DagestanDune,
                TourImageAssets.DagestanCaspian
            ],
            ["Махачкала и бархан Сарыкум", "Сулакский каньон", "Горные аулы", "Каспий и гастро-вечер"],
            "отели, гид, трансферы, завтраки, дегустации"),
        new(
            "karelia-weekend",
            "Карелия Weekend",
            "Россия, Карелия",
            "4 дня",
            "54 000 ₽",
            "круглый год",
            "Легкий",
            "4.8",
            "Рускеала, северные леса, водопады и короткая перезагрузка на природе.",
            ["Рускеала", "лес", "weekend"],
            [
                TourImageAssets.KareliaRuskeala,
                TourImageAssets.KareliaForest,
                TourImageAssets.KareliaWaterfall
            ],
            ["Сортавала", "Горный парк Рускеала", "Водопады и лесные маршруты", "Свободное утро"],
            "отель, завтраки, экскурсии, трансферы"),
        new(
            "sochi-family-resort",
            "Сочи Family Resort",
            "Россия, Сочи",
            "8 дней",
            "118 000 ₽",
            "май - октябрь",
            "Семейный",
            "4.6",
            "Море, Красная Поляна, семейные экскурсии и проверенные отели без лишней суеты.",
            ["море", "семьи", "отель 4*"],
            [
                TourImageAssets.SochiSea,
                TourImageAssets.SochiResort,
                TourImageAssets.SochiMountains
            ],
            ["Заселение у моря", "Красная Поляна", "Морская прогулка", "Свободные дни для семьи"],
            "отель, завтраки, трансферы, экскурсии"),
        new(
            "cappadocia-premium",
            "Турция: Каппадокия Премиум",
            "Турция, Каппадокия",
            "6 дней",
            "132 000 ₽",
            "апрель - ноябрь",
            "Премиум",
            "4.9",
            "Бутик-отели в скалах, рассветные шары, долины Каппадокии и камерные дегустации.",
            ["шары", "бутик", "долины"],
            [
                TourImageAssets.CappadociaBalloons,
                TourImageAssets.CappadociaValley,
                TourImageAssets.CappadociaHotel
            ],
            ["Стамбул или Кайсери", "Долины Каппадокии", "Рассвет с воздушными шарами", "Бутик-дегустация"],
            "бутик-отели, завтраки, трансферы, экскурсии"),
        new(
            "georgia-wine-route",
            "Грузия Wine Route",
            "Грузия",
            "7 дней",
            "104 000 ₽",
            "май - октябрь",
            "Гастро",
            "4.8",
            "Кахетия, Тбилиси, горные виды, винодельни и маршруты без туристической суеты.",
            ["вино", "Кахетия", "горы"],
            [
                TourImageAssets.GeorgiaTbilisi,
                TourImageAssets.GeorgiaKakheti,
                TourImageAssets.GeorgiaMountains
            ],
            ["Тбилиси", "Кахетия и винодельни", "Горные панорамы", "Гастро-вечер"],
            "отели, завтраки, дегустации, трансферы"),
        new(
            "uzbekistan-silk-road",
            "Узбекистан Silk Road",
            "Узбекистан",
            "8 дней",
            "112 000 ₽",
            "март - ноябрь",
            "Культура",
            "4.7",
            "Самарканд, Бухара, Хива, восточные базары, ремесленные мастерские и комфортные переезды.",
            ["Самарканд", "история", "базары"],
            [
                TourImageAssets.UzbekistanRegistan,
                TourImageAssets.UzbekistanBukhara,
                TourImageAssets.UzbekistanKhiva
            ],
            ["Самарканд", "Бухара", "Хива", "Ремесленные мастерские"],
            "отели, скоростные поезда, гиды, завтраки")
    ];
}
