using UnrealBuildTool;

public class PotionGameSampleClientTarget : TargetRules
{
	public PotionGameSampleClientTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V3;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Client;
		ExtraModuleNames.Add("PotionGameSample");
	}
}
