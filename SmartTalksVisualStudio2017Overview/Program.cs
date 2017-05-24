using SmartTalksVisualStudio2017Overview.ErrorCreater;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartTalksVisualStudio2017Overview
{
    class Program
    {
        static void Main(string[] args)
        {
            var ps = new ProductService();
            ps.GetNameOfProduct(2);
        }
    }
}
