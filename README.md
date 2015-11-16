# Paint.net
cone of paint.net 3.36, that's latest opensource version

## Missing projects
1. Missing *Resources.mui* project with localized strings
2. Missing installer and merge modules projects

## Build remarks
### Windows
1. Projects target platform updated to .NET 4.5
2. Set up environment variable %WIN_SDK_TOOLS% points to folder with *mt.exe* and *signtool.exe*. I personnaly use *x86* environment path C:\Program Files (x86)\Windows Kits\10\bin\x86