﻿// This file is used by Code Analysis to maintain SuppressMessage
// attributes that are applied to this project.
// Project-level suppressions either have no target or are given
// a specific target and scoped to a namespace, type, member, etc.

using System.Diagnostics.CodeAnalysis;

[assembly: SuppressMessage("CodeQuality", "IDE0051:Remove unused private members", Justification = "Unused members are called by the ModLoader or used by Harmony.")]

// [assembly: SuppressMessage("Compiler", "CS8618", Justification = "The field is set in the Load method before use.", Scope = "member", Target = "~F:ToyBox.Main.ModEntry")]
