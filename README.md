# FileWheel

FileWheel is a Windows file toolkit with a radial menu. Drag files from Explorer, hold a modifier key, and choose a conversion or action. Processing is local.

## Features

- Convert common image, audio, video, document, spreadsheet, subtitle, and archive formats.
- Resize images to a chosen bounding box, compress them, and remove metadata.
- Rename a batch of files with a prefix and sequential numbers.
- Build reusable conversion presets, watch folders, and manage queued jobs.
- Keep originals intact during conversion. Batch rename changes the selected file names in place.

## Requirements

- Windows 10 (version 1809 or later) or Windows 11, x64.
- .NET SDK 10 to build from source.
- Inno Setup 6 or 7 to create the installer.

## Build and test

```powershell
./build.ps1
dotnet test tests/FileWheel.Tests -c Release
./publish/FileWheel.exe --self-test ./self-test
```

To create an installer, run `./scripts/build-installer.ps1` after the build. Third-party components retain their own licenses; see `LICENSE` and `THIRD-PARTY-NOTICES.md`.

## Attribution and status

FileWheel is a modified project based on the MIT-licensed Sweetch source. Copyright notices are retained in `LICENSE`; third-party terms are listed in `THIRD-PARTY-NOTICES.md`. FileWheel is a working product name and has not been cleared for commercial use. Update this page with the product owner's contact, support and release links before public launch.
