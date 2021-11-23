using UnrealBuildTool;

public class TotallyOfficialTarget : TargetRules
{
	public TotallyOfficialTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		ExtraModuleNames.Add("TotallyOfficial");
	}
}
