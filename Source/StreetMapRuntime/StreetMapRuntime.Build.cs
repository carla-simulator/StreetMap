// Copyright 2017 Mike Fricker. All Rights Reserved.
using System.IO;

namespace UnrealBuildTool.Rules
{
  public class StreetMapRuntime : ModuleRules
  {
    public StreetMapRuntime(ReadOnlyTargetRules Target)
    : base(Target)
    {
      PCHUsage = ModuleRules.PCHUsageMode.UseExplicitOrSharedPCHs;
      PublicDependencyModuleNames.AddRange(new string[] { "CarlaMeshGeneration" });
      PrivateDependencyModuleNames.AddRange(
        new string[] {
          "Core",
          "CoreUObject",
          "Engine",
          "RHI",
          "RenderCore",
          "PropertyEditor",
          "GeometricObjects",
          "ProceduralMeshComponent",
        }
      );



        PrivateIncludePaths.AddRange(new string[]{"StreetMapRuntime/Private"});
    }
  }
}
