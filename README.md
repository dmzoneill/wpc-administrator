# WPC Administrator

<p align="center">
  <img src=".github/logo.png" alt="wpc-administrator logo" width="128" />
</p>

A Windows Forms tool for administering Workstation Policy Control (WPC)
settings on a Windows machine.

## What it does

- Lists running processes on a **Processes** tab, with a context menu to
  add a process to the allowed list, kill it, show its dependencies or
  search for it on Google.
- Keeps an editable list of **Allowed Processes** that can be added to,
  deleted from and saved, with an option to close other processes
  automatically.
- Lists Windows services with their real names and state on a
  **Services** tab.

The assembly builds as `Windows Controller` from the `SystemTray`
project.

## Tech

- Visual Basic .NET (Windows Forms)
- `System.ServiceProcess` and `System.Diagnostics`

## Building

Open the `.sln` file in Visual Studio and build it. The project was
upgraded to the Visual Studio 2005 format (.NET Framework 2.0) and targets
Windows only.

## License

Licensed under the Apache License 2.0. See [LICENSE](LICENSE).
