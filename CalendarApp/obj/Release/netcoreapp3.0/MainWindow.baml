   M S B A M L   `   `   `  ���� F  BCalendarApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:CalendarAppCalendarApp      CalendarApp.MainWindow   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     +localclr-namespace:CalendarApp       � Title$  
MainWindow��$	��450��$	��800��.���  � ColumnDefinitions �� $��* � � RowDefinitions �� $��3* ��� $��* ��� $	��10* �.+��� $��0��$��0��$��7��
��������� -    ��Name$ Title��$��
Month Year��$��30(�$��20q�$��Center=��  � ShowGridLines$
 True��$��0��$��1�� �� $��* � �� $��* ��� $��* ��� $��* ��� $��* ��� $��* ��� $��* ��� $��* �.+��� $��0��$��0��$��7��
���� K��� $��Monday��$��0��$��0��$��Center=�$��Center=�
�������$��18(��� $��Twesday��$��0��$��1��$��Center=�$��Center=�
�������$��18(��� $��	Wednesday��$��0��$��2��$��Center=�$��Center=�
�������$��18(��� $��Thursday��$��0��$��3��$��Center=�$��Center=�
�������$��18(��� $��Friday��$��0��$��4��$��Center=�$��Center=�
�������$��18(��� $��Saturday��$��0��$��5��$��Center=�$��Center=�
�������$��18(��� $��Sunday��$��0��$��6��$��Center=�$��Center=�
�������$��18(�� -    �Name$ 	MonthView��$
 True��$��0��$��2�� �� $��* ��� $��* ��� $��* ��� $��* ��� $��* ��� $��* ��� $��* � �� $��* ��� $��* ��� $��* ��� $��* ��� $��* ��� $��* ��� -    ��Name$ 	nextMonth��$��>��$
��Left=�$��	736,0,0,0q�$��Center=�$��30��$��30���� -   $ previousMonth��$��<��$
��Left=�$��	700,0,0,0q�$��Center=�$��30��$��30��