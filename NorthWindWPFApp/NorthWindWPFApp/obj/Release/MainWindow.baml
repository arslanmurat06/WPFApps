   M S B A M L   `   `   `  ���� J  FNorthWindWPFApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:NorthWindWPFAppNorthWindWPFApp       NorthWindWPFApp.MainWindow   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     /localclr-namespace:NorthWindWPFApp     -     � Title$  
MainWindow��$	��450��$	��300�� � AllowsTransparency . 
������  � WindowStyle$
 None=� � 
ResizeMode$ NoResize=� � WindowStartupLocation$ CenterScreen=� +� FocusedElement ��  �� ElementName$ txtUsername�� � DataContext �� *MainViewModel+   Locator �� Source# [  	 � 	Resources	 
 �� 
TargetType �� Property �� Value �� 
TargetType �� CornerRadius �� Triggers P� Property P� Value��%[  '��       �� "
 ��.���  � ��
 �������  � ��$ 	Helvetica)���  � ��$ Light"���  � ��
 ���� ��  � �� �� " ��.R��� #��z��$ 20��$��2q�
�������._��� $��Center=�$��Center=� P�  �@J�IsMouseOver . . ���  � ��
 �������  �@J�Opacity$	 0.4Q���  � ��
 ��� �.���  � RowDefinitions �� �� .+��� $ 10��$��2������ .���  � Color$ #7be9f6�� � Offset$	 0.0Q�� $ #f083da��$	 1.0Q��� $��Center=�.+��� $��Images/logo.png��$	��150����  $  MaterialDesignHeadline6TextBlock#���  $��0 0 0 0q�$��Employee Management��$��Light"�$��	Helvetica)�$��22(�
�������$��Center=��� $��1��.+���  �� Orientation$ 
Horizontal=�$��Center=�.+��� -    ��Name$ txtUsername��$��Center=�$��Center=�$	��235��
�������
������ $��0q� J� Opacity$	 0.5Q�$��25������  �� Path$ Username� �� Mode$ TwoWay=��� $	����  AwesomeSolid#��[ $��15(�$��Center=�$��Center=�
��������� $	��250��$��1��
�������$	 0.5Q��� $ 
Horizontal=�$��Center=�.+�G� -    G�Name$ txtPassword�� G� PasswordChar$ *�� � ToolTip$ Enter Your Password��$
��Left=�$��14(�$��Center=�
�������$	��235��$��	0 10 0 0 q�
������ $��0q�$	 0.5Q�$��25���� $	����#��[ $��15(�$��Center=�$��Center=�
��������� $	��250��$��1��
�������$	 0.5Q��� $ 
Horizontal=�$��0 50 0 0q�$��Center=�.+��� $��0 0 15 0q�$	��100��$��40��$��LOGIN������ *LoginCommand+�� $	��100��$��40��$��REGISTER��