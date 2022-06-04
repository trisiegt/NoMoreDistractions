@echo off
reg add HKLM\Software\Policies\Microsoft\Windows\OOBE /v DisablePrivacyConsent /t REG_DWORD /d 1