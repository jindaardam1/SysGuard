   M S B A M L   `   `   `  ����C  ?SysGuard, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:SysGuardSysGuard  5   	       SysGuard.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:SysGuard     5   	   -   5        $
��1000��5   	   $	��700��6     � 
ResizeMode$  NoResize=�5	   	    � ShowInTaskbar .   � WindowStyle$
 None=�5   	    � WindowStartupLocation$ CenterScreen=�6   .��5      �  � RowDefinitions 5   
   �� 5      $��35 �6   �� 5      $��* �6   .+�5   
   �� -   5         ��Name$ TitleBar��5      ���#B8D600$��35��68   $��0��6D   ._�5      � .+�5      �� $��SysGuard 1.0.0��6   $��Center=�62   $
��Left=�6M   $��10,0,0,5q�6h   
���   �$��18(�6�   $��Counter-Strike)�6�   �� 5      -   5        $��Center=�5      $��Right=�64   $��0,0,0,0q�6P   
�������$��35��6�   $��50��6�   
������ $��5q�6�   $��0q�6�   .��5      �� $��../Imagenes/cerrar.png��6   5      �� 5      -   5        $��Center=�5      $��Right=�64   $��0,0,50,0q�6P   
�������$��35��6�   $��50��6�   
������ $��5q�6�   $��0q�6�   .��5      �� $��../Imagenes/maximizar.png��6   5      �� 5      -   5        $��Center=�5      $��Right=�64   $��	0,0,100,0q�6P   
�������$��35��6�   $��50��6�   
������ $��0q�6�   .��5      �� $��../Imagenes/menos.png��6   5      5      5        � 5"   
   -   5          �Name$ MainContent��5"        � NavigationUIVisibility$ Hidden=�6%   $��1��6E   5#      5$      