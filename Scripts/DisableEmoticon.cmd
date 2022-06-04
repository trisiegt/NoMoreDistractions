@echo off
reg add HKLM\SYSTEM\CurrentControlSet\Control\CrashControl /v DisableEmoticon /t REG_DWORD /d 0
