param(
    [ValidatePattern('^\d+\.\d+(\.\d+){0,2}$')]
    [string]$Version = '1.0.1'
)
$ErrorActionPreference = 'Stop'
Push-Location $PSScriptRoot
try {
    dotnet publish src/FileWheel.App/FileWheel.App.csproj -c Release -r win-x64 --self-contained -p:Version=$Version -o publish
    if ($LASTEXITCODE -ne 0) { throw 'Convertik build failed.' }
    Get-ChildItem -Path ./publish -Filter *.pdb -Recurse -File | Remove-Item -Force
    & ./scripts/bundle-pandoc.ps1 -Destination ./publish/tools
    Copy-Item LICENSE, THIRD-PARTY-NOTICES.md, README.md publish/
    Write-Output 'Ready: publish/Convertik.exe'
}
finally { Pop-Location }
