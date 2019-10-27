namespace Umbraco.Web.PublishedContentModels
{
    public partial class BlogListing
    {
        public string Title
        {
            get
            {
                return string.IsNullOrEmpty(Heading) ? Name : Heading;
            }
        }
    }
}