<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128656024/22.2.2%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T587301)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->

# WPF Scheduler - Implement a Custom Mapping Converter for Color Values

This example implements a mapping converter for label colors. The **Priority** enumeration stores custom [appointment labels](https://docs.devexpress.com/WPF/119214/controls-and-libraries/scheduler/appointments/labels), and the **PriorityToColorConverter** returns label colors based on enumeration values.

![image](https://github.com/DevExpress-Examples/how-to-implement-a-custom-mapping-converter-for-color-values-t587301/assets/65009440/e3746e4d-2dfa-4dd2-8d51-ccdc402dfacb)

## Files to Review

* [MainWindow.xaml](./CS/ColorMappingExample/MainWindow.xaml)
* [MainWindow.xaml.cs](./CS/ColorMappingExample/MainWindow.xaml.cs) (VB: [MainWindow.xaml.vb](./VB/ColorMappingExample/MainWindow.xaml.vb))
* [PriorityToColorConverter.cs](./CS/ColorMappingExample/PriorityToColorConverter.cs) (VB: [PriorityToColorConverter.vb](./VB/ColorMappingExample/PriorityToColorConverter.vb))

## Documentation

* [Mapping Converters](https://docs.devexpress.com/WPF/119833/controls-and-libraries/scheduler/data-binding/mapping-converters)
* [Mappings](https://docs.devexpress.com/WPF/119493/controls-and-libraries/scheduler/data-binding/mappings)
