   M S B A M L   `   `   `  ���� E  AScore Path, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:TheProject
TheProject  =#clr-namespace:TheProject.ViewModelsTheProject.ViewModels  5clr-namespace:TheProject.ModelsTheProject.Models  X TFontAwesome.Sharp, Version=6.6.0.0, Culture=neutral, PublicKeyToken=d16d1e4e568ec10fP:clr-namespace:FontAwesome.Sharp;assembly=FontAwesome.SharpFontAwesome.Sharp     TheProject.MainWindow   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     *localclr-namespace:TheProject     4view#clr-namespace:TheProject.ViewModels     2modelsclr-namespace:TheProject.Models     LfaWPF:clr-namespace:FontAwesome.Sharp;assembly=FontAwesome.Sharp       � 
ResizeMode$  NoResize=� � AllowsTransparency$
 True��
������  � WindowStyle$
 None=� � WindowStartupLocation$ CenterScreen=� � Title$ Window2��$	��700��$
��1300��.���� -   $��	thescreen�� �� CornerRadius$ 0��._��� $��2q�$ 0������  �� 
StartPoint$	 0,0&� �� EndPoint$	 1,1&�.���    winBorderColor1 � Color# �   	 � Offset$	 0Q��   winBorderColor2# �  $
	 0.75Q����� $	 0,1&�$	 1,0&�.���   primaryBackColor1# �  $
	 0.55Q�._�� -   $��Grid_1��
 � ColumnDefinitions
 �� $	��250 ��� $��* �.+�� -   $��G_Gear��$��2�� � RowDefinitions �� $	��100 ��� .+��� $��0��.+���  �� Orientation$ 
Horizontal=�$��Center=�.+�A� �� �� $ 
Horizontal=�$��Center=�.+�!  FontAwesome.Sharp.IconBlock  �  �FontAwesome.Sharp.IconBlockBase`1[[FontAwesome.Sharp.IconChar, FontAwesome.Sharp, Version=6.6.0.0, Culture=neutral, PublicKeyToken=d16d1e4e568ec10f]]   Icon$
 Gear=� 	 iconI#���    accentColor1#���  $��20��$��20��$
��10,2q��� $��Configuracion��  fontColorSecondary#���  $��
Montserrat)�$��12(�$��Center=��� $��1��.+��� $ 
Horizontal=�$��Center=�.+�A� �� �� $ 
Horizontal=�$��Center=�.+��� $��10q��� $��Modo Oscuro/Modo Claro��  fontColorPrimary#���  $��
Montserrat)�$��12(�$��Center=��� $ 0��$��1������ $	 0,0&�$ 1,0.7&�.���   secondaryBackColor2# �  $	 0Q��� $ 0��$��0������ $	 1,1&�$	 0,0&�.��� # �  $
	 0.55Q�._��� .+��� $ 
Horizontal=�$��35��$��
15,25,0,40q�.+�  $	 Bug=�$��28(�$��30��#���  �� $��	ScorePath��#���  $��20(�$��
Montserrat)�$��Medium"�$��Center=�$��10,0,0,0q�	�   
menuButton#���  
 � Tag# �   d� 	IsChecked$ FalseY�!   TheProject.Models.ePageView   	DashBoard#��Z ���� *changepages+.���� $ 
Horizontal=�.+�  $
 Home=� 	 menuButtonIcon#��� 	 �� $��Inicio�� 
 menuButtonText#��� 
 	� #���  # �     Register#��Z ���� *changepages+.���� $ 
Horizontal=�.+�  $ Wpforms=�#��� 	 �� $��Registro��#��� 
 	� #���  # �     Stats#��Z ���� *changepages+.���� $ 
Horizontal=�.+�  $ BarChart=�#��� 	 �� $��Estadisticas��#��� 
 	� #���  # �     
ViewChamps#��Z ���� *changepages+.���� $ 
Horizontal=�.+�  $ Table=�#��� 	 �� $��Tabla��#��� 
 	� #���  # �     Graphic#��Z ���� *changepages+.���� $ 
Horizontal=�.+�  $ 	AreaChart=�#��� 	 �� $��Grafica��#��� 
 	� #���  # �     GenerateDocument#��Z ���� *changepages+.���� $ 
Horizontal=�.+�  $ FileWaveform=�#��� 	 �� $��Reports��#��� 
 �� $��READY IK��$��30,0,30,-240q�$��Regular"�$��
Montserrat)�#���  $��Bottom=��� $ 0��$��1������ $	 1,1&�$	 0,0&�.���   primaryBackColor2# �  $	 1Q�._��  �� $��25 ��� $��45 ��� $��* �.+��� -    ��Name$ pnlControlBar��$��0��$ 
Horizontal=�$��RightToLeft=�
������ $��0,0,10,0q�.+��� -    ��Name$ btnClose��  Control#���    accentColor7# �  .��  $ Close=�  ControlIcon#���  �� -   $ btnMinimize��$��Right=�#���    accentColor3# �  .��  $ WindowMinimize=�#���  � $��1��
 �� �� .+��� $��0��$ 
Horizontal=�$��Center=�.+�  -   $��IconPage��$��20��$��20��#���  $��	40,0,10,0q�$��18(� �� *
model.Icon+�� -   $��NamePage��#���  $��16(�$��
Montserrat)�$��Medium"�$��Center=����� *model.PageView+�� $��1��$ 
Horizontal=�$��RightToLeft=�$��Center=�$��0,0,10,0q�.+���   
iconButton#���    accentColor5# �     Config#��Z ���� *changepages+.��  $
 Gear=�#���  A� $��35��$��35��#���  $��2��$��	10,0,10,0q��� $��Bienvenido invocador��#���  $��
Montserrat)�$��12(�$��Center=��� -	   $��BT_Info��#���  # �  .��  $
 Info=�#���  �� #���    accentColor4# �  .��  $ Envelope=�#���  � -
    �Name$ item7��$��2��$��25q�$��Stretch=�$��Stretch=��� -   $��B_Config��$��2,2,0,0q�$��1��$��Right=�$	��667��$��Bottom=�$	��280��$ 0,0,0,0��$y�	Collapsed=�����  �� Color# �  ���� # �  ._��  �� $��37 ��� $��* �.+�� $��0��.+�	� #���  # �  #��Z 
������ 
������ $��
-110,0,0,0q�$��Center=�$��Center=����� *changepages+.���� $ 
Horizontal=�.+�  $
 Gear=�#��� 	 �� $��Configuracion��#��� 
 �� $��Bottom=�� $��1��.+��� $��20,50q�.+��� $��Pantalla Default��$��18(�$
��0,10q�#���  $��Medium"��� -     SwitchCheckBoxStyle#���  $
��Left=��� $��10q�.+��� $��Pantalla Default��$��12(�$
��0,10q�#���  $��Medium"�${�False��	� -   $��	DarkTheme��  SwitchToggleButtonStyle#���  $
��Left=��� $��Pantalla Default��$��12(�$
��0,10q�#���  $��Medium"�	� $��	DarkTheme��#���  $
��Left=�