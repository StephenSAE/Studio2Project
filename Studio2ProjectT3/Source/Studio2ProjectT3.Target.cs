// Fill out your copyright notice in the Description page of Project Settings.

using UnrealBuildTool;
using System.Collections.Generic;

public class Studio2ProjectT3Target : TargetRules
{
	public Studio2ProjectT3Target(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;

		ExtraModuleNames.AddRange( new string[] { "Studio2ProjectT3" } );
	}
}
