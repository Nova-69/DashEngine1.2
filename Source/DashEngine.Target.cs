// Fill out your copyright notice in the Description page of Project Settings.

using UnrealBuildTool;
using System.Collections.Generic;

public class DashEngineTarget : TargetRules
{
	public DashEngineTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
        bIWYU = true;
        ExtraModuleNames.AddRange( new string[] { "DashEngine" } );
	}
}
