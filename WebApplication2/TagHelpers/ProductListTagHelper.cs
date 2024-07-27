//using Microsoft.AspNetCore.Razor.TagHelpers;
//using System.Text;
//using WebApplication2.Controllers;

//namespace WebApplication2.TagHelpers
//{
//        [HtmlTargetElement("product-list")]
//    public class ProductListTagHelper:TagHelper
//    {
//        public override void Process(TagHelperContext context, TagHelperOutput output)
//        {
//            output.TagName = "section";
//            StringBuilder sb = new StringBuilder();
//            var query = ProductController.Products;
          
//            foreach (var product in query)
//            {
//                sb.AppendFormat("<p>Id: {0}</p> <p>Name: {1}</p> <p>Description: {2}</p> <p>Price: {3}</p> <p>Discount: {4}</p> <hr/>", product.Id, product.Name, product.Description, product.Price, product.Discount);
//            }

//            output.Content.SetHtmlContent(sb.ToString());
//        }


//    }
//}
