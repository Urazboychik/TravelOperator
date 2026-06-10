# UTF-8 BOM
$ErrorActionPreference = 'Stop'
$repo = $PSScriptRoot
$port = 5055
$url = "http://127.0.0.1:$port"

function Test-AppReady {
    try {
        return (Invoke-WebRequest "$url/Home/Customer" -UseBasicParsing -TimeoutSec 3).StatusCode -eq 200
    } catch { return $false }
}

if (-not (Test-AppReady)) {
    Write-Output "Starting TravelOperator on $url ..."
    Start-Process -FilePath 'dotnet' -ArgumentList @('run', '--project', $repo, '--urls', $url) -WindowStyle Hidden
    for ($i = 0; $i -lt 40; $i++) {
        if (Test-AppReady) { break }
        Start-Sleep -Seconds 1
    }
    if (-not (Test-AppReady)) { throw "App did not start on $url" }
}

Write-Output "Local: $url"
Write-Output "Opening public tunnel via localhost.run (free, no card)..."
Write-Output "Press Ctrl+C to stop the tunnel."

ssh -o StrictHostKeyChecking=no -o ServerAliveInterval=60 -R 80:127.0.0.1:$port nokey@localhost.run
