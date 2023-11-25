// Copyright 2017 Mike Fricker. All Rights Reserved.

namespace UnrealBuildTool.Rules
{
  public class StreetMapRuntime : ModuleRules
  {
    public StreetMapRuntime(ReadOnlyTargetRules Target)
    : base(Target)
    {
      PCHUsage = ModuleRules.PCHUsageMode.UseExplicitOrSharedPCHs;

      PrivateDependencyModuleNames.AddRange(new string[]
        {
          "Core",
          "CoreUObject",
          "Engine",
          "RHI",
          "RenderCore",
          "PropertyEditor",
          "GeometryCore",
          "ProceduralMeshComponent",
          "Carla"
        }
      );

      PrivateIncludePaths.Add("StreetMapRuntime/Private");
    }
  }
}
