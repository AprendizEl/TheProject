   M S B A M L   `   `   `  ���� E  AScore Path, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:TheProject.ViewsTheProject.Views  X TFontAwesome.Sharp, Version=6.6.0.0, Culture=neutral, PublicKeyToken=d16d1e4e568ec10fP:clr-namespace:FontAwesome.Sharp;assembly=FontAwesome.SharpFontAwesome.Sharp     TheProject.Views.V_Login   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     0localclr-namespace:TheProject.Views     Ifa:clr-namespace:FontAwesome.Sharp;assembly=FontAwesome.Sharp     .����   �� CornerRadius$  20��._��  � RowDefinitions �� $��30 ��� .+��  � ColumnDefinitions �� �� $��25 ��� $��25 ��� $��5 �.+��� $��WELCOME��   fontColorPrimary#���   $��10(�$��
Montserrat)�$��0��$��Center=�$��10,0,0,0q��� -    ��Name$ btnMinimize��$��0q�$��-��
�������$��16(� � Cursor$
 Hand��$��1������  �� 
TargetType" ��.���  �� Property � ��  buttonColor �� Value# [  �� Triggers P� 	 P� Property	 �@J�IsMouseOver
 P� Value$

 True��. ���  � ��  buttonPressedColor# [ ����  �� 
TargetType" ��.R��� $��18��$��18��$  7��#��z��._��� $��Center=�$��Center=��� -   $ btnClose��$��0q�$��X��
�������$��12(�$
 Hand��$��2������ " ��.���  � �� �#EC625F P� 	 �@J�IsMouseOver$

 True��. ���  � �� �	#FFEF3834���� " ��.R��� $��18��$��18��$  7��#��z��._��� $��Center=�$��Center=��� $	��250��$��2�� �� Orientation$ Vertical=�$��0,20,0,0q�.+�!  FontAwesome.Sharp.IconBlock  �  �FontAwesome.Sharp.IconBlockBase`1[[FontAwesome.Sharp.IconChar, FontAwesome.Sharp, Version=6.6.0.0, Culture=neutral, PublicKeyToken=d16d1e4e568ec10f]]   Icon$
 User=�$��80(�  accentColor1#��[ �� $��
Bienvenido��#���   $��25(�$��Medium"�$��
Montserrat)�$��Center=�$��0,5,0,0q��� $W��QEncontraras todas las estadisticas y datos importantes de tus jugadores favoritos��#���   $��12(�$��Medium"�$��
Montserrat)� �� TextAlignment$ Center=�$
��Wrap=�$��0,5,0,0q��� $��Nombre��#���   $��10(�$��Medium"�$��
Montserrat)�$��0,16,0,0q��� -    ��Name$ txtUser��$��13(�$��Medium"�$��
Montserrat)�#���    �� 
CaretBrush
 �����
�������$��0,0,0,2q�$��28��$��Center=�$��0,5,0,0q�$��20,0,0,0q�.������  �� Color$ Transparent��.���� $��Contraseña��#���   $��10(�$��Medium"�$��
Montserrat)�$��0,15,0,0q�G� -    G�Name$ txtPass��$��12(�$��Medium"�$��
Montserrat)�#���    G� 
CaretBrush
 �����
�������$��0,0,0,2q�$��28��$��Center=�$��0,5,0,0q�$��20,0,0,0q����� $ Transparent���� -   $ 	btnEntrar��$��0q�$��Entrar��
�������$��12(�$��
Montserrat)�$
 Hand��$��0,25,0,0q����� *Start+���� " ��.���  � ��# [  P� 	 �@J�IsMouseOver$

 True��. ���  � ��  buttonHoverColor# �  ���� " ��.R��� $	��150��$��40��$  6��#��z��._��� $��Center=�$��Center=��� $ 
Horizontal=�$��Center=�$��0,15,0,0q�.+��� $��Deseas Registrar?��
�������$��12(�$��Medium"�$��
Montserrat)��� 
�������$��12(�$��Medium"�$��
Montserrat)�$
 Hand��$��8,0,0,0q���  �� Command �� *	setuser+.�reset