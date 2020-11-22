# hearthstone-battleground-animation-skipper
跳过炉石传说酒馆战棋的动画，实现快速“拔线”的效果。使用快捷键操作

快捷键：qwer

相关说明：https://www.iyingdi.com/web/bbspost/detail/2250016

链接：https://pan.baidu.com/s/10HKIwMWHi7lOiOeE7hw4fg 

提取码：kpmb

## 2020.11.22更新
更新了一些说明，新增了乱码问题。新增下一步更新内容计划：
 - 设置快捷键
 - 访问网页并获取版本是否最新

## 2020.6.30更新

 - 取消了3s 的等待时间，改为自己设定
 - 把脚本目录放在运行目录，避免某些网吧电脑没有系统盘。
 - 增加背景图和部分异常说明，减少人工工作量。
 - 增加了本网址的引导，使大家遇到问题可以自行解决。
 - 现在，“炉石传说地址”和“时延设定”都本地化存储了，也就是说再次打开内容相同。其中，地址必须点击初始化才会存储到本地，时延只要修改内容就存储到本地。

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
 - 建议关闭杀毒软件
 - 有些电脑会出现乱码导致的无效，建议看下面第5条
 
 2.什么是炉石传说的安装位置
 
 右键你的炉石传说快捷方式，属性，找到“目标”一栏，把最后一个“\\”之前的内容复制下来，并替换软件里“\\Hearthstone.exe”之前的部分。
 
 3.怎么查看或开启防火墙
 
 - 查看：设置-更新和安全-Windows安全中心-防火墙
 - 开启：同上目录里开启
 - win10防火墙无法启动，错误代码0x80070422：这是你没开启防火墙服务，参考这个链接：https://answers.microsoft.com/zh-hans/windows/forum/all/win10%E9%98%B2%E7%81%AB%E5%A2%99%E6%97%A0%E6%B3%95/2b4b524c-fbe1-47cd-9600-d13519ce7200
 
 4.怎么更改Windows安全等级
 
 https://www.baidu.com/baidu?wd=%E6%80%8E%E4%B9%88%E6%9B%B4%E6%94%B9Windows%E5%AE%89%E5%85%A8%E7%AD%89%E7%BA%A7
 
 5.还是不行？
 有些电脑会出现乱码问题。
 打开设置-防火墙-高级选项-出站规则-lushi-有个选项可以查看炉石的地址，手动设置一下，即可解决。
 

