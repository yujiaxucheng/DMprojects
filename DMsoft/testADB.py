# -*- coding: utf-8 -*-
# 通过ADB命令实现自动翻页阅读

from datetime import datetime
import os
import sys
import time
import math
import random

# 时间戳
v_date	= datetime.now().strftime('%H:%M:%S')

# 计数
numCount = 0

# X[0, 1079]  Y[0, 1911]
# 实现点击操作
CMD_Tab = 'adb shell input tap 927 1186'
# 实现右滑操作
CMD_ToRight = 'adb shell input swipe 200 1620 1000 1620'
# 实现左滑操作
CMD_ToLeft = 'adb shell input swipe 1000 1620 200 1620'
# 分辨率
CMD_SHOW_SCREEN = 'adb -s cf264b8f shell wm size'

# os.system(CMD_Tab)

# 显示设备
def ShowDevice():
	CMD = 'adb devices'
	os.system(CMD)

# 显示CPU信息
def ShowCPU():
	CMD = 'adb shell cat /proc/cpuinfo'
	os.system(CMD)

# 实现滑屏操作
def MoveScreen(x1, y1, x2, y2):
	CMD = 'adb shell input swipe ' + str(x1) + ' ' + str(y1) + ' ' + str(x2) + ' ' + str(y2)
	os.system(CMD)

# 显示屏幕分辨率
def ShowScreen():
	CMD = 'adb shell wm size'
	os.system(CMD)

# 显示屏幕密度
def ShowDPI():
	CMD = 'adb shell wm density'
	os.system(CMD)

# 触发操作
def KeyEvent(icode):
	CMD = 'adb shell input keyevent ' + str(icode)
	os.system(CMD)

def Do(eventName):
	if eventName == 'RETURN':
		KeyEvent(4)
	else: # if (eventName == 'HOME')
		KeyEvent(3)

Do('HOME')
# KeyEvent(224)

# 左滑
# MoveScreen(200, 1620, 1000, 1620)

# 右滑
# MoveScreen(1000, 1620, 200, 1620)

# 上滑
# MoveScreen(500, 1000, 500, 200)

# 下滑
# MoveScreen(500, 200, 500, 1000)
