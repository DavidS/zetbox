@echo off
rem ********************************************************************************
rem copy all generated code back to the Zetbox Project for compiling the fallback
rem Used by other command files
rem ********************************************************************************

rem *********** Interface *********** 
del /S /Q .\Zetbox.Objects\*.*
xcopy /s /y bin\CodeGen\Zetbox.Objects\*.* .\Zetbox.Objects

rem *********** Server - EF *********** 
del /S /Q .\Zetbox.Objects.Ef\*.*
xcopy /s /y bin\CodeGen\Zetbox.Objects.Ef\*.* .\Zetbox.Objects.Ef

rem *********** Server - NHibernate *********** 
del /S /Q .\Zetbox.Objects.NHibernate\*.*
xcopy /s /y bin\CodeGen\Zetbox.Objects.NHibernate\*.* .\Zetbox.Objects.NHibernate

rem *********** Memory *********** 
del /S /Q .\Zetbox.Objects.Memory\*.*
xcopy /s /y bin\CodeGen\Zetbox.Objects.Memory\*.* .\Zetbox.Objects.Memory

rem *********** Assets *********** 
xcopy /s /y bin\CodeGen\Assets\*.* .\Zetbox.Assets

rem *********** Assemblies *********** 
rem Do not copy assemblies

rem *********** Build *********** 
rem do not rebuild code as we can't find Arebis
rem C:\Windows\Microsoft.NET\Framework\v3.5\MSBuild.exe /m Zetbox.Complete.sln

exit /b 0