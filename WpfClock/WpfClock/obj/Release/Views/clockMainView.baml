   M S B A M L   `   `   `  ���� C  ?WpfClock, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:WpfClock.ViewsWpfClock.Views  1clr-namespace:WpfClock.ModelsWpfClock.Models  "    WpfClock.Views.clockMainView   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     .localclr-namespace:WpfClock.Views     +sclr-namespace:WpfClock.Models       � Title$  clockMainView��$	��500��$	��250�� � AllowsTransparency .  � WindowStyle$
 None=� � 
ResizeMode$ NoResize=� � WindowStartupLocation$ CenterScreen=� � Icon$+ %/WpfClock;component/Resources/sun.png����Z�  � 	Resources    sbMinuteHand �� TargetProperty �� 
TargetName	 g� RepeatBehavior9  3System.Windows.Media.Animation.EasingDoubleKeyFrame
 O� KeyTime O� Value R� KeyTime  System.Windows.Visibility   Hidden R� Value  
sbHourHand  sbSettingsBorderMinimize   Visible  sbSettingsBorderMaximize��%>  &	        &	 b    &	 t    &	 �    �� .��U� $V P(UIElement.RenderTransform).(TransformGroup.Children)[2].(RotateTransform.Angle)�$ 
minuteHand��$	 Forever��.\�  $
 0:0:0��$ 0Q�  $
 0:0:1��$ 6Q�  $
 0:0:2��$ 12Q�  $
 0:0:3��$ 18Q�  $
 0:0:4��$ 24Q�  $
 0:0:5��$ 30Q�  $
 0:0:6��$ 36Q�  $
 0:0:7��$ 42Q�  $
 0:0:8��$ 48Q�  $
 0:0:9��$ 54Q�  $
 0:0:10��$ 60Q�  $
 0:0:11��$ 66Q�  $
 0:0:12��$ 72Q�  $
 0:0:13��$ 78Q�  $
 0:0:14��$ 84Q�  $
 0:0:15��$ 90Q�  $
 0:0:16��$ 96Q�  $
 0:0:17��$	 102Q�  $
 0:0:18��$	 108Q�  $
 0:0:19��$	 114Q�  $
 0:0:20��$	 120Q�  $
 0:0:21��$	 126Q�  $
 0:0:22��$	 132Q�  $
 0:0:23��$	 138Q�  $
 0:0:24��$	 144Q�  $
 0:0:25��$	 150Q�  $
 0:0:26��$	 156Q�  $
 0:0:27��$	 162Q�  $
 0:0:28��$	 168Q�  $
 0:0:29��$	 174Q�  $
 0:0:30��$	 180Q�  $
 0:0:31��$	 186Q�  $
 0:0:32��$	 192Q�  $
 0:0:33��$	 198Q�  $
 0:0:34��$	 204Q�  $
 0:0:35��$	 210Q�  $
 0:0:36��$	 216Q�  $
 0:0:37��$	 222Q�  $
 0:0:38��$	 228Q�  $
 0:0:39��$	 234Q�  $
 0:0:40��$	 240Q�  $
 0:0:41��$	 246Q�  $
 0:0:42��$	 252Q�  $
 0:0:43��$	 258Q�  $
 0:0:44��$	 264Q�  $
 0:0:45��$	 270Q�  $
 0:0:46��$	 276Q�  $
 0:0:47��$	 282Q�  $
 0:0:48��$	 288Q�  $
 0:0:49��$	 294Q�  $
 0:0:50��$	 300Q�  $
 0:0:51��$	 306Q�  $
 0:0:52��$	 312Q�  $
 0:0:53��$	 318Q�  $
 0:0:54��$	 324Q�  $
 0:0:55��$	 330Q�  $
 0:0:56��$	 336Q�  $
 0:0:57��$	 342Q�  $
 0:0:58��$	 348Q�  $
 0:0:59��$	 354Q�  $
 0:1:0��$	 360Q�T� $ (UIElement.Visibility)�$ settingsBorder��..�i� $ 0��# Z �� .��U� $V P(UIElement.RenderTransform).(TransformGroup.Children)[2].(RotateTransform.Angle)�$ hourHand��$	 Forever��.\�  $
 0:0:0��$ 0Q�  $
 0:1:0��$ 6Q�  $
 0:2:0��$ 12Q�  $
 0:3:0��$ 18Q�  $
 0:4:0��$ 24Q�  $
 0:5:0��$ 30Q�  $
 0:6:0��$ 36Q�  $
 0:7:0��$ 42Q�  $
 0:8:0��$ 48Q�  $
 0:9:0��$ 54Q�  $
 0:10:0��$ 60Q�  $
 0:11:0��$ 66Q�  $
 0:12:0��$ 72Q�  $
 0:13:0��$ 78Q�  $
 0:14:0��$ 84Q�  $
 0:15:0��$ 90Q�  $
 0:16:0��$ 96Q�  $
 0:17:0��$	 102Q�  $
 0:18:0��$	 108Q�  $
 0:19:0��$	 114Q�  $
 0:20:0��$	 120Q�  $
 0:21:0��$	 126Q�  $
 0:22:0��$	 132Q�  $
 0:23:0��$	 138Q�  $
 0:24:0��$	 144Q�  $
 0:25:0��$	 150Q�  $
 0:26:0��$	 156Q�  $
 0:27:0��$	 162Q�  $
 0:28:0��$	 168Q�  $
 0:29:0��$	 174Q�  $
 0:30:0��$	 180Q�  $
 0:31:0��$	 186Q�  $
 0:32:0��$	 192Q�  $
 0:33:0��$	 198Q�  $
 0:34:0��$	 204Q�  $
 0:35:0��$	 210Q�  $
 0:36:0��$	 216Q�  $
 0:37:0��$	 222Q�  $
 0:38:0��$	 228Q�  $
 0:39:0��$	 234Q�  $
 0:40:0��$	 240Q�  $
 0:41:0��$	 246Q�  $
 0:42:0��$	 252Q�  $
 0:43:0��$	 258Q�  $
 0:44:0��$	 264Q�  $
 0:45:0��$	 270Q�  $
 0:46:0��$	 276Q�  $
 0:47:0��$	 282Q�  $
 0:48:0��$	 288Q�  $
 0:49:0��$	 294Q�  $
 0:50:0��$	 300Q�  $
 0:51:0��$	 306Q�  $
 0:52:0��$	 312Q�  $
 0:53:0��$	 318Q�  $
 0:54:0��$	 324Q�  $
 0:55:0��$	 330Q�  $
 0:56:0��$	 336Q�  $
 0:57:0��$	 342Q�  $
 0:58:0��$	 348Q�  $
 0:59:0��$	 354Q�  $
 1:0:0��$	 360Q��� .��U� $V P(UIElement.RenderTransform).(TransformGroup.Children)[0].(ScaleTransform.ScaleY)�$ settingsBorder��.\�  $
 0��$ 1Q�  $
 0:0:1��$ 0.000Q�U� $U O(UIElement.RenderTransform).(TransformGroup.Children)[3].(TranslateTransform.Y)�$ settingsBorder��.\�  $
 0��$ 0Q�  $
 0:0:1��$
 -487Q�T� $ (UIElement.Visibility)�$ closeSettingsBtn��..�i� $ 0��# Z T� $ (UIElement.Visibility)�$ cancelSettingsBtn��..�i� $ 0��# Z T� $ (UIElement.Visibility)�$ settingsBorder��..�i� $ 0��# Z i� $ 0:0:1��# Z �� .��U� $V P(UIElement.RenderTransform).(TransformGroup.Children)[0].(ScaleTransform.ScaleY)�$ settingsBorder��.\�  $
 0��$ 0.000Q�  $
 0:0:1��$ 1Q�U� $U O(UIElement.RenderTransform).(TransformGroup.Children)[3].(TranslateTransform.Y)�$ settingsBorder��.\�  $
 0��$
 -487Q�  $
 0:0:1��$ 0Q�T� $ (UIElement.Visibility)�$ closeSettingsBtn��..�i� $ 0:0:1��# Z T� $ (UIElement.Visibility)�$ cancelSettingsBtn��..�i� $ 0:0:1��# Z T� $ (UIElement.Visibility)�$ settingsBorder��..�i� $ 0��# Z  � Triggers :�  :� RoutedEvent$ ButtonBase.Click�� :� 
SourceName$ SettingsBtn��.[��� -    ��Name$/ )sbSettingsBorderMaximize_BeginStoryboard1��#��[ :� $ ButtonBase.Click��$ closeSettingsBtn��.[��� -   $. (sbSettingsBorderMinimize_BeginStoryboard��#��[ :� $ ButtonBase.Click��$ cancelSettingsBtn��.[��� -   $/ )sbSettingsBorderMinimize_BeginStoryboard2��#��[ .���� -    ��Name$ border�� �� CornerRadius$ 5��$��1q�
����� � J� RenderTransformOrigin$ 0.5,0.5&�z�V� .~��� �� �� T� ����  �� EndPoint$ 0.5,1&� �� 
StartPoint$ 0.5,0&�.���  � Color$ Black�� � Offset$ 1Q�� $ 	#FF10103F��$ 0.728Q�._�� -    �Name$
 grid�� � RowDefinitions �� $��20 ��� $	��235 ��� $	��100 ��� $	��130 ��� $��15 � � ColumnDefinitions �� $��10 ��� $��* ��� $��10 �.+���  �� Orientation$ 
Horizontal=�$��Right=�$��1��$��0��.+��� -    ��Name$ 
RefreshBtn��$��15��$��20��$��0q�$
��left=���Z� .���� .+��� $Z��TD:\Visual Studio Projects\WpfClock\WpfClock\WpfClock\Resources\icons8-refresh-64.png��  � ToolTip$  Refresh���� -   $ SettingsBtn��$��15��$��20��$��0q�$
��left=���Z� .���� .+��� $[��UD:\Visual Studio Projects\WpfClock\WpfClock\WpfClock\Resources\icons8-settings-64.png��$  Settings���� -   $ CloseClockBtn��$��X��
�������$  Close��$��Center=�$��15��$��20��$��0q�$��Right=���Z� A� -	   ! A�Name$! clockRim��$��1��$��1��$��10�����	#FF4949DF$��0q�$	��220��$	��220��" J� Effect" -  'System.Windows.Media.Effects.BlurEffect  � -
   $ 	clockGrid��$��1��$��1��$��0.4,0,0.4,0.2q� �� $��153.6 ��� $
��60.8 ��� .+��� -   # ��Name$# 	hourBlock��$��0��$��Center=�$��Bottom=�
�������$	��100(�$��60,-6,60,22.6q�$	��137��$	��108��$ �� TextAlignment$$ Center=����� % �� Path$% 	HourBlock�& �� Mode$& OneWay=��� -   $# minuteBlock��$��Center=�$	��Top=�$��60(�
�������$��
82,88,82,0q�$��2��$��80��$��64��$$ Center=����� $% MinuteBlock�$& OneWay=��� -   ' ��Name$' fullDatePanel��$��1��$ Vertical=�.+��� -   $# 	dateBlock��$��Center=�$	��Top=�
�������$��17(�$��24��$��50,7.4,50,0q�$
��auto��$$ Center=����� $% 	DateBlock�$& OneWay=��� -   $# weekDayBlock��$��Center=�$��Bottom=�
�������$��17(����� $% WeekDayBlock�$& OneWay=�A� -   $! hourHand��$��0��
�������
�������$��104,3,104,130.6q�$ 
0.501,5.76&�$��20��$��20��z�V� .~��� �� �� T� A� -   $! 
minuteHand��
����������	#FFE8622B$��106,5,106,132.6q�$ 0.501,7.522&�$��15��$��15��z�V� .~��� �� �� T� � -   $ currentWeatherGrid��$��2��$��1�� �� $��55 ��� $��85 ���  �� $��20 ��� $��40 ��� $��25 ��� $��15 �.+��� -   $# locationBlock��$��0��$��14(�
�������$��3��$��Center=�$
��Left=����� $% LocationBlock�$& OneWay=��� -   ( ��Name$( currentWeatherImage��$��0��$��1��$��2��$��Center=�$��Center=�$��UniformToFill=�) �� StretchDirection$
) Both=�  �� $% CurrentWeatherName�$& OneWay=����� $% CurrentWeatherImage�$& OneWay=��� -   $# temperatureBlock��$��1��$��1��$��2��$��30(�
�������$��Center=�$��Center=����� $% TemperatureBlock�$& OneWay=��� -   $' weatherParameters��$��1��$��2��$��3��$ Vertical=�$��3,0,0,0q�.+��� -   $' tempHigh��$ 
Horizontal=�.+��� -   $# tempHighBlockText��$��High: ��
�������$��12(��� -   $# tempHighBlock��
�������$��12(����� $% TempHighBlock�$& OneWay=��� -   $' tempLow��$ 
Horizontal=�.+��� -   $# tempLowBlockText��$��Low: ��
�������$��12(��� -   $# tempLowBlock��
�������$��12(����� $% TempLowBlock�$& OneWay=��� -   $' humidity��$ 
Horizontal=�.+��� -   $# humidityBlockText��$��
Humidity: ��
�������$��12(��� -   $# humidityBlock��
�������$��12(����� $% HumidityBlock�$& OneWay=��� -    $
' wind��$ 
Horizontal=�.+��� -!   $# windBlockText��$��Wind: ��
�������$��12(��� -"   $# 	windBlock��
�������$��12(����� $% 	WindBlock�$& OneWay=��� -#   $' windDirection��$ 
Horizontal=�.+��� -$   $# windDirectionBlockText��$��Direction: ��
�������$��12(��� -%   $# windDirectionBlock��
�������$��12(����� $% WindDirectionBlock�$& OneWay=��� -&   $' 
lastUpdate��$ 
Horizontal=�$��Bottom=�$
��Left=�$��3��$��0��$��2��.+��� -'   $# lastUpdateBlockText��
�������$��Last update: ��$��9(��� -(   $# lastUpdateBlock��
�������$��9(�$��Bottom=����� $% LastUpdateBlock�$& OneWay=��� -)   * ��Name$* _weatherForecastList��$��3��$��1��$��Center=�$
��Left=�$��0,10,0,0q����� $% ForecastList���5  -System.Windows.Controls.ItemContainerTemplate�  .R��� ._��� $' weatherForecastItem��$ 
Horizontal=�$��14��$��Center=�.+��� 
�������$��Center=�$��Right=�$��12(�$��0,0,10,0q�$��90��$$ Right=����� $% ForecastDate��� $��30��$��30��$��Center=�$��Center=�$��0,0,10,0q����� $% CurrentWeatherImg�$& OneWay=�  �� $% CurrentWeatherName�$& OneWay=��� 
�������$��Center=�$��Right=�$��12(�$��0,0,10,0q�$��30��$$ Right=����� $% TempHighVal��� 
�����F�$��Center=�$��Right=�$��12(�$��0,0,10,0q�$��30��$$ Right=����� $% 
TempLowVal��� -*   $ settingsBorder��$��0��$��1��$��4��$	��487��$	��240��$	��Top=�$��Center=�$ 0.5,0.5&�z�V� .~��� �� �� T� ���� $ 0.5,1&�$ 0.5,0&�.��� $ Black��$ 1Q�� $ 	#FF10103F��$ 0.728Q�._��  �� $
��0.5* ��� �� .+�� -+   $ settingsParameters��$��1�� �� �� �� �� .+��� -,   $' locationDropDown��$��0��$ 
Horizontal=�$��Center=�$��5,0,0,0q�.+��� $��
Location: ��
�������$��Center=��� --   + ��Name$+ locationList��$	��152��
���   �$��0q�, w� TextPath$, FullLocation��$��10q�$��Right=�- �� IsTextSearchEnabled- . . �� 
IsEditable. . ��Z� ���� $(% "(s:LocationListModel.LocationList)�/ �� IsAsync/ . 0 �� SelectedItem0 �� $% Location�$& OneWayToSource=�1 �� Text1 �� $% FullLocation�$& OneWay=����� .R�$� ���� FullLocation��.R��� ���� *FullLocation+�� -.   $' refreshIntervalDropDown��$��1��$ 
Horizontal=�$��Center=�$��5,0,0,0q�.+��� $��Refresh Interval: ��
�������$
��Left=�$��Center=��� -/   $+ refreshInterval��$	��115�����	#FFC56F6F
���   �$��0q�. . 2 �� 
IsReadOnly2 . 3 �� DisplayMemberPath$3  ��$��10q�- . $��Right=�1 �� $% RefreshInterval����� $% RefreshIntervalList�$& OneWay=��� $��2��$ Vertical=�$
��Left=�.+��� 
�������$��Measurement units : ��$��10,0,0,0q��� $ Vertical=�.+�	� -0   4 	�Name$4 MetricUnits��5 	� 	GroupName$5 MeasurementUnitsGroup��$��Metric units�����	#FFEEECEA$  Celsius; meter/sec��$��30,0,0,0q��� $ Vertical=�.+�	� -1   $4 ImperialUnits��$5 MeasurementUnitsGroup��$��Imperial units�����	#FFEEECEA$  Fahrenheit; miles/hour��$��30,0,0,0q��� $��3��$ 
Horizontal=�.+��� 
�������$��
API Key : ��$��
10,10,0,10q�$��Center=�$~  xTo obtain API key, please register at OpenWeather.com. Registration is free. If API key is empty a test endpoint is used��G� )   #WpfClock.Models.PasswordHelperModel6   Attach6 . $	��175��$��Center=�$��Center=�$��10(�
�������$
��0,10q�$��0q�7   Password7 �� $% ApiKey�$& TwoWay=�8 �� UpdateSourceTrigger$8 PropertyChanged=���Z� �� $��3��
�������$��1q�$	��175��$��1��$��62,34.6,3,13.2q��� -2   $' settingsControlButtons��$��3��$ 
Horizontal=�$��Center=�.+��� -3   $ closeSettingsBtn��$��2��$��Bottom=�$��Center=�$��Save and Close��$��10q�$	��100��
���������Z� �� -4   $ cancelSettingsBtn��$��2��$��Bottom=�$��Center=�$��Cancel��$��10q�$	��100��
���������Z� �� -5   $' acknowledgement��$��4��$��1��$ 
Horizontal=�.+��� $ 
Horizontal=�.+��� -6   $# Acknowledge��$��Powered by OpenWeatherMap��
�������$��8(�9 � Cursor$
9 Hand��