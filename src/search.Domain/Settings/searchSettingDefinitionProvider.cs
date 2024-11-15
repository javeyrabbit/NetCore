using Volo.Abp.Settings;

namespace search.Settings;

public class searchSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(searchSettings.MySetting1));
    }
}
