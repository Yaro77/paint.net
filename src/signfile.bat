@rem echo off
if "%SIGNPDN%" == "1" (
    "%WIN_SDK_TOOLS%\signtool.exe" sign %PDNPFXARG% /d "Paint.NET" /du "http://www.getpaint.net/" /t http://timestamp.comodoca.com/authenticode /v "%1" 
)

