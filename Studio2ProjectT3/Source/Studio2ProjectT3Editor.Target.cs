// Fill out your copyright notice in the Description page of Project Settings.

using UnrealBuildTool;
using System.Collections.Generic;

public class Studio2ProjectT3EditorTarget : TargetRules
{
	public Studio2ProjectT3EditorTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Editor;

		ExtraModuleNames.AddRange( new string[] { "Studio2ProjectT3" } );
	}
}
