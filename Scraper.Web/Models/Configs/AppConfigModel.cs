using Scraper.Common.Models.Configs;

namespace Scraper.Web.Models.Configs;

public class AppConfigModel
{
    public required WebDriverConfigModel WebDriverConfig { get; set; }

    public required KafkaConfigModel KafkaConfig { get; set; }
}
