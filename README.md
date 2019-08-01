# DMprojects
 My projects

## 2019年8月1日
	多语言翻译。
		1、中英文切换时，长短不一致问题。
			固定长度？
		2、程序内提示文字如何进行翻译？

## 2019年7月30日
	将阶梯钻绘图作为单独的类。

## 2019年7月20日
	实现阶梯钻头的组合。
	为方便调用，另需重载双锥和三圆角的绘制方法。

## 2019年7月18日
	实现自绘图形的拖曳和放大功能。

## 2019年7月15日
	调用已有自定义方法，连续作图，实现钻头的绘制。
	其中，钻头过渡阶梯和圆柱部分长度，需要分情况进行绘制。
	1. 圆柱长度分为：
		* 从钻头起点开始，即坐标原点开始；
		* 从钻尖末端开始，即钻尖末端坐标开始计算长度；
		* 圆柱台阶长度；
		* 圆柱台阶+过渡部分长度；

	2. 阶梯形状分为：
		* 锥形
		* 双锥
		* 2圆角
		* 3圆角

## 2019年7月12日
	重载DrawDrill方法，实现圆角的绘制。
		* 计算切点坐标。
		* 计算圆弧矩形坐标。

	实现基本方法：
		1. DrawDrill绘制钻头过渡阶梯；
		2. DrawDrill重载实现带圆角的钻头过渡阶梯；

	接下来任务：通过模块化方法实现阶梯钻头的绘制。

## 2019年7月11日
	终于，搞到一台联网的机器。
	这个时代，没有网络，人都废了。
	这两天终于搞到台联网的电脑，感觉像羁押多年被放出来了似的。
	物是人非，境况大不相同。
	不禁让我有些许怀疑，当初选择从一线城市回到这个三线城市有没有错。

	开始进行两个项目。
* 1、主项目——DrawPics。
		通过C#来进行绘图工作，用于解决工作上绘制图形的问题。

		需求: 	a：输入参数，动态变化；
				b：重载，实现阶梯钻的绘制；
				c：放大缩小功能（不急）。

* 2、副项目——ScoreManagement。
		主要是每次要输入分数到Excel，再画图太麻烦了。暂时没时间精力去捣鼓VBA，先用C#实现一个画折线图的功能。

		需求：	a：可输入，并保存每次统计分数；
				b：自动计算正确率等指标；
				c：绘制折线图，显示不同项指标值。


