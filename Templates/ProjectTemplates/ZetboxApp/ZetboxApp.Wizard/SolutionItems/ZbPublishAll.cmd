@echo off
echo ********************************************************************************
echo Publish the basic modules for committing and deployment.
echo This updates the Modules and generated code in the source directory.
echo Use this to publish local changes in the basic modules.
echo ********************************************************************************

set config=

if .%1. == .. GOTO GOON

set config=%1

:GOON
pushd

cd bin\Debug

Zetbox.Cli.exe %config% -fallback -generate -updatedeployedschema -repairschema
IF ERRORLEVEL 1 GOTO FAIL

Zetbox.Cli.exe %configs% -generate-resources=$safesolutionname$
IF ERRORLEVEL 1 GOTO FAIL

cd ..\..
call ZbInstall %config%
IF ERRORLEVEL 1 GOTO FAIL
cd bin\Debug

rem *********** Assets ***********
xcopy /s /y ..\CodeGen\Assets\*.* ..\..\$safesolutionname$.Assets

rem publish schema data for $safesolutionname$ project
Zetbox.Cli.exe %config% -publish ..\..\Modules\$modulename$.xml -ownermodules $modulename$;$modulename$.Config
IF ERRORLEVEL 1 GOTO FAIL

rem export $safesolutionname$.Config data
rem Zetbox.Cli.exe %config% -export ..\..\Data\$modulename$.Config.xml -schemamodules $modulename$.Config
rem IF ERRORLEVEL 1 GOTO FAIL

rem export $safesolutionname$.Data data
rem Zetbox.Cli.exe %config% -export ..\..\Data\$modulename$.Data.xml -schemamodules $modulename$ -ownermodules $modulename$
rem IF ERRORLEVEL 1 GOTO FAIL

rem optinal export SchemaMigration projects
rem Zetbox.Cli.exe %config% -export ..\..\Data\SchemaMigrationProject.xml -schemamodules SchemaMigration
rem IF ERRORLEVEL 1 GOTO FAIL

popd
echo ********************************************************************************
echo ************************************ Success ***********************************
echo ********************************************************************************
GOTO EOF

:FAIL
popd
echo XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX
echo XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX FAIL XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX
echo XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX
echo                                Aborting Publish
rem return error without closing parent shell
echo A | choice /c:A /n

:EOF
