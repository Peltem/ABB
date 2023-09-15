﻿using Avalonia;
using System;

namespace AvaloniaApplication2
{
    class Program
    {
        // Initialization code. Don't use any Avalonia, third-party APIs or any
        // SynchronizationContext-reliant code before AppMain is called: things aren't initialized
        // yet and stuff might break.
        [STAThread]
        public static void Main(string[] args) => BuildAvaloniaApp()
            .StartWithClassicDesktopLifetime(args);

        // Avalonia configuration, don't remove; also used by visual designer.
        public static AppBuilder BuildAvaloniaApp()
            => AppBuilder.Configure<App>()
                .UsePlatformDetect()
                .LogToTrace();
    }

    public class Book
    {
        public int BookID { get; set; }
        public string BookName { get; set; }
        public int kol { get; set; }
    }

    public class Chit
    {
        public int ChitID { get; set; }
        public string FIO { get; set; }
        public int Number { get; set; }
    }
}