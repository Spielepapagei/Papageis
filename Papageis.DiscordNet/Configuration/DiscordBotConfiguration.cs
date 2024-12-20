﻿using System.Reflection;
using Discord;

namespace Papageis.DiscordNet.Configuration;

public class DiscordBotConfiguration
{
    public SettingsData Settings { get; set; } = new();
    public AuthData Auth { get; set; } = new();
    public List<Assembly> ModuleAssemblies { get; set; } = new();
    
    public class SettingsData
    {
        public bool Enable { get; set; } = true;
        public bool EnableDebug { get; set; } = false;
        public bool DevelopMode { get; set; } = false;
    }
    
    public class AuthData
    {
        public string BotToken { get; set; } = string.Empty;
    }
}