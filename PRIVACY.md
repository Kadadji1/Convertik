# Convertik privacy

Last updated: October 24, 2026

Convertik is a Windows file utility. It processes files on your computer. The app does not require an account or upload files to a Convertik server for conversion. Converted files are saved locally. Batch renaming changes selected file names on your computer.

Convertik stores settings and presets in `%APPDATA%\FileWheel` and downloaded tools in `%LOCALAPPDATA%\FileWheel\tools`. These directory names are retained for compatibility with existing installs.

Some features involve other software or services:

- If you choose to obtain FFmpeg, Convertik downloads the tool from a third-party provider and verifies its published SHA-256. The provider may receive the usual network request information, such as your IP address. Audio and video conversion then runs locally.
- Some Office and PDF operations require a separately installed LibreOffice. Pandoc is bundled with the app.
- The Windows Share feature passes files you select to the Windows share interface and the destination you choose.
- “Send feedback” prepares a short diagnostic summary (app version, operating system, architecture) for you to review and copy. It does not send that summary automatically.

Convertik does not currently have an account, cloud sync, analytics service, or automatic update checks. GitHub processes data when you visit the repository, download a release, or submit an issue under its own terms.

For privacy questions or support, open an issue at https://github.com/Kadadji1/Convertik/issues. Avoid including private files or personal data in public issues.
