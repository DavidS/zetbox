param($installPath, $toolsPath, $package, $project)

$zetbox = "$installPath\..\..\.zetbox\"

if (!(Test-Path -path $zetbox)) { mkdir $zetbox }
cp "$toolsPath\*.targets" $zetbox