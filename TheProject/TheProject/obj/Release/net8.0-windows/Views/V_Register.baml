   M S B A M L   `   `   `  ���� E  AScore Path, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:TheProject.ViewsTheProject.Views  5clr-namespace:TheProject.ModelsTheProject.Models  !    TheProject.Views.V_Register   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     0localclr-namespace:TheProject.Views     2modelsclr-namespace:TheProject.Models     _ [MaterialDesignThemes.Wpf, Version=5.1.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  $	��450��$	��800��.���   � ColumnDefinitions  �� $��* ��� $��* � � RowDefinitions �� $��28 ��� $��* �.+�� $��0��$��1��   accentColor1#���     �� $	��359 ��� $��* ��� $��* ��� $��5 �.+��� -    ��Name$ btnMinimize��$��0q�$��-��  fontColorPrimary#���  $��16(� � Cursor$
 Hand��$��1������  �� 
TargetType" ��.���  �� Property � ��  accentColor2 �� Value# �   �� Triggers P�  P� Property �@J�IsMouseOver	 P� Value$
	 True��. ���  � ��  buttonPressedColor# �  ���� 
 �� 
TargetType"
 ��.R��� $��18��$��18�� �� CornerRadius$ 7��#��z��._��� $��Center=�$��Center=��� -   $ btnClose��$��0q�$��X��#���  $��12(�$
 Hand��$��2������ " ��.���  � �� �#EC625F P�  �@J�IsMouseOver$
	 True��. ���  � �� �	#FFEF3834���� "
 ��.R��� $��18��$��18��$ 7��#��z��._��� $��Center=�$��Center=�� $��0��$��1��.+��� $��40,10q�$��Stretch=�$��Stretch=�.+���  �� Orientation$ 
Horizontal=�.+��� .+��� $��Nombre��#���  $��14(�$��Medium"�$��
Montserrat)��� -    ��Name$ s1��$��14(�$��Medium"�$��
Montserrat)�#���   �� 
CaretBrush
 �����
�������$��0,0,0,2q�$��25��$��Bottom=�$��0,5,30,0q�$	��240��)  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Adam Wysley������ *summoner.Phrase+.������  �� Color$ Transparent��.���� .+��� $��Frase��#���  $��14(�$��Medium"�$��
Montserrat)��� $��0,8,0,0q�$��50��.@��� $��Genero1���� $��Genero2���� $
��0,25q�.+��� $��Correo��#���  $��14(�$��Medium"�$��
Montserrat)��� -   $ s2��$��14(�$��Medium"�$��
Montserrat)�#���  
 �����
�������$��0,0,0,2q�$��25��$��Bottom=�$��0,5,0,0q����� *summoner.Phrase+.������ $ Transparent��.���� $ 
Horizontal=�$	��0,0q�.+��� .+��� $��Fecha de Nacimiento��#���  $��14(�$��Medium"�$��
Montserrat)��� -   $ s4��$��14(�$��Medium"�$��
Montserrat)�#���  
 �����
�������$��0,0,0,2q�$��25��$��Bottom=�$��0,5,30,0q�$	��200������ *summoner.Phrase+.������ $ Transparent��.���� .+��� $��Pais Actual��#���  $��14(�$��Medium"�$��
Montserrat)��� -   $ s7��$��14(�$��Medium"�$��
Montserrat)�#���  
 �����
�������$��0,0,0,2q�$��25��$��Bottom=�$��0,5,0,0q�$��90������ *summoner.Phrase+.������ $ Transparent��.���� $
��0,25q�.+��� $��Contraseña��#���  $��14(�$��Medium"�$��
Montserrat)��� -   $	 s11��$��14(�$��Medium"�$��
Montserrat)�#���  
 �����
�������$��0,0,0,2q�$��25��$��Bottom=�$��0,5,0,0q����� *summoner.Phrase+.������ $ Transparent��.���� $	��0,0q�.+��� $��Confirmar Contraseña��#���  $��14(�$��Medium"�$��
Montserrat)��� -   $	 s22��$��14(�$��Medium"�$��
Montserrat)�#���  
 �����
�������$��0,0,0,2q�$��25��$��Bottom=�$��0,5,0,0q����� *summoner.Phrase+.������ $ Transparent��.���� $��Center=�$
��0,20q�$ 
Horizontal=�.+��� $��Guardar��$
��20,0q����� *save+���� " ��.���  � ��  buttonColor# �  ��  � ��$ 14(���  � ��# �   P�  � ��$
	 True��. ���  � ��# �  ���� "
 ��.R��� $	��100��$��40��$ 6��#��z��._��� $��Center=�$��Center=��� $��Guardar todo��$
��20,0q����� *	saveAll+���� " ��.���  � ��# �  ��  � ��$ 14(���  � ��# �   P�  � ��$
	 True��. ���  � ��# �  ���� "
 ��.R��� $	��100��$��40��$ 6��#��z��._��� $��Center=�$��Center=�� $��1��$��1��#���   