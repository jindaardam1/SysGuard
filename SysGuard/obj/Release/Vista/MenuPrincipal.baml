   M S B A M L   `   `   `  ���� C  ?SysGuard, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:SysGuardSysGuard      SysGuard.MenuPrincipal   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     (localclr-namespace:SysGuard     -   ����   �� Path$  ActualWidth� �� RelativeSource �� *FindAncestor+ �� AncestorType" ����� $  ActualHeight� �� *FindAncestor+" � � 	Resources    HoverGridStyle �� 
TargetType �� Property �� Value �� Triggers P� Property	 P� Value��%p   &	        �� " �.���  � ��$ 13q� P�  �@J�IsMouseOver	 . . ���  � �� �#444444.��� ���#444444
 � ColumnDefinitions
 �� $	��150 ���  � RowDefinitions �� $	��100 ��� .+�� -   $��GridBarraSuperior��$��0��$��2��$��0�����#555555
 �� $��* ��� $��2 ��� $��* ��� $��2 ��� $��* �.+�� -   $��GridCPU��$��0��$��10q� �� $��* ��� $��* �.+��� -   $��NombreProcesador��$��0��$��Counter-Strike)�$��20(�$��Center=�$��Center=�
�������$��CharacterEllipsis=� � ToolTip _� ���� $
  Text� �� *Self+� $��1��
 �� �� .+��� -   $��TemperaturaProcesador��$��0��$��Counter-Strike)�$��20(�$��Center=�$��Center=�
��������� -   $��UsoProcesador��$��1��$��Counter-Strike)�$��20(�$��Center=�$��Center=�
��������� $��1�����#B8D600$��0, 15, 0, 15q�� -   $��GridRAM��$��2��$��10q� �� $��* ��� $��* �.+��� -   $��CantidadRAM��$��0��$��Counter-Strike)�$��20(�$��Center=�$��Center=�
�������$��CharacterEllipsis=��� -	   $��PorcentajeRAM��$��1��$��Counter-Strike)�$��20(�$��Center=�$��Center=�
��������� $��3�����#B8D600$��0, 15, 0, 15q�� -
   $��GridGPU��$��4��$��10q� �� $��* ��� $��* �.+��� -   $��NombreGrafica��$��0��$��Counter-Strike)�$��20(�$��Center=�$��Center=�
������� _� ���� $
  Text� �� *Self+� $��1��
 �� �� .+��� -   $��TemperaturaGrafica��$��0��$��Counter-Strike)�$��20(�$��Center=�$��Center=�
��������� -   $��
UsoGrafica��$��1��$��Counter-Strike)�$��20(�$��Center=�$��Center=�
�������� -   $��GridBarraMenuIzquierda��$��0��$��1�����#555555 �� $��* ��� $��2 ��� $��* ��� $��2 ��� $��* ��� $��2 ��� $��* �.+�� -   $��0��#��[  .+��� $��../Imagenes/monitor.png��$��Uniform=�$��10q��� $��1�����#B8D600$��20, 0, 20, 0q�� -   $��2��#��[  .+��� $"��../Imagenes/benchmarking.png��$��Uniform=�$��10q��� $��3�����#B8D600$��20, 0, 20, 0q�� -   $��4��#��[  .+��� $ ��../Imagenes/termometro.png��$��Uniform=�$��10q��� $��5�����#B8D600$��20, 0, 20, 0q�� -   $��6��#��[  .+��� $%��../Imagenes/configuraciones.png��$��Uniform=�$��20q��� -    ��Name$ ContenedorUserControl��$��1��$��1��.���� $��Center=�$��Center=�$��30(�$
��Bold"�
�������BIENVENIDO A SYSGUARD