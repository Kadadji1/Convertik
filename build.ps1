param([ValidatePattern('^\d+\.\d+(\.\d+){0,2}
Push-Location $PSScriptRoot
try {
    dotnet publish src/FileWheel.App/FileWheel.App.csproj -c Release -r win-x64 --self-contained -p:Version=$Version -o publish
    if ($LASTEXITCODE -ne 0) { throw 'Сборка Convertik завершилась с ошибкой.' }
    & ./scripts/bundle-pandoc.ps1 -Destination ./publish/tools
    Copy-Item LICENSE, THIRD-PARTY-NOTICES.md, README.md publish/
    Write-Output 'Готово: publish/Convertik.exe'
}
finally { Pop-Location }
)][string]$Version = '1.0.1')
$ErrorActionPreference = 'Stop'
Push-Location $PSScriptRoot
try {
    dotnet publish src/FileWheel.App/FileWheel.App.csproj -c Release -r win-x64 --self-contained -p:Version=1.0.0 -o publish
    if ($LASTEXITCODE -ne 0) { throw 'Сборка Convertik завершилась с ошибкой.' }
    & ./scripts/bundle-pandoc.ps1 -Destination ./publish/tools
    Copy-Item LICENSE, THIRD-PARTY-NOTICES.md, README.md publish/
    Write-Output 'Готово: publish/Convertik.exe'
}
finally { Pop-Location }
