# Convertik launch copy and media checklist

## Short description

Convertik is a Windows file toolkit built around a radial menu. Convert files, prepare images, rename batches, and automate repeat work without leaving File Explorer.

## Store description draft

Turn common file tasks into a quick gesture. Drag files from File Explorer to Convertik’s radial menu, or select files and open the menu with a keyboard shortcut. Convert images, audio, video, PDFs, documents, spreadsheets, subtitles, and archives; resize or compress images; rename batches; save presets; and set up watched folders. File processing runs locally on your PC.

Some operations require optional tools. Pandoc is bundled. FFmpeg can be downloaded from Settings for audio and video; some Office and PDF conversions require LibreOffice installed separately. Available actions depend on the selected file types and installed tools. Windows 10 version 1809 or newer / Windows 11, x64.

## Demo script (30 seconds)

1. Show a folder with mixed sample files in File Explorer.
2. Drag an image, press Shift to reveal conversions, and save a converted copy; show the original beside it.
3. Select several sample files and demonstrate batch rename with preview/conflict check.
4. Show a preset or watched folder for a repeat task.
5. End with the real download URL and Windows version requirements.

## Media to capture from the release build

- Main radial menu over File Explorer, 16:9 screenshot.
- Image operation with a before/after result.
- Batch rename screen and conflict handling.
- Settings / presets / watch folders.
- A short screen recording (horizontal and vertical cuts), with readable text and no private filenames.
- App icon at required store sizes; check the final requirements in Partner Center.

## Release checklist

- Versioned GitHub Release with installer, portable ZIP, checksums, and notes.
- Clean-machine installation and uninstall check; confirm tray icon, context-menu brand, conversion examples and optional-tool flows.
- Store submission: choose MSIX or signed offline EXE, complete Partner Center listing, and submit for certification.
- WinGet manifest pointing to the immutable release installer and SHA-256.
- Support: https://github.com/Kadadji1/Convertik/issues
- Privacy: https://github.com/Kadadji1/Convertik/blob/main/PRIVACY.md
