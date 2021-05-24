using System;
using Foundation;
using AppKit;

namespace net6_console_mac_sample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            // System.DllNotFoundException: Could not find the runtime library libxammac.dylib
            NSApplication.Init();

            // [ERROR] FATAL UNHANDLED EXCEPTION: System.TypeInitializationException: TypeInitialization_Type, Foundation.NSString
            var str = new NSString("test");
            var num = new NSNumber(123.45);

            Console.WriteLine($"str has string value {(string)str}");
            Console.WriteLine($"num has float value {num.FloatValue}");
        }
    }
}
