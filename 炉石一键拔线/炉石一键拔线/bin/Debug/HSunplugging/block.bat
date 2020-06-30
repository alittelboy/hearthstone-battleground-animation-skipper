%1 mshta vbscript:CreateObject("Shell.Application").ShellExecute("cmd.exe","/c %~s0 ::","","runas",0)(window.close)&&exit
C:\Windows\System32\netsh advfirewall firewall set rule name="lushi" new enable=yes
