   M S B A M L   `   `   `  ����C  ?SysGuard, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:SysGuard.VistaSysGuard.Vista  5          SysGuard.Vista.Monitoreo   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      .localclr-namespace:SysGuard.Vista     5      ���#444444.��5
      � $��15q�6     � ColumnDefinitions  5   
   �� 5      �� 5      .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ dataGrid��5         AutoGenerateColumns .  $��0��6A   ���#444444$��10q�6f      	CellStyle 5      �� 5       �� 
TargetType*  $System.Windows.Controls.DataGridCell"  6   .�5      ��  �� Property � �� �� Value �#44444463   �� 5       � ��
 �����63   �� 5       � ��
 �����64   �� 5       � ��$ 1q�68   �� 5       � ��$ 5q�60   5         ColumnHeaderStyle 5      �� 5      =  7System.Windows.Controls.Primitives.DataGridColumnHeader"  6   .�5      ��  � �� �#44444463   �� 5       � ��
 �����63   �� 5        � ��
 �����64   �� 5!       � ��$ 1q�68   �� 5"       � ��$ 5q�60   5#         Columns 5&      0  *System.Windows.Controls.DataGridTextColumn  5'      ,  &System.Windows.Controls.DataGridColumn	   Header$	 Nombre��6%   
   Width5  /System.Windows.Controls.DataGridLengthConverter$	
 165 6P   1  +System.Windows.Controls.DataGridBoundColumn   Binding 65   �� *Nombre+6P     5(      $	 Actual��6%   $
 50 6P    65   �� *Actual+6P     5)      $		 Min��6%   $
 50 6J    62   �� *Min+6J     5*      $	 Media��6%   $
 50 6N    64   �� *Media+6N     5+      $		 Max��6%   $
 50 6J    62   �� *Max+6J   5-      � 5/   
   -   5         �Name$ 	chartGrid��5/      $��1��6"   $��10q�62     50      �� 51      $��* �6#   �� 52      $��* �6#   �� 53      $��* �6#   �� 54      $��* �6#    � RowDefinitions 57      �� 58      $��20 �6    �� 59      $��* �6    .+�5=      �� $��0��6   $��1��6$   ���#4CAF50$��Bottom=�6F   $	��220��6a   $
��20 0q�6n   �� 5>      $��1��6   $��1��6$   ���#2196F3$��Bottom=�6F   $	��150��6a   $
��20 0q�6n   �� 5?      $��2��6   $��1��6$   ���#FFC107$��Bottom=�6F   $	��230��6a   $
��20 0q�6n   �� 5@      $��3��6   $��1��6$   ���#FF5722$��Bottom=�6F   $	��300��6a   $
��20 0q�6n   �� 5C      $��0��6   $��1��6(   $��Actual��65   $��Center=�6C   $	��Top=�6`   $��0,0,0,5q�6x   
�������6�   �� 5D      $��1��6   $��1��6(   $	��Min��65   $��Center=�6@   $	��Top=�6]   $��0,0,0,5q�6u   
�������6�   �� 5E      $��2��6   $��1��6(   $��Media��65   $��Center=�6B   $	��Top=�6_   $��0,0,0,5q�6w   
�������6�   �� 5F      $��3��6   $��1��6(   $	��Max��65   $��Center=�6@   $	��Top=�6]   $��0,0,0,5q�6u   
�������6�   �� 5H      $��0��6   $��0��6(   $��TEMPERATURA PROCESADOR��65   $��4��6S   $��Center=�6g   $��Center=�6�   $��0,0,0,5q�5I      $��16(�6)   
�������67   5J      5M      5N      