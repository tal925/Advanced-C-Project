using System.Xml.Linq;
namespace Dal;

internal static class Config
{
    static string s_data_config_xml = "data-config";

    public static int ProductNum
    {
        get => XMLTools.GetAndIncrementNextId(s_data_config_xml, "ProductNum");
    }

    public static int SaleNum
    {
        get => XMLTools.GetAndIncrementNextId(s_data_config_xml, "SaleNum");
    }
}