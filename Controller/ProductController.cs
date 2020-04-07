using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Scriban;
using System.IO;

namespace MVCQuete2.Controller
{
    public class ProductController
    {
        public static string HTMLParser()
        {
            var html = File.ReadAllText(@"C:\Users\Student\source\repos\MVCQuete2\Controller\HTMLPage.html");

            using (var context = new Model.DataContext())
            {
                var template = Template.Parse(html);
                var result = template.Render(new { Products = context.ProductsList });
                return result;
            }
        }

        public static void HTMLWriter(string result)
        {
            TextWriter writer = new StreamWriter(@"C:\Users\Student\source\repos\MVCQuete2\bin\Debug\text-test\listOfProducts.html");
            writer.Write(result);
            writer.Flush();
            writer.Close();
            writer = null;
        }

    }
}
