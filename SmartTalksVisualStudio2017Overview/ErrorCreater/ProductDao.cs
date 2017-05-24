using System.IO;

namespace SmartTalksVisualStudio2017Overview.ErrorCreater
{
    public static class ProductDao
    {
        public static string GetProductName(int productId)
        {
            throw new FileNotFoundException("Low lvl FileNotFoundException");
        }
    }
}
