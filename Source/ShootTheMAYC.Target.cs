// Salik Ape Yacht Club. All Rights Reserved. /SBSBSBSBSBSB

using UnrealBuildTool;
using System.Collections.Generic;

public class ShootTheMAYCTarget : TargetRules
{
	public ShootTheMAYCTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		DefaultBuildSettings = BuildSettingsVersion.V5;

		ExtraModuleNames.AddRange( new string[] { "ShootTheMAYC" } );
	}
}
