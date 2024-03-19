using UnrealBuildTool;

public class PotionGameSampleEditorTarget : TargetRules
{
	public PotionGameSampleEditorTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V3;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Editor;
		ExtraModuleNames.Add("PotionGameSample");
	}
}
