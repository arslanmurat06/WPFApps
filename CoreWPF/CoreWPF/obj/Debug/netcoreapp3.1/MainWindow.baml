   M S B A M L   `   `   `  ����B  >CoreWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:CoreWPF.ValidationCoreWPF.Validation  5   	   !clr-namespace:CoreWPFCoreWPF  5	   	   ;"clr-namespace:CoreWPF.UserControlsCoreWPF.UserControls  5
   	       CoreWPF.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   b ^MaterialDesignThemes.Wpf, Version=3.2.0.1979, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   X TXceed.Wpf.Toolkit, Version=4.0.0.0, Culture=neutral, PublicKeyToken=3e4669d2f30244f44xctk)http://schemas.xceed.com/wpf/xaml/toolkit  5   	   1
validation clr-namespace:CoreWPF.Validation  5   	   !localclr-namespace:CoreWPF  5	   	   5userControls"clr-namespace:CoreWPF.UserControls  5
   	     � WindowStartupLocation$  CenterScreen=�5   	    � WindowStyle$
 None=�5   	    � 
ResizeMode$ CanResizeWithGrip=�5   	    � AllowsTransparency$
 True��5   	   $	��600��5   	   $
��1024��6    � DataContext 5   	   ��    Locator �� Source# [   �� Path$ MainViewModel�.��5      )  #MaterialDesignThemes.Wpf.DialogHost    MaterialDesignDivider#���  6       DialogContent 5   
     5      -   5          Name$ SaveCategoryDialog��5   ^   #���  6(    5      � 5      $	��300��6   $	��300��6'   $��Center=�64   	 � RowDefinitions	 5      �� 5      �� 5      �� 5      �� 5      
 � ColumnDefinitions
 5"      �� 5#      �� 5$      .+�5'      �� $��0��6%   $��2��62    �� Orientation$ 
Horizontal=�6F   .+�5(      '  !MaterialDesignThemes.Wpf.PackIcon     Kind$ Category=�66     PrimaryHueMidBrush#��[ 6F   $��50��6w   $��50��6�   �� 5)      $��Center=�6(   $��16(�6C   
�������$
��Wrap=�6e   Create a new category5+      5,      �� 51      $��1��6%   $��20q�62   $��Center=�6>   $
��Left=�6Y   $��0��6t   $��Title��6�   �� 52      )  #MaterialDesignThemes.Wpf.HintAssist   
HelperText$ Title cannot be empty��6#   $��10q�6`   $��1��6l      Hint$ Enter title��6y   $��Center=�6�   $
��Left=�6�   $	��200��6�   $��1��6�   .��6�   ��54      �� 55   "   $ SavedCategoryName�6*    �� UpdateSourceTrigger$ PropertyChanged=�6C    �� ValidationRules 56   &   /   )CoreWPF.Validation.NotEmptyValidationRule  57   *   ,  &System.Windows.Controls.ValidationRule   ValidatesOnTargetUpdated$
 True��6L   59   #   .��5:   ,   5;      �� 5?      $��2��6$   $��20q�61   $��Center=�6=   $
��Left=�6X   $��0��6s   $��Background Color��6�   #  Xceed.Wpf.Toolkit.ColorPicker  5@      -   5        $��ClrPcker_Background��5@   l   $��2��6�   $��1��6�   $��50��6�   $��30��6�   $
��Left=�6�   �� 5D      $��3��6%   $��2��62   $ 
Horizontal=�6G   $��Right=�6`   $��Bottom=�6|   $��15q�6�   .+�5E      ��   MaterialDesignFlatButton#���  6M   $��4q�6�   $��Center=�6�   ��6%   �� *SaveCategoryCommand+.��6�   Save5G      �� 5H         CloseDialogCommand#��Z 6%   #���  6g   $��4q�6�   $��Center=�6�   .��6�   Cancel5J      5K      5L      .��5O      � $	��400��6   $	��400��6#   $��Center=�60   	 5P      �� 5Q      $��1* �6$   �� 5R      $��3* �6$   �� 5S      $��1* �6$   .+�5X      �� $��0��6   $ 
Horizontal=�6*   $��15q�6C   .+�5Y        $
 ToDo=�6.   #��[ 6:   $��50��6k   $��50��6v   �� 5Z      -   5         ��Name$ DialogTitle��5Z   A   
�������$��18(�6h   $	��200��6v   $��15 10q�6�   $
��Wrap=�6�   ��6$   �� *DialogTitle+6�   5\      � 5^      $��1��6   	 5_      �� 5`      $��1* �6(   �� 5a      $��1* �6(   �� 5b      $��1* �6(   
 5d      �� 5e      �� 5f      .+�5i      �� $��Center=�6    $
��Left=�6;   $��30q�6V   $��0��6b   $��0��6o   $��Category��6   �� 5j      $ 
Horizontal=�6!   $��Center=�6:   $��0��6U   $��1��6b   .+�5k      �� $
��Left=�6�   $ Choose Category��6�    �� SelectedItem 6'   �� *SelectedCategory+ �� Mode$ TwoWay=�$ PropertyChanged=���6�   �� *
Categories+$ TwoWay=�$ PropertyChanged=��� 5l      $��25��6!   $��25��6-   $��25 5 0 0q�68    / +MaterialDesignFloatingActionMiniLightButton#��[ 6J    � ToolTip$1 +MaterialDesignFloatingActionMiniLightButton��5m   !      OpenDialogCommand#��Z 5n   !   .��5o        $	 Add=�5p   !   $��15��5q   !   $��15��5r   !   5s      5u      �� 5w      $��Center=�6!   $
��Left=�6<   $��30q�6W   $��1��6c   $��0��6p   $��Title��6�   �� 5x      $ Title cannot be empty��6#   $ Enter title��6a   $��Center=�6�   $
��Left=�6�   $	��150��6�   $��1��6�   $��1��6�   .��6�   ��5z      �� 5{   "   $ SavedTodoTitle�6*   $ PropertyChanged=�6@    5|   &     5}   *   $
 True��6L   5   #   .��5�   ,   5�      �� 5�      $��Center=�6%   $
��Left=�6@   $��30q�6[   $��2��6g   $��0��6t   $��Description��6�   �� 5�      $! Description cannot be empty��6&   $��2��6j   $��1��6w   $	��180��5�   "    �� AcceptsReturn$
 True��5�   "    �� IsDocumentEnabled$
 True��5�   "   " �� VerticalScrollBarVisibility$
 Auto=�5�   "    �� 	IsEnabled$
 True��5�   "   $ Description��5�   "   $��80��5�   "   . �5�      /� .T�5�   "   J� .*�6,   .*�5�   &   �� �6*   �� *SavedTodoDescription+5�   #   5�      5�      5�      �� 5�      $��2��6   $ 
Horizontal=�6*   $��Right=�6C   $��Bottom=�6_   $��15q�6z   .+�5�      �� #���  6I   $��4q�6|   $��Center=�6�   ��6!   �� *SaveTodoItemCommand+.��6�   Save5�      �� 5�      #��Z 6   #���  6_   $��4q�6�   $��Center=�6�   .��6�   Cancel5�      5�      5�      5�      .��5�   
   � 
 5�   
   �� 5�      $��80 �6   �� 5�      $��* �6   	 5�   
   �� 5�      $��20 �6   �� 5�      $��* �6   ��5�   
   �� 5�      .��5�      �  � Color$ #485563��6    � Offset$	 0.0Q�6/   � 5�      $ #29323c��6   $	 1.0Q�6/   5�      .+�5�   
   � -   5         �Name$ GridBar��5�      $��2��6    ���#0061AF$��Center=�6h   .+�5�      �� $ 
Horizontal=�6   $��Right=�62   .+�5�      �� -   5         , (MaterialDesignFloatingActionAccentButton#��[ 5�      $��25��5�      $��25��5�      
���������5�      Z� ��5�      Z� .��5�        $ WindowMinimize=�6.   $��5(�6D   5�      �� 5�      -   5        #��[ 5�      $��25��5�      $��25��5�      
���������5�      Z� ��5�      Z� .��5�        $ WindowMaximize=�6.   $��5(�6D   5�      �� 5�      -   5        #��[ 5�      $��25��5�      $��25��5�      
���������5�      Z� ��5�      Z� .��5�        $ Power=�6.   $��5(�6;   5�      5�      5�      � 5�   
   $��1��6   $��1��6   	 5�      �� 5�      $��80 �6    �� 5�      $��* �6    �� 5�      $��50 �6    .+�5�      �� $��0��6   $
��Left=�6&   $��Center=�6A   .+�5�      �� $��YOUR TODO LIST��6   
�������$��30(�6J   $��Light"�6X   $��	Helvetica)�6k   $��0 50 0 0q�6�   5�      �� 5�      $��1��6   .��5�      � $��0 20 0 0q�6   .+�5�      �� ��6'   �� *FilteredCategories+��5�      �� 5�   "   .R�5�   &   .   (CoreWPF.UserControls.CategoryUserControl  5�   #   ��5�      �� 5�   "   .R�5�   &   �  � Orientation$ 
Horizontal=�60   5�   #   5�      5�      5�      �� 5�      $��2��6   $��
0 -20 20 0q�6&   $��Right=�6:   .+�5�      �� $��45��6   $��45��6$   ���#0061AF * &MaterialDesignFloatingActionDarkButton#��[ 5      $, &MaterialDesignFloatingActionDarkButton��5     #��Z 5     .��5       $	 Add=�5     $��24��5     $��24��5     5     5     5
     5     5     5     