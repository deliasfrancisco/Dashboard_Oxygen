using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace Dashboard_OxygenWeb.Localization
{
    public static class Dashboard_OxygenWebLocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(Dashboard_OxygenWebConsts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(Dashboard_OxygenWebLocalizationConfigurer).GetAssembly(),
                        "Dashboard_OxygenWeb.Localization.SourceFiles"
                    )
                )
            );
        }
    }
}
