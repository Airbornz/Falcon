@echo OFF
echo Please ensure you are running this as an Admin otherwise it will not work!
pause
echo Setting up automatic restore points...

echo Adding registry key...
REG ADD "HKLM\Software\Microsoft\Windows NT\CurrentVersion\SystemRestore" /v SystemRestorePointCreationFrequency /t REG_DWORD /d 0 /f
echo Added registry key!

echo Scheduling task...
schtasks /create /tn "Daily Restore Point" /tr "Wmic.exe /Namespace:\\root\default Path SystemRestore Call CreateRestorePoint ARP, 100, 7" /sc daily /st 08:00 /mo 1 /ru System
echo Done!

echo Restore points will be done daily on this PC from now on.

pause
exit