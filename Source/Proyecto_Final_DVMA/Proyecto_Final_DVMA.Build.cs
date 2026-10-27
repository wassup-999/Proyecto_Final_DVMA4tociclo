// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class Proyecto_Final_DVMA : ModuleRules
{
	public Proyecto_Final_DVMA(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(new string[] {
			"Core",
			"CoreUObject",
			"Engine",
			"InputCore",
			"EnhancedInput",
			"AIModule",
			"StateTreeModule",
			"GameplayStateTreeModule",
			"UMG",
			"Slate"
		});

		PrivateDependencyModuleNames.AddRange(new string[] { });

		PublicIncludePaths.AddRange(new string[] {
			"Proyecto_Final_DVMA",
			"Proyecto_Final_DVMA/Variant_Horror",
			"Proyecto_Final_DVMA/Variant_Horror/UI",
			"Proyecto_Final_DVMA/Variant_Shooter",
			"Proyecto_Final_DVMA/Variant_Shooter/AI",
			"Proyecto_Final_DVMA/Variant_Shooter/UI",
			"Proyecto_Final_DVMA/Variant_Shooter/Weapons"
		});

		// Uncomment if you are using Slate UI
		// PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore" });

		// Uncomment if you are using online features
		// PrivateDependencyModuleNames.Add("OnlineSubsystem");

		// To include OnlineSubsystemSteam, add it to the plugins section in your uproject file with the Enabled attribute set to true
	}
}
