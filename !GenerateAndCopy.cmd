@echo off
echo ********************************************************************************
echo Only Generating and Publish
echo Used if only frozen objects has changed
echo ********************************************************************************

bin\Debug\bin\Server\Kistl.Server.Service.exe Kistl.Server.Service\DefaultConfig%zenv%.xml -generate
IF ERRORLEVEL 1 GOTO FAIL

rem refresh local code
call GetCodeGen.cmd
IF ERRORLEVEL 1 GOTO FAIL

bin\debug\bin\Server\Kistl.Server.Service.exe Kistl.Server.Service\DefaultConfig%zenv%.xml -publish Kistl.Server\Database\Database.xml *
IF ERRORLEVEL 1 GOTO FAIL

bin\debug\bin\Server\Kistl.Server.Service.exe Kistl.Server.Service\DefaultConfig%zenv%.xml -publish Kistl.Server\Database\KistlBase.xml KistlBase GUI
IF ERRORLEVEL 1 GOTO FAIL

echo ********************************************************************************
echo ************************************ Success ***********************************
echo ********************************************************************************
GOTO EOF

:FAIL
echo ********************************************************************************
echo ************************************* FAIL *************************************
echo ********************************************************************************
echo Aborting reset.

:EOF
pause