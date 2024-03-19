using UnrealBuildTool;

public class PotionGameSampleServerTarget : TargetRules
{
	public PotionGameSampleServerTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V3;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Server;
		ExtraModuleNames.Add("PotionGameSample");
	}
}
