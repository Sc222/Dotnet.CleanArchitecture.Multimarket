using System;

namespace Infrastructure.Entities
{
    public class Locale
    {
        public Guid AppId { get; set; }

        public MarketType Market { get; set; }
    }
}