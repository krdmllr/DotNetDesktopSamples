﻿using System;
using Windows.UI.Xaml;
using Microsoft.Extensions.Logging;

namespace FormsDesktop.Wasm
{
	public class Program
	{
		static int Main(string[] args)
		{
            ConfigureFilters(Uno.Extensions.LogExtensionPoint.AmbientLoggerFactory);

            Windows.UI.Xaml.Application.Start(_ => new FormsDesktop.UWP.App());

			return 0;
		}

        static void ConfigureFilters(ILoggerFactory factory)
        {
#if DEBUG
            factory
                .WithFilter(new FilterLoggerSettings
                    {
                        { "Uno", LogLevel.Warning },
                        { "Windows", LogLevel.Warning },
					
						// Generic Xaml events
						// { "Windows.UI.Xaml", LogLevel.Debug },
						// { "Windows.UI.Xaml.Shapes", LogLevel.Debug },
						// { "Windows.UI.Xaml.VisualStateGroup", LogLevel.Debug },
						// { "Windows.UI.Xaml.StateTriggerBase", LogLevel.Debug },
						// { "Windows.UI.Xaml.UIElement", LogLevel.Debug },
						// { "Windows.UI.Xaml.Setter", LogLevel.Debug },
						   
						// Layouter specific messages
						// { "Windows.UI.Xaml.Controls", LogLevel.Debug },
						// { "Windows.UI.Xaml.Controls.Layouter", LogLevel.Debug },
						// { "Windows.UI.Xaml.Controls.Panel", LogLevel.Debug },
						   
						// Binding related messages
						// { "Windows.UI.Xaml.Data", LogLevel.Debug },
						   
						//  Binder memory references tracking
						// { "ReferenceHolder", LogLevel.Debug },
					}
                )
                .AddConsole(LogLevel.Trace);
#else
            factory
                .AddConsole(LogLevel.Error);
#endif
        }
    }
}
