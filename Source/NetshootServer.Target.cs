// Fill out your copyright notice in the Description page of Project Settings.

using UnrealBuildTool;
using System.Collections.Generic;

public class NetshootServerTarget : TargetRules
{
    public NetshootServerTarget(TargetInfo Target) : base(Target) //根据你的项目名称更改此行
    {
        Type = TargetType.Server;
        DefaultBuildSettings = BuildSettingsVersion.V2;
        ExtraModuleNames.Add("Netshoot"); //根据你的项目名称更改此行
    }
}
