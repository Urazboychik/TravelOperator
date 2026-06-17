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
    string[] ProgramImages,
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
            ["Иркутск и переезд к Малому морю", "Ледовые гроты и прогулка по прозрачному льду", "Хивус, Ольхон и мыс Хобой", "Свободный день на Ольхоне", "Ледовая рыбалка и термальные источники", "Этно-ужин и местные традиции", "Возвращение в Иркутск"],
            TourImageAssets.ForProgramDays(
            [
                TourImageAssets.BaikalIce,
                TourImageAssets.BaikalOlkhon,
                TourImageAssets.BaikalShamanka
            ],
            [
                TourImageAssets.BaikalIce,
                TourImageAssets.BaikalOlkhon,
                TourImageAssets.BaikalShamanka,
                TourImageAssets.BaikalIrkutsk
            ],
            7),
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
            ["Горно-Алтайск и заселение", "Чуйский тракт и панорамные остановки", "Рафтинг по Катуни", "Треккинг к горным озёрам", "Подъём к перевалу и смотровые площадки", "Свободный день в lodge-отеле", "Долина рек и каньоны", "Горные маршруты и фотосессии", "Возвращение в Горно-Алтайск"],
            TourImageAssets.ForProgramDays(
            [
                TourImageAssets.AltaiMountains,
                TourImageAssets.AltaiRiver,
                TourImageAssets.AltaiRoad
            ],
            [
                TourImageAssets.AltaiMountains,
                TourImageAssets.AltaiRiver,
                TourImageAssets.AltaiRoad,
                TourImageAssets.AltaiLodge
            ],
            9),
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
            ["Петропавловск-Камчатский", "Подъём к вулканическим плато", "Океанская прогулка по Авачинской бухте", "Термальные источники", "Долина гейзеров (вертолётная опция)", "Морская рыбалка и дегустация", "Восхождение на вулкан", "Свободный день в Петропавловске", "Экскурсия по побережью", "Вылет"],
            TourImageAssets.ForProgramDays(
            [
                TourImageAssets.KamchatkaVolcano,
                TourImageAssets.KamchatkaOcean,
                TourImageAssets.KamchatkaThermal
            ],
            [
                TourImageAssets.KamchatkaVolcano,
                TourImageAssets.KamchatkaOcean,
                TourImageAssets.KamchatkaThermal,
                TourImageAssets.KamchatkaPlateau
            ],
            10),
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
            ["Махачкала и бархан Сарыкум", "Сулакский каньон", "Горные аулы", "Древние крепости и смотровые", "Каспийское побережье", "Гастро-вечер и отъезд"],
            TourImageAssets.ForProgramDays(
            [
                TourImageAssets.DagestanCanyon,
                TourImageAssets.DagestanDune,
                TourImageAssets.DagestanCaspian
            ],
            [
                TourImageAssets.DagestanCanyon,
                TourImageAssets.DagestanDune,
                TourImageAssets.DagestanCaspian,
                TourImageAssets.DagestanAul
            ],
            6),
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
            TourImageAssets.ForProgramDays(
            [
                TourImageAssets.KareliaRuskeala,
                TourImageAssets.KareliaForest,
                TourImageAssets.KareliaWaterfall
            ],
            [
                TourImageAssets.KareliaRuskeala,
                TourImageAssets.KareliaForest,
                TourImageAssets.KareliaWaterfall,
                TourImageAssets.KareliaSortavala
            ],
            4),
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
            ["Заселение у моря", "Красная Поляна", "Морская прогулка", "Дендрарий и парки Сочи", "Свободный день на пляже", "Семейные экскурсии", "SPA и отдых в отеле", "Отъезд"],
            TourImageAssets.ForProgramDays(
            [
                TourImageAssets.SochiSea,
                TourImageAssets.SochiResort,
                TourImageAssets.SochiMountains
            ],
            [
                TourImageAssets.SochiSea,
                TourImageAssets.SochiResort,
                TourImageAssets.SochiMountains,
                TourImageAssets.SochiFamily
            ],
            8),
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
            ["Стамбул или Кайсери, переезд", "Долины Каппадокии", "Рассвет с воздушными шарами", "Подземные города и скальные церкви", "Бутик-дегустация", "Свободное время и вылет"],
            TourImageAssets.ForProgramDays(
            [
                TourImageAssets.CappadociaBalloons,
                TourImageAssets.CappadociaValley,
                TourImageAssets.CappadociaHotel
            ],
            [
                TourImageAssets.CappadociaBalloons,
                TourImageAssets.CappadociaValley,
                TourImageAssets.CappadociaHotel,
                TourImageAssets.CappadociaTasting
            ],
            6),
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
            ["Тбилиси, старый город", "Кахетия и винодельни", "Сигнахи и дегустации", "Горные панорамы Казбеги", "Мцхета и древние монастыри", "Гастро-вечер", "Отъезд"],
            TourImageAssets.ForProgramDays(
            [
                TourImageAssets.GeorgiaTbilisi,
                TourImageAssets.GeorgiaKakheti,
                TourImageAssets.GeorgiaMountains
            ],
            [
                TourImageAssets.GeorgiaTbilisi,
                TourImageAssets.GeorgiaKakheti,
                TourImageAssets.GeorgiaMountains,
                TourImageAssets.GeorgiaGastro
            ],
            7),
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
            ["Самарканд, Регистан", "Мавзолеи и базары Самарканда", "Переезд в Бухару", "Исторический центр Бухары", "Переезд в Хиву", "Ичан-Кала", "Ремесленные мастерские", "Отъезд"],
            TourImageAssets.ForProgramDays(
            [
                TourImageAssets.UzbekistanRegistan,
                TourImageAssets.UzbekistanBukhara,
                TourImageAssets.UzbekistanKhiva
            ],
            [
                TourImageAssets.UzbekistanRegistan,
                TourImageAssets.UzbekistanBukhara,
                TourImageAssets.UzbekistanKhiva,
                TourImageAssets.UzbekistanWorkshop
            ],
            8),
            "отели, скоростные поезда, гиды, завтраки")
    ];
}
