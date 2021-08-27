<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128567898/12.2.6%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E4558)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
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


