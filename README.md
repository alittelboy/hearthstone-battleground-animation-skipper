# hearthstone-battleground-animation-skipper
跳过炉石传说酒馆战棋的动画，实现快速“拔线”的效果。使用快捷键操作
快捷键：qwer

## 使用语言：vb.net

## 运行环境：Windows

## 软件原理

使用防火墙禁止炉石传说进程的数据上行，然后再允许。

拔线：

netsh advfirewall firewall set rule name="lushi" new enable=yes

重连：

netsh advfirewall firewall set rule name="lushi" new enable=no
