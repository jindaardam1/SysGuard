   M S B A M L   `   `   `  ���� C  ?SysGuard, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:SysGuard.VistaSysGuard.Vista      SysGuard.Vista.Monitoreo   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     .localclr-namespace:SysGuard.Vista     ���#444444.��� $��15q�  � ColumnDefinitions  �� �� .+�&   System.Windows.Controls.DataGrid  -     Name$ dataGrid��   AutoGenerateColumns .  $��0�����#444444$��10q�   	CellStyle ��  �� 
TargetType*  $System.Windows.Controls.DataGridCell"  .���  �� Property � �� �� Value �#444444��  � ��
 �������  � ��
 �������  � ��$ 1q���  � ��$ 5q�   ColumnHeaderStyle �� =  7System.Windows.Controls.Primitives.DataGridColumnHeader"  .���  � �� �#444444��  � ��
 �������  � ��
 �������  � ��$ 1q���  � ��$ 5q�   Columns 0  *System.Windows.Controls.DataGridTextColumn  ,  &System.Windows.Controls.DataGridColumn	   Header$	 Nombre��
   Width5  /System.Windows.Controls.DataGridLengthConverter$	
 165 1  +System.Windows.Controls.DataGridBoundColumn   Binding �� *Nombre+  $	 Actual��$
 50  �� *Actual+  $		 Min��$
 50  �� *Min+  $	 Media��$
 50  �� *Media+  $		 Max��$
 50  �� *Max+� -    �Name$ 	chartGrid��$��1��$��10q�  �� $��* ��� $��* ��� $��* ��� $��* � � RowDefinitions �� $��20 ��� $��* �.+��� $��0��$��1�����#4CAF50$��Bottom=�$	��220��$
��20 0q��� $��1��$��1�����#2196F3$��Bottom=�$	��150��$
��20 0q��� $��2��$��1�����#FFC107$��Bottom=�$	��230��$
��20 0q��� $��3��$��1�����#FF5722$��Bottom=�$	��300��$
��20 0q��� $��0��$��1��$��Actual��$��Center=�$	��Top=�$��0,0,0,5q�
��������� $��1��$��1��$	��Min��$��Center=�$	��Top=�$��0,0,0,5q�
��������� $��2��$��1��$��Media��$��Center=�$	��Top=�$��0,0,0,5q�
��������� $��3��$��1��$	��Max��$��Center=�$	��Top=�$��0,0,0,5q�
��������� $��0��$��0��$��TEMPERATURA PROCESADOR��$��4��$��Center=�$��Center=�$��0,0,0,5q�$��16(�
�������