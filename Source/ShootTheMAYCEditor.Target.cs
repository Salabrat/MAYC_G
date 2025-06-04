// Salik Ape Yacht Club. All Rights Reserved. /SBSBSBSBSBSB

using UnrealBuildTool;
using System.Collections.Generic;

public class ShootTheMAYCEditorTarget : TargetRules
{
	public ShootTheMAYCEditorTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Editor;
		DefaultBuildSettings = BuildSettingsVersion.V5;

		ExtraModuleNames.AddRange( new string[] { "ShootTheMAYC" } );
	}
}
