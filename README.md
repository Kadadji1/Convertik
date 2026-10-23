# FileWheel

FileWheel is an English-first Windows file toolkit with a radial menu. Drag files from Explorer, choose a conversion, tool, or action, and keep moving. File processing happens locally.

## Download

**There is no FileWheel `.exe` release yet.** This repository currently contains the source code. The Windows build workflow is set up to produce an installer and a portable ZIP, but a FileWheel release must be built and published before those downloads appear. Check the [Releases page](https://github.com/Kadadji1/filewheel-workbench/releases) for downloads when they are available.

The original Sweetch download is a separate, unmodified upstream release. It is not a FileWheel build and still carries Sweetch branding.

## What it does

- Convert images, audio, video, PDFs, documents, spreadsheets, subtitles, and archives.
- Resize images to fit a custom width and height, compress them, and remove metadata.
- Rename a batch of files with a prefix and sequential numbering.
- Create reusable conversion presets and automatically process watched folders.
- Queue jobs and use file actions such as copy, move, inspect paths, and open a terminal.

Conversions create output files and leave the originals in place. Batch renaming changes the selected files' names in place; it checks for name conflicts before renaming.

## Quick start

After a release is available, choose one of these downloads from **Releases**:

1. **Installer** — run `FileWheel-<version>-Setup-win-x64.exe`. It installs FileWheel and adds it to the Start menu. Uninstall it through Windows Settings → Apps.
2. **Portable ZIP** — extract the whole archive, including its `tools` folder, then run `FileWheel.exe` from the extracted folder. No installer is needed.

Requirements: Windows 10 version 1809 or later, or Windows 11, 64-bit. The packages are self-contained and include the .NET runtime and Pandoc.

## Using the radial menu

1. Start dragging one or more files from File Explorer.
2. While dragging, hold or tap a modifier key to choose a menu: **Shift** for conversions, **Ctrl** for tools, or **Alt** for actions. These keys can be changed in Settings.
3. Drop the files on a menu item. Drop in the center to cancel.

For keyboard use, select files in File Explorer and press **Ctrl + Alt + Space**. Use the arrow keys to select an item, **Enter** to run it, **Tab** to switch menus, and **Esc** to close the wheel.

FileWheel runs in the Windows notification area. Double-click its tray icon to open Settings. The interface is English-only; dark, light, and system themes are available.

## Formats and optional tools

Supported operations depend on the selected files and available tools. Image support includes common formats and many camera RAW formats. Pandoc is bundled for document conversions. FFmpeg can be downloaded from Settings for audio and video operations. LibreOffice must be installed separately for some Office and PDF conversions.

Settings are stored in `%APPDATA%\FileWheel`; downloaded tools are stored in `%LOCALAPPDATA%\FileWheel\tools`. FileWheel does not overwrite source files during conversions. Updates are currently disabled, and the app does not contact an update server.

## Build and test from source

Use a Windows x64 machine with PowerShell and the **.NET 10 SDK**. The build downloads the official Pandoc package and verifies its SHA-256, so GitHub Releases must be reachable.

```powershell
./build.ps1
dotnet test tests/FileWheel.Tests -c Release
./publish/FileWheel.exe --self-test ./self-test
```

The executable is written to `publish/FileWheel.exe`. To build an installer, install [Inno Setup 6 or 7](https://jrsoftware.org/isdl.php), then run:

```powershell
./scripts/build-installer.ps1
```

The installer and portable archive are written to `artifacts/`. GitHub Actions runs the Windows tests and package checks. A tagged build (`v*`) publishes the ZIP, installer, and checksums as a GitHub Release.

## License and attribution

FileWheel is a modified project based on [Sweetch](https://github.com/krllmrzv/Sweetch), distributed under the MIT License. The upstream copyright and license notices are retained in [`LICENSE`](LICENSE); third-party component notices are in [`THIRD-PARTY-NOTICES.md`](THIRD-PARTY-NOTICES.md). The product name is provisional.
