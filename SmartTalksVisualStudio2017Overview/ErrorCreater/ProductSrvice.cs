using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartTalksVisualStudio2017Overview.ErrorCreater
{
    public class ProductService
    {
        private readonly ProductRespository _productRespository;
        public ProductService()
        {
            _productRespository = new ProductRespository();
        }

        public string GetNameOfProduct(int productId)
        {
            try
            {
                return _productRespository.GetNameOfProduct(productId);
            }
            catch (IOException e)
            {
                throw new Exception("Top layer exception", e);
            }
        }
    }
}
