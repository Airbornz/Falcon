@echo off

:start
echo Strip by Cole Kasaba
echo Please use this as the user that you want the ownership to be under
pause
GOTO step1

:step1
color 08
echo Please enter the file location you wish to take ownership of.
set /p var=Location:
goto step2

:step2
takeown /F %var% /R /D Y
echo.
color 27
echo Process is complete
pause
goto step1

