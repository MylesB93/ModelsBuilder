using System.Collections.Generic;
using System.Linq;
using Umbraco.Core.Models;

namespace Umbraco.Web.PublishedContentModels
{
    public partial class Home
    {
        public List<IPublishedContent> BlogListings
        {
            get
            {
                return Children.Where(bl => bl.DocumentTypeAlias == "blogListing").ToList();
            }
        }
    }
}