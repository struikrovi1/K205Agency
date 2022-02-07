using K205Agency.Models;

namespace K205Agency.ViewModel
{
    public class HomeVM
    {
        public Masthead Masthead { get; set; }
        public List<Service> Services { get; set; }
        public List<Portfolio> Portfolios { get; set; }
        public List<About> Abouts { get; set; }
    }
}
