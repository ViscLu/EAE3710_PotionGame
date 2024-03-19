using UnrealBuildTool;

public class PotionGameSampleTarget : TargetRules
{
	public PotionGameSampleTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V3;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Game;
		ExtraModuleNames.Add("PotionGameSample");
	}
}
