%1 mshta vbscript:CreateObject("Shell.Application").ShellExecute("cmd.exe","/c %~s0 ::","","runas",1)(window.close)&&exit
C:\Windows\System32\netsh advfirewall firewall delete rule name="lushi" 
C:\Windows\System32\netsh advfirewall firewall add rule name="lushi" dir=out action=block program="D:\Program Files (x86)\Hearthstone\Hearthstone.exe" enable=no
