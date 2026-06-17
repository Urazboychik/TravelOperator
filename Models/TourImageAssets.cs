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
    public static string BaikalSunset => Local("baikal-sunset.jpg");
    public static string BaikalCircum => Local("baikal-circum.jpg");
    public static string BaikalPort => Local("baikal-port-baikal.jpg");
    public static string BaikalIceSunset => Local("baikal-ice-sunset.jpg");
    public static string BaikalPanorama => Local("baikal-panorama.jpg");

    // Алтай
    public static string AltaiMountains => Local("altai-belukha.jpg");
    public static string AltaiRiver => Local("altai-katun.jpg");
    public static string AltaiRoad => Local("altai-road.jpg");
    public static string AltaiLodge => Local("altai-berg.jpg");
    public static string AltaiAerial => Local("altai-aerial.jpg");
    public static string AltaiChuya => Local("altai-chuya.jpg");
    public static string AltaiBlueLake => Local("altai-blue-lake.jpg");
    public static string AltaiKuray => Local("altai-kuray.jpg");
    public static string AltaiPassRoad => Local("altai-pass-road.jpg");

    // Камчатка
    public static string KamchatkaVolcano => Local("kamchatka-koryaksky.jpg");
    public static string KamchatkaPlateau => Local("kamchatka-avacha.jpg");
    public static string KamchatkaOcean => Local("kamchatka-bay.jpg");
    public static string KamchatkaThermal => Local("kamchatka-brothers.jpg");
    public static string KamchatkaIss => Local("kamchatka-iss.jpg");
    public static string KamchatkaIssPeninsula => Local("kamchatka-iss-peninsula.jpg");
    public static string KamchatkaGeyser => Local("kamchatka-geyser.jpg");
    public static string KamchatkaUzon => Local("kamchatka-uzon.jpg");
    public static string KamchatkaKarymsky => Local("kamchatka-karymsky.jpg");
    public static string KamchatkaValleyLandslide => Local("kamchatka-valley-landslide.jpg");

    // Дагестан
    public static string DagestanCanyon => Local("dagestan-canyon.jpg");
    public static string DagestanDune => Local("dagestan-sulak.jpg");
    public static string DagestanAul => Local("dagestan-excursion.jpg");
    public static string DagestanCaspian => Local("dagestan-cliff.jpg");
    public static string DagestanDerbent => Local("dagestan-derbent.jpg");
    public static string DagestanMakhachkala => Local("dagestan-makhachkala.jpg");

    // Карелия
    public static string KareliaRuskeala => Local("karelia-ruskeala-2.jpg");
    public static string KareliaForest => Local("karelia-ruskeala-1.jpg");
    public static string KareliaWaterfall => Local("karelia-kivach.jpg");
    public static string KareliaSortavala => Local("karelia-sortavala.jpg");
    public static string KareliaLadoga => Local("karelia-ladoga.jpg");

    // Сочи
    public static string SochiSea => Local("sochi-sea.jpg");
    public static string SochiResort => Local("sochi-beach.jpg");
    public static string SochiMountains => Local("sochi-rian.jpg");
    public static string SochiFamily => Local("sochi-panoramio.jpg");
    public static string SochiKrasnayaPolyana => Local("sochi-krasnaya-polyana.jpg");
    public static string SochiSeaView => Local("sochi-sea-view.jpg");
    public static string SochiBlackSea => Local("sochi-black-sea.jpg");
    public static string SochiPort => Local("sochi-port.jpg");

    // Каппадокия
    public static string CappadociaBalloons => Local("cappadocia-balloons.jpg");
    public static string CappadociaValley => Local("cappadocia-valley.jpg");
    public static string CappadociaHotel => Local("cappadocia-cave.jpg");
    public static string CappadociaTasting => Local("cappadocia-view.jpg");
    public static string CappadociaGoremePark => Local("cappadocia-goreme-park.jpg");
    public static string CappadociaAerial => Local("cappadocia-aerial.jpg");

    // Грузия
    public static string GeorgiaTbilisi => Local("georgia-mtskheta.jpg");
    public static string GeorgiaKakheti => Local("georgia-sighnaghi.jpg");
    public static string GeorgiaMountains => Local("georgia-gergeti.jpg");
    public static string GeorgiaGastro => Local("georgia-ushguli.jpg");
    public static string GeorgiaVardzia => Local("georgia-vardzia.jpg");
    public static string GeorgiaJvari => Local("georgia-jvari.jpg");
    public static string GeorgiaGergetiClouds => Local("georgia-gergeti-clouds.jpg");

    // Узбекистан
    public static string UzbekistanRegistan => Local("uzbekistan-registan.jpg");
    public static string UzbekistanBukhara => Local("uzbekistan-bukhara.jpg");
    public static string UzbekistanKhiva => Local("uzbekistan-khiva.jpg");
    public static string UzbekistanWorkshop => Local("uzbekistan-sherdor.jpg");
    public static string UzbekistanShahizinda => Local("uzbekistan-shahizinda.jpg");
    public static string UzbekistanKaltaMinaret => Local("uzbekistan-kalta-minaret.jpg");
    public static string UzbekistanChorsu => Local("uzbekistan-chorsu.jpg");
    public static string UzbekistanItchanKala => Local("uzbekistan-itchan-kala.jpg");
}
