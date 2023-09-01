using UnrealBuildTool;
using System.IO;
using System;

public class KeybindableHotbar : ModuleRules
{
    public KeybindableHotbar(ReadOnlyTargetRules Target) : base(Target)
    {
	    PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

	    // FactoryGame transitive dependencies
	    // Not all of these are required, but including the extra ones saves you from having to add them later.
	    PublicDependencyModuleNames.AddRange(new[] {
		    "Core", "CoreUObject",
		    "Engine",
		    "DeveloperSettings",
		    "PhysicsCore",
		    "InputCore",
		    "OnlineSubsystem", "OnlineSubsystemNull", "OnlineSubsystemUtils",
		    "SignificanceManager",
		    "GeometryCollectionEngine",
		    "ChaosVehiclesCore", "ChaosVehicles", "ChaosSolverEngine",
		    "AnimGraphRuntime",
		    "AkAudio",
		    "AssetRegistry",
		    "NavigationSystem",
		    "ReplicationGraph",
		    "AIModule",
		    "GameplayTasks",
		    "SlateCore", "Slate", "UMG",
		    "InstancedSplines",
		    "RenderCore",
		    "CinematicCamera",
		    "Foliage",
		    "Niagara",
		    "EnhancedInput",
		    "GameplayCameras",
		    "TemplateSequence",
		    "NetCore",
		    "GameplayTags",
		    "AudioMixer",
		    "Synthesis"
	    });

	    // FactoryGame plugins
	    PublicDependencyModuleNames.AddRange(new[] {
		    "AbstractInstance",
		    "InstancedSplinesComponent",
		    "SignificanceISPC"
	    });

	    // Header stubs
	    PublicDependencyModuleNames.AddRange(new[] {
		    "DummyHeaders",
	    });

	    if (Target.Type == TargetRules.TargetType.Editor) {
		    PublicDependencyModuleNames.AddRange(new string[] {"OnlineBlueprintSupport", "AnimGraph", "SynthesisEditor", "AssetRegistry"});
	    }
	    PublicDependencyModuleNames.AddRange(new string[] {"FactoryGame", "SML"});
    }
}