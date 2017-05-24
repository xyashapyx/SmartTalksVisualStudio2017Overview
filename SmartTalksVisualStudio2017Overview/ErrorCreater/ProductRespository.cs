using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartTalksVisualStudio2017Overview.ErrorCreater
{
    public class ProductRespository
    {
        public string GetNameOfProduct(int productId)
        {
            try
            {
                return ProductDao.GetProductName(productId);
            }
            catch (FileNotFoundException e)
            {
                throw new IOException("Second layer exception",e);
            }
        }
    }
}
