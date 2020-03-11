# -*- coding: utf-8 -*-
# 通过ADB命令实现自动翻页阅读

from datetime import datetime
import os
import sys
import time
import math
import random

flag = 1
v_date	= datetime.now().strftime('%H:%M')
# 计数
numCount = 0
# 实现点击操作
CMD = 'adb shell input tap 1000 1000'
# 实现右滑操作
CMD_ToRight = 'adb shell input swipe 200 1620 1000 1620'
# 实现左滑操作
CMD_ToLeft = 'adb shell input swipe 1000 1620 200 1620'

while(flag != 0):
	numCount += 1
	time.sleep(random.uniform(15, 20))
	print('阅读',numCount-round(numCount/15),'页')
	if(numCount%15 == 0):
		os.system(CMD_ToRight)
	os.system(CMD_ToLeft)