@echo off

rem path to msbuild.exe
path=%path%;%windir%\Microsoft.net\Framework\v4.0.30319

rem go to current folder
cd %~dp0

msbuild build.proj

candle wix\bitbucket-backup.wxs
light bitbucket-backup.wixobj -out release\msi\bitbucket-backup.msi

pause