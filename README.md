# hearthstone-battleground-animation-skipper
跳过炉石传说酒馆战棋的动画，实现快速“拔线”的效果。使用快捷键操作

快捷键：qwer

修复了一个路径错误的bug

## 使用语言：vb.net

## 运行环境：Windows

## 软件原理

使用防火墙禁止炉石传说进程的数据上行，然后再允许。

拔线：

netsh advfirewall firewall set rule name="lushi" new enable=yes

重连：

netsh advfirewall firewall set rule name="lushi" new enable=no

## FAQ
1.为什么用不了？

 - 检查是否输入了炉石传说的安装位置，输入的地址结尾是否是Hearthstone.exe
 - 确认是否点击了初始化
 - 确认是最新版本的拔线器
 - 确认是否开启了防火墙，没有开启请开启
 - 请勿和vpn或者代理同时使用，可能会导致软件无效
 - 运行时跳出黑框是正常现象，跳出Windows提示授权是异常现象，自行百度更改安全等级
