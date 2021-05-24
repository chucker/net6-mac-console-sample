# net6-mac-console-sample
A minimal example of using .NET 6 for an app that uses macOS native APIs

## Build

Start with a console template: `dotnet new console`.

In the `csproj`,

* Change the target framework to `net6.0-macos`
* Specify the runtime identifier `osx-x64`
* Add `<SelfContained>true</SelfContained>`

During previews, add a `NuGet.config` so you get packages such as `microsoft.macos.runtime.osx-x64`

Add an `Info.plist`.

Your project now references Cocoa. You can do `using Foundation` for low-level types like `NSString`, and `using AppKit` for GUI types like `NSTextView`.

## Run

As of preview 3, you must run the binary inside the bundle for the libraries to be found correctly, e.g.:

    bin/Debug/net6.0-macos/osx-x64/net6-console-mac-sample.app/Contents/MacOS/net6-console-mac-sample

This will not work:

    dotnet bin/Debug/net6.0-macos/osx-x64/net6-console-mac-sample.dll
