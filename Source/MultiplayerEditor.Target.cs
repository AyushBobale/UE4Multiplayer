// Fill out your copyright notice in the Description page of Project Settings.

using UnrealBuildTool;
using System.Collections.Generic;

public class MultiplayerEditorTarget : TargetRules
{
	public MultiplayerEditorTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Editor;
		DefaultBuildSettings = BuildSettingsVersion.V2;
		 
		//Debug
		bUsesSteam = true;

		ExtraModuleNames.AddRange( new string[] { "Multiplayer" } );
	}
}
