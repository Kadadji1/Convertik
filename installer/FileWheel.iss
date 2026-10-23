#ifndef AppVersion
  #define AppVersion "1.0"
#endif
#ifndef PublishDir
  #define PublishDir "..\publish"
#endif
#ifndef ArtifactsDir
  #define ArtifactsDir "..\artifacts"
#endif

[Setup]
AppId={{3DA6D351-5305-41DD-95CC-626A8671CD1D}
AppName=FileWheel
AppVersion={#AppVersion}
AppVerName=FileWheel {#AppVersion}
AppPublisher=Vladyslav Kononov
DefaultDirName={localappdata}\Programs\FileWheel
DefaultGroupName=FileWheel
DisableProgramGroupPage=yes
PrivilegesRequired=lowest
MinVersion=10.0.17763
ArchitecturesAllowed=x64compatible
ArchitecturesInstallIn64BitMode=x64compatible
OutputDir={#ArtifactsDir}
OutputBaseFilename=FileWheel-{#AppVersion}-Setup-win-x64
SetupIconFile=..\src\FileWheel.App\Assets\FileWheel.ico
UninstallDisplayIcon={app}\FileWheel.exe
UninstallDisplayName=FileWheel
Compression=lzma2
SolidCompression=yes
WizardStyle=modern
CloseApplications=yes
RestartApplications=no

[Languages]
Name: "english"; MessagesFile: "compiler:Default.isl"
Name: "russian"; MessagesFile: "compiler:Languages\Russian.isl"

[Tasks]
Name: "desktopicon"; Description: "{cm:CreateDesktopIcon}"; GroupDescription: "{cm:AdditionalIcons}"; Flags: unchecked

[Files]
Source: "{#PublishDir}\*"; DestDir: "{app}"; Flags: recursesubdirs createallsubdirs ignoreversion

[Icons]
Name: "{userprograms}\FileWheel"; Filename: "{app}\FileWheel.exe"
Name: "{userdesktop}\FileWheel"; Filename: "{app}\FileWheel.exe"; Tasks: desktopicon

[Run]
Filename: "{app}\FileWheel.exe"; Description: "{cm:LaunchProgram,FileWheel}"; Flags: nowait postinstall skipifsilent

[UninstallRun]
Filename: "{app}\FileWheel.exe"; Parameters: "--unregister"; Flags: runhidden waituntilterminated; RunOnceId: "Unregister"
