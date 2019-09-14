@echo off

REM # Version of used CI.MSBuild
set cimdll=packages\vsSBE.CI.MSBuild\bin\CI.MSBuild.dll

set _msbuild=tools\hMSBuild -notamd64

REM # Verbosity level by default: q[uiet], m[inimal], n[ormal], d[etailed], and diag[nostic].
set level=minimal

set _gnt=tools\gnt

:::: --------

set reltype=%~1

if "%reltype%"=="" (
    set "reltype=DCI"
)

:::: --------

set __p_call=1

:: Activate vsSBE

call %_gnt% /p:ngpath="%cd%/packages" /p:ngconfig="%cd%/.gnt/packages.config" || goto err

:: Build
set bnode=%_msbuild% E-MSBuild.sln /m:4 /l:"%cimdll%" /p:Platform="Any CPU" /v:%level% /nologo

call %bnode% /p:Configuration=%reltype%_SDK15 /t:Rebuild || goto err

goto ok

:err

echo. Build failed. 1>&2
exit /B 1

:ok
exit /B 0
