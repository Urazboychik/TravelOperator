using System.Net;
using System.Text;

namespace TravelOperator.Models;

public static class TourImageAssets
{
    public static string BaikalIce => Create("Байкал", "прозрачный лед", "ice", "#082f49", "#38bdf8", "#e0f2fe");
    public static string BaikalOlkhon => Create("Ольхон", "мыс Хобой", "ice", "#0f172a", "#60a5fa", "#bae6fd");
    public static string BaikalShamanka => Create("Шаманка", "скала и Малое море", "ice", "#1e293b", "#22d3ee", "#dbeafe");
    public static string BaikalIrkutsk => Create("Иркутск", "старт маршрута", "city", "#1e293b", "#38bdf8", "#e0f2fe");

    public static string AltaiMountains => Create("Алтай", "горы и перевалы", "mountains", "#172554", "#16a34a", "#fef3c7");
    public static string AltaiRiver => Create("Катунь", "бирюзовая река", "river", "#064e3b", "#14b8a6", "#dcfce7");
    public static string AltaiRoad => Create("Чуйский тракт", "панорамный маршрут", "road", "#1f2937", "#f59e0b", "#fef3c7");
    public static string AltaiLodge => Create("Lodge-отель", "отдых в горах", "forest", "#052e16", "#22c55e", "#dcfce7");

    public static string KamchatkaVolcano => Create("Камчатка", "вулканы", "volcano", "#111827", "#f97316", "#fed7aa");
    public static string KamchatkaOcean => Create("Авачинская бухта", "океан и скалы", "sea", "#0c4a6e", "#22d3ee", "#e0f2fe");
    public static string KamchatkaThermal => Create("Термальные источники", "экспедиция", "steam", "#1e1b4b", "#fb7185", "#fce7f3");
    public static string KamchatkaPlateau => Create("Вулканическое плато", "подъем к кратерам", "volcano", "#27272a", "#ef4444", "#fee2e2");

    public static string DagestanCanyon => Create("Сулакский каньон", "горы Дагестана", "canyon", "#451a03", "#f59e0b", "#fef3c7");
    public static string DagestanDune => Create("Сарыкум", "бархан", "desert", "#78350f", "#fbbf24", "#fffbeb");
    public static string DagestanCaspian => Create("Каспий", "море и Дербент", "sea", "#0f766e", "#38bdf8", "#e0f2fe");
    public static string DagestanAul => Create("Горные аулы", "кавказские села", "city", "#431407", "#f97316", "#ffedd5");

    public static string KareliaRuskeala => Create("Рускеала", "мраморный каньон", "quarry", "#064e3b", "#22c55e", "#dcfce7");
    public static string KareliaForest => Create("Карелия", "северный лес", "forest", "#052e16", "#16a34a", "#bbf7d0");
    public static string KareliaWaterfall => Create("Водопады", "лесные маршруты", "waterfall", "#0f172a", "#38bdf8", "#e0f2fe");
    public static string KareliaSortavala => Create("Сортавала", "старт выходных", "city", "#0f172a", "#22c55e", "#dcfce7");

    public static string SochiSea => Create("Сочи", "море", "sea", "#0c4a6e", "#06b6d4", "#cffafe");
    public static string SochiResort => Create("Курорт", "пляж и отели", "beach", "#164e63", "#f59e0b", "#fef3c7");
    public static string SochiMountains => Create("Красная Поляна", "горы", "mountains", "#14532d", "#22c55e", "#dcfce7");
    public static string SochiFamily => Create("Семейный отдых", "свободные дни", "beach", "#1e3a8a", "#38bdf8", "#dbeafe");

    public static string CappadociaBalloons => Create("Каппадокия", "воздушные шары", "balloons", "#4c1d95", "#f97316", "#ffedd5");
    public static string CappadociaValley => Create("Гёреме", "скальные долины", "canyon", "#7c2d12", "#fb923c", "#fed7aa");
    public static string CappadociaHotel => Create("Бутик-отель", "пещерные номера", "city", "#422006", "#f59e0b", "#fef3c7");
    public static string CappadociaTasting => Create("Дегустация", "камерный вечер", "city", "#581c87", "#f97316", "#fae8ff");

    public static string GeorgiaTbilisi => Create("Тбилиси", "старый город", "city", "#312e81", "#f59e0b", "#fef3c7");
    public static string GeorgiaKakheti => Create("Кахетия", "виноградники", "vineyard", "#14532d", "#84cc16", "#ecfccb");
    public static string GeorgiaMountains => Create("Грузия", "горные панорамы", "mountains", "#1e3a8a", "#22c55e", "#dbeafe");
    public static string GeorgiaGastro => Create("Гастро-вечер", "вино и кухня", "vineyard", "#3f6212", "#f59e0b", "#fef3c7");

    public static string UzbekistanRegistan => Create("Самарканд", "Регистан", "city", "#1e40af", "#f59e0b", "#fef3c7");
    public static string UzbekistanBukhara => Create("Бухара", "купола и базары", "city", "#7c2d12", "#fbbf24", "#fffbeb");
    public static string UzbekistanKhiva => Create("Хива", "Шелковый путь", "desert", "#92400e", "#38bdf8", "#ecfeff");
    public static string UzbekistanWorkshop => Create("Мастерские", "ремесла", "city", "#713f12", "#06b6d4", "#ecfeff");

    private static string Create(string title, string subtitle, string scene, string dark, string accent, string light)
    {
        var shapes = scene switch
        {
            "ice" => Ice(accent, light),
            "mountains" => Mountains(accent, light),
            "river" => River(accent, light),
            "road" => Road(accent, light),
            "volcano" => Volcano(accent, light),
            "sea" => Sea(accent, light),
            "steam" => Steam(accent, light),
            "canyon" => Canyon(accent, light),
            "desert" => Desert(accent, light),
            "quarry" => Quarry(accent, light),
            "forest" => Forest(accent, light),
            "waterfall" => Waterfall(accent, light),
            "beach" => Beach(accent, light),
            "balloons" => Balloons(accent, light),
            "city" => City(accent, light),
            "vineyard" => Vineyard(accent, light),
            _ => Mountains(accent, light)
        };

        var svg = $"""
            <svg xmlns="http://www.w3.org/2000/svg" viewBox="0 0 1200 760" role="img" aria-label="{WebUtility.HtmlEncode(title)}">
              <defs>
                <linearGradient id="bg" x1="0" y1="0" x2="1" y2="1">
                  <stop offset="0" stop-color="{dark}"/>
                  <stop offset="0.58" stop-color="#111827"/>
                  <stop offset="1" stop-color="{accent}"/>
                </linearGradient>
                <radialGradient id="glow" cx="72%" cy="18%" r="55%">
                  <stop offset="0" stop-color="{light}" stop-opacity=".62"/>
                  <stop offset=".55" stop-color="{accent}" stop-opacity=".18"/>
                  <stop offset="1" stop-color="{dark}" stop-opacity="0"/>
                </radialGradient>
              </defs>
              <rect width="1200" height="760" fill="url(#bg)"/>
              <rect width="1200" height="760" fill="url(#glow)"/>
              <circle cx="1030" cy="120" r="92" fill="{light}" opacity=".18"/>
              {shapes}
              <g fill="#fff">
                <text x="72" y="112" font-size="36" font-family="Arial, sans-serif" font-weight="800" letter-spacing="7" opacity=".74">TRAVEL ROUTE</text>
                <text x="72" y="610" font-size="82" font-family="Arial, sans-serif" font-weight="900">{WebUtility.HtmlEncode(title)}</text>
                <text x="76" y="674" font-size="34" font-family="Arial, sans-serif" font-weight="700" opacity=".82">{WebUtility.HtmlEncode(subtitle)}</text>
              </g>
            </svg>
            """;

        return $"data:image/svg+xml;base64,{Convert.ToBase64String(Encoding.UTF8.GetBytes(svg))}";
    }

    private static string Mountains(string accent, string light) => $"""
        <path d="M0 570 230 320l130 150 210-270 260 330 130-160 240 220v170H0z" fill="{light}" opacity=".28"/>
        <path d="M0 620 260 380l130 145 200-250 250 310 150-165 210 210v130H0z" fill="{accent}" opacity=".5"/>
        """;

    private static string Ice(string accent, string light) => $"""
        <path d="M0 520c190-38 315-34 470 0s315 38 730-22v262H0z" fill="{light}" opacity=".3"/>
        <path d="M120 455 260 315l124 140-124 140zM650 438 790 280l136 160-136 152z" fill="{accent}" opacity=".34"/>
        <path d="M110 670h940" stroke="{light}" stroke-width="8" opacity=".34"/>
        """;

    private static string River(string accent, string light) => $"""
        <path d="M0 560c210-90 330-58 455-20 150 45 255 65 745-80v300H0z" fill="{accent}" opacity=".45"/>
        <path d="M0 635c260-70 380-15 520 10 145 26 280 8 680-96v211H0z" fill="{light}" opacity=".28"/>
        """;

    private static string Road(string accent, string light) => $"""
        <path d="M520 760 690 380 780 760z" fill="#020617" opacity=".55"/>
        <path d="M604 740 684 400" stroke="{light}" stroke-width="10" stroke-dasharray="34 28" opacity=".8"/>
        <path d="M0 580 280 350l180 170 160-210 260 270 180-140 140 140v180H0z" fill="{accent}" opacity=".34"/>
        """;

    private static string Volcano(string accent, string light) => $"""
        <path d="M250 760 560 210 900 760z" fill="{accent}" opacity=".42"/>
        <path d="M500 315 560 210l70 112-65 42z" fill="{light}" opacity=".72"/>
        <path d="M555 205c-35-92 44-106 10-185 96 80 22 136 68 206" fill="{accent}" opacity=".42"/>
        """;

    private static string Sea(string accent, string light) => $"""
        <path d="M0 535c210-60 335-58 500-5 170 54 330 50 700-36v266H0z" fill="{accent}" opacity=".48"/>
        <path d="M0 615c190-38 315-34 470 0s315 38 730-22v167H0z" fill="{light}" opacity=".22"/>
        <path d="M760 460 910 300l150 160z" fill="{light}" opacity=".24"/>
        """;

    private static string Steam(string accent, string light) => $"""
        <path d="M0 610c210-55 390-44 570-6 180 37 330 30 630-50v206H0z" fill="{accent}" opacity=".36"/>
        <path d="M360 500c-45-80 58-112 0-188M560 500c-45-80 58-112 0-188M760 500c-45-80 58-112 0-188" stroke="{light}" stroke-width="20" stroke-linecap="round" opacity=".44" fill="none"/>
        """;

    private static string Canyon(string accent, string light) => $"""
        <path d="M0 760V420l225-80 125 160 180-250 230 330 120-190 320 120v250z" fill="{accent}" opacity=".42"/>
        <path d="M445 760c90-205 250-205 345 0z" fill="{light}" opacity=".22"/>
        """;

    private static string Desert(string accent, string light) => $"""
        <path d="M0 570c240-120 430-120 650-20 190 88 330 102 550-5v215H0z" fill="{accent}" opacity=".44"/>
        <path d="M0 650c230-74 430-64 650-4 210 58 350 48 550-34v148H0z" fill="{light}" opacity=".24"/>
        """;

    private static string Quarry(string accent, string light) => $"""
        <path d="M0 545 240 330h720l240 215v215H0z" fill="{accent}" opacity=".36"/>
        <path d="M185 580h830l-120 100H305z" fill="{light}" opacity=".28"/>
        <path d="M300 330 425 545M600 330 600 545M900 330 775 545" stroke="{light}" stroke-width="8" opacity=".34"/>
        """;

    private static string Forest(string accent, string light) => $"""
        <path d="M130 595 245 360l115 235zM350 620l135-285 135 285zM650 600l120-245 120 245zM900 625l135-290 135 290z" fill="{accent}" opacity=".48"/>
        <rect x="0" y="610" width="1200" height="150" fill="{light}" opacity=".18"/>
        """;

    private static string Waterfall(string accent, string light) => $"""
        <path d="M0 500 310 300h580l310 200v260H0z" fill="{accent}" opacity=".34"/>
        <path d="M510 305h180v455H510z" fill="{light}" opacity=".46"/>
        <path d="M0 665c260-70 430-45 600 0s340 68 600-10v105H0z" fill="{accent}" opacity=".42"/>
        """;

    private static string Beach(string accent, string light) => $"""
        <path d="M0 570c220-65 390-52 575 0 175 50 340 50 625-28v218H0z" fill="{accent}" opacity=".38"/>
        <path d="M0 655c300-58 525-30 760 0 160 20 280 8 440-30v135H0z" fill="{light}" opacity=".38"/>
        <circle cx="930" cy="210" r="80" fill="{light}" opacity=".38"/>
        """;

    private static string Balloons(string accent, string light) => $"""
        <ellipse cx="370" cy="300" rx="95" ry="125" fill="{accent}" opacity=".58"/>
        <ellipse cx="705" cy="210" rx="120" ry="155" fill="{light}" opacity=".42"/>
        <path d="M335 424h70l-18 55h-34zM665 365h80l-20 65h-40z" fill="#111827" opacity=".55"/>
        <path d="M0 620 260 380l140 160 180-225 220 290 150-180 250 195v140H0z" fill="{accent}" opacity=".32"/>
        """;

    private static string City(string accent, string light) => $"""
        <path d="M100 760V480h120v280zm170 0V390h155v370zm210 0V520h120v240zm180 0V345h160v415zm220 0V460h160v300z" fill="{accent}" opacity=".42"/>
        <path d="M270 390h155l-78-92zm390-45h160l-80-98z" fill="{light}" opacity=".42"/>
        """;

    private static string Vineyard(string accent, string light) => $"""
        <path d="M0 560c250-80 445-70 650-10 220 64 350 60 550-30v240H0z" fill="{accent}" opacity=".34"/>
        <path d="M90 620c180-60 310-60 490 0M90 690c220-58 450-58 670 0M580 620c210-56 360-56 570 0" stroke="{light}" stroke-width="12" opacity=".45" fill="none"/>
        <circle cx="860" cy="330" r="68" fill="{accent}" opacity=".44"/>
        """;
}
