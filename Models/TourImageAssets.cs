namespace TravelOperator.Models;

/// <summary>
/// Локальные фотографии туров (скачаны с Wikimedia Commons).
/// </summary>
public static class TourImageAssets
{
    private static string Local(string fileName) => $"/images/tours/{fileName}";
    private static string Thumb(string fileName) => $"/images/tours/thumb/{fileName}";

    /// <summary>Лёгкое превью для карточек каталога.</summary>
    public static string Catalog(string detailPath)
    {
        var fileName = Path.GetFileName(detailPath);
        var jpgName = Path.ChangeExtension(fileName, ".jpg");
        return Thumb(jpgName);
    }

    // Байкал
    public static string BaikalIce => Local("baikal-winter.jpg");
    public static string BaikalOlkhon => Local("baikal-ice-cave.jpg");
    public static string BaikalShamanka => Local("baikal-shamanka.jpg");
    public static string BaikalIrkutsk => Local("baikal-irkutsk.jpg");

    // Алтай
    public static string AltaiMountains => Local("altai-belukha.jpg");
    public static string AltaiRiver => Local("altai-katun.jpg");
    public static string AltaiRoad => Local("altai-road.jpg");
    public static string AltaiLodge => Local("altai-berg.jpg");

    // Камчатка
    public static string KamchatkaVolcano => Local("kamchatka-koryaksky.jpg");
    public static string KamchatkaPlateau => Local("kamchatka-avacha.jpg");
    public static string KamchatkaOcean => Local("kamchatka-bay.jpg");
    public static string KamchatkaThermal => Local("kamchatka-brothers.jpg");

    // Дагестан
    public static string DagestanCanyon => Local("dagestan-canyon.jpg");
    public static string DagestanDune => Local("dagestan-sulak.jpg");
    public static string DagestanAul => Local("dagestan-excursion.jpg");
    public static string DagestanCaspian => Local("dagestan-cliff.jpg");

    // Карелия
    public static string KareliaRuskeala => Local("karelia-ruskeala-2.jpg");
    public static string KareliaForest => Local("karelia-ruskeala-1.jpg");
    public static string KareliaWaterfall => Local("karelia-kivach.jpg");
    public static string KareliaSortavala => Local("karelia-ruskeala-3.jpg");

    // Сочи
    public static string SochiSea => Local("sochi-sea.jpg");
    public static string SochiResort => Local("sochi-beach.jpg");
    public static string SochiMountains => Local("sochi-rian.jpg");
    public static string SochiFamily => Local("sochi-panoramio.jpg");

    // Каппадокия
    public static string CappadociaBalloons => Local("cappadocia-balloons.jpg");
    public static string CappadociaValley => Local("cappadocia-valley.jpg");
    public static string CappadociaHotel => Local("cappadocia-cave.jpg");
    public static string CappadociaTasting => Local("cappadocia-view.jpg");

    // Грузия
    public static string GeorgiaTbilisi => Local("georgia-mtskheta.jpg");
    public static string GeorgiaKakheti => Local("georgia-sighnaghi.jpg");
    public static string GeorgiaMountains => Local("georgia-gergeti.jpg");
    public static string GeorgiaGastro => Local("georgia-ushguli.jpg");

    // Узбекистан
    public static string UzbekistanRegistan => Local("uzbekistan-registan.jpg");
    public static string UzbekistanBukhara => Local("uzbekistan-bukhara.jpg");
    public static string UzbekistanKhiva => Local("uzbekistan-khiva.jpg");
    public static string UzbekistanWorkshop => Local("uzbekistan-sherdor.jpg");
}
