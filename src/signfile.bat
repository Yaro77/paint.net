@rem echo off
if "%SIGNPDN%" == "1" (
    "C:\Program Files (x86)\Windows Kits\10\bin\x86\signtool.exe" sign %PDNPFXARG% /d "Paint.NET" /du "http://www.getpaint.net/" /t http://timestamp.comodoca.com/authenticode /v "%1" 
)

