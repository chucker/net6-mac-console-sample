# net6-mac-console-sample
A minimal example of using .NET 6 for an app that uses macOS native APIs

# Ingredients

* Start with a console template: `dotnet new console`
* Change the target framework to `net6.0-macos`, and the runtime identifier to `osx-x64`
* During previews, add a `NuGet.config` so you get packages such as `microsoft.macos.runtime.osx-x64`
* Add an Info.plist

Your project now references Cocoa. You can do `using Foundation` for low-level types like `NSString`, and `using AppKit` for GUI types like `NSTextView`.

# Status

As of preview 3, while the references do get pulled in, calling any Foundation or AppKit code at runtime seems to fail.
