<!-- default file list -->
*Files to look at*:

* [MainPage.xaml](./CS/CustomDrawSeriesPoints/MainPage.xaml) (VB: [MainPage.xaml](./VB/CustomDrawSeriesPoints/MainPage.xaml))
* [MainPage.xaml.cs](./CS/CustomDrawSeriesPoints/MainPage.xaml.cs) (VB: [MainPage.xaml.vb](./VB/CustomDrawSeriesPoints/MainPage.xaml.vb))
<!-- default file list end -->
# How to custom draw chart  series points 


<p>This example shows how to change the color of each series point according to its values. <br />
</p><p>In addition, the point labels text is changed to show the color of the current interval (Green, Yellow, or Red).<br />
</p><p>To accomplish this, it is necessary to invoke the <a href="http://documentation.devexpress.com/#Silverlight/DevExpressXpfChartsChartControl"><u>ChartControl.CustomDrawSeriesPoint</u></a> event and change its drawing options in the CorrectDrawOptions() method.<br />
</p><p>In this example, you can deactivate the "Custom Draw" option on the stack panel to return to the default appearance of series points. </p><br />


<br/>


