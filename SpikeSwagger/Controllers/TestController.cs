using System.Web.Http;

namespace SpikeSwagger.Controllers
{
    public class TestController : ApiController
    {
        /// <summary>
        ///  This method returns a greeting
        /// </summary>
        /// <param name="id"> The name you want the greeting back.</param>
        public string Get(string id)
        {
            if(string.IsNullOrEmpty(id))
            {
                return string.Empty;
            }
            return string.Format("Hello {0}", id);
        }
    }
}
