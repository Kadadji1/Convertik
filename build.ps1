$ErrorActionPreference = 'Stop'
Push-Location $PSScriptRoot
try {
    dotnet publish src/FileWheel.App/FileWheel.App.csproj -c Release -r win-x64 --self-contained -p:Version=1.0.0 -o publish
    if ($LASTEXITCODE -ne 0) { throw 'Сборка FileWheel завершилась с ошибкой.' }
    & ./scripts/bundle-pandoc.ps1 -Destination ./publish/tools
    Copy-Item LICENSE, THIRD-PARTY-NOTICES.md, README.md publish/
    Write-Output 'Готово: publish/FileWheel.exe'
}
finally { Pop-Location }
