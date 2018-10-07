# Vainglory-CSharp

This is a work in progress C# API wrapper for [Vainglory] (https://developer.vainglorygame.com). Please feel free at to use and contribute. 

# How to use
Build and reference DLLs or add to existing project.

'''C#

VainGloryAPI api = new VainGloryAPI(token);
List<string> ids = new List<string>() { "8c67f3d4-18e9-11e5-b5eb-06eb725f8a76", "fdd0c2f2-6f07-11e5-aaca-06f4ee369f53" };
var playersByIds = api.GetPlayersByIdsJson(ids);

'''
