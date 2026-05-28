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
                "https://commons.wikimedia.org/wiki/Special:FilePath/Lake_Baikal_in_winter.jpg?width=1200",
                "https://commons.wikimedia.org/wiki/Special:FilePath/Olkhon_Island_Lake_Baikal.jpg?width=1200",
                "https://commons.wikimedia.org/wiki/Special:FilePath/Baikal_Ice.jpg?width=1200"
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
                "https://commons.wikimedia.org/wiki/Special:FilePath/Belucha_mountain.jpg?width=1200",
                "https://commons.wikimedia.org/wiki/Special:FilePath/Berg_Belucha.jpg?width=1200",
                "https://commons.wikimedia.org/wiki/Special:FilePath/Altai201220120911_0515.jpg?width=1200"
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
                "https://commons.wikimedia.org/wiki/Special:FilePath/Koryaksky_volcano_Petropavlovsk-Kamchatsky_oct-2005.jpg?width=1200",
                "https://commons.wikimedia.org/wiki/Special:FilePath/Avachinsky_volcano.jpg?width=1200",
                "https://commons.wikimedia.org/wiki/Special:FilePath/Kamchatka_volcano.jpg?width=1200"
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
                "https://commons.wikimedia.org/wiki/Special:FilePath/Sulak_Canyon._Mountain_serpentine.jpg?width=1200",
                "https://commons.wikimedia.org/wiki/Special:FilePath/Sulak_Canyon._At_the_cliff.jpg?width=1200",
                "https://commons.wikimedia.org/wiki/Special:FilePath/%D0%AD%D0%BA%D1%81%D0%BA%D1%83%D1%80%D1%81%D0%B8%D1%8F_%D0%B2_%D0%94%D0%B0%D0%B3%D0%B5%D1%81%D1%82%D0%B0%D0%BD_(54).jpg?width=1200"
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
                "https://commons.wikimedia.org/wiki/Special:FilePath/0518Ac._Karelia._Ruskeala_Mountain_park.jpg?width=1200",
                "https://commons.wikimedia.org/wiki/Special:FilePath/0524Ac1._Ruskeala_Mountain_park_in_Karelia.jpg?width=1200",
                "https://commons.wikimedia.org/wiki/Special:FilePath/0438Fa2._Ruskeala_Park_in_Karelia.jpg?width=1200"
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
                "https://commons.wikimedia.org/wiki/Special:FilePath/RIAN_archive_159143_Sochi.jpg?width=1200",
                "https://commons.wikimedia.org/wiki/Special:FilePath/Blue_flag_beaches_in_Sochi_(Primorskiy).jpg?width=1200",
                "https://commons.wikimedia.org/wiki/Special:FilePath/Sochi._Sea_station.jpg?width=1200"
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
                "https://commons.wikimedia.org/wiki/Special:FilePath/Kapadokya_balon_turları.jpg?width=1200",
                "https://commons.wikimedia.org/wiki/Special:FilePath/Cappadocia_Balloon_Inflating_Wikimedia_Commons.JPG?width=1200",
                "https://commons.wikimedia.org/wiki/Special:FilePath/Balon_Udara_Cappadocia.jpg?width=1200"
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
                "https://commons.wikimedia.org/wiki/Special:FilePath/Ushguli%2C_Svaneti%2C_Georgia.jpg?width=1200",
                "https://commons.wikimedia.org/wiki/Special:FilePath/Kakheti_Georgia_vineyard.jpg?width=1200",
                "https://commons.wikimedia.org/wiki/Special:FilePath/Tbilisi_old_town.jpg?width=1200"
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
                "https://commons.wikimedia.org/wiki/Special:FilePath/Registan_Samarkand_Uzbekistan.JPG?width=1200",
                "https://commons.wikimedia.org/wiki/Special:FilePath/Registan_square_Samarkand.jpg?width=1200",
                "https://commons.wikimedia.org/wiki/Special:FilePath/Sher-Dor_Madrasah_Samarkand.jpg?width=1200"
            ],
            ["Самарканд", "Бухара", "Хива", "Ремесленные мастерские"],
            "отели, скоростные поезда, гиды, завтраки")
    ];
}
