   M S B A M L   `   `   `  ����E  AScore Path, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:TheProject.ViewsTheProject.Views  5      X TFontAwesome.Sharp, Version=6.6.0.0, Culture=neutral, PublicKeyToken=d16d1e4e568ec10fP:clr-namespace:FontAwesome.Sharp;assembly=FontAwesome.SharpFontAwesome.Sharp 5          TheProject.Views.V_Login   5      W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      0localclr-namespace:TheProject.Views     5      Ifa:clr-namespace:FontAwesome.Sharp;assembly=FontAwesome.Sharp     5      .��5      ��   �� CornerRadius$  20��6   ._�5      �  � RowDefinitions 5      �� 5      $��30 �6$   �� 5      .+�5      �  � ColumnDefinitions 5      �� 5      �� 5      $��25 �6+   �� 5      $��25 �6+   �� 5       $��5 �6+   .+�5$      �� $��WELCOME��6       fontColorPrimary#���   5%   E   $��10(�5'      $��
Montserrat)�5(      $��0��5)      $��Center=�5*      $��10,0,0,0q�5+      �� 5-      -   5         ��Name$ btnMinimize��5-      $��0q�5/      $��-��50      
�������$��16(�52       � Cursor$
 Hand��53      $��1��54      ��55      �� 56       �� 
TargetType" ��6$   .�57   "   ��  �� Property � ��  buttonColor �� Value# [ 6?    �� Triggers 58   "   P� 59   &   	 P� Property	 �@J�IsMouseOver
 P� Value$

 True��6E   . �5:   *   ��  � ��  buttonPressedColor# [ 6G   5;   '   5=      ��5?      �� 5@       �� 
TargetType" ��6.   .R�5A   "   �� $��18��6)   $��18��64   $  7��5B   $   #��z��5C   $   ._�5D   &   �� $��Center=�67   $��Center=�6R   5F   #   5G      5J      �� 5K      -   5        $ btnClose��5K      $��0q�5M      $��X��5N      
�������$��12(�5P      $
 Hand��5Q      $��2��5R      ��5S      �� 5T      " ��6$   .�5U   "   ��  � �� �#EC625F6?    5V   "   P� 5W   &   	 �@J�IsMouseOver$

 True��6E   . �5X   *   ��  � �� �	#FFEF38346G   5Y   '   5[      ��5]      �� 5^      " ��6.   .R�5_   "   �� $��18��6)   $��18��64   $  7��5`   $   #��z��5a   $   ._�5b   &   �� $��Center=�67   $��Center=�6R   5d   #   5e      5h      5j      �� 5l      $	��250��6   $��2��5m       �� Orientation$ Vertical=�5n      $��0,20,0,0q�5o      .+�5s      !  FontAwesome.Sharp.IconBlock  �  �FontAwesome.Sharp.IconBlockBase`1[[FontAwesome.Sharp.IconChar, FontAwesome.Sharp, Version=6.6.0.0, Culture=neutral, PublicKeyToken=d16d1e4e568ec10f]]   Icon$
 User=�6#   $��80(�6/     accentColor1#��[ 6=   �� 5t      $��
Bienvenido��6    #���   5u      $��25(�5v      $��Medium"�5w      $��
Montserrat)�5x      $��Center=�5y      $��0,5,0,0q�5z      �� 5|      $I��CVisualiza, organiza y agrega registros de tu dia a dia con nosotros��6    #���   5}       $��12(�5~      $��Medium"�5      $��
Montserrat)�5�       �� TextAlignment$ Center=�5�      $
��Wrap=�5�      $��0,5,0,0q�5�      �� 5�      $��Nombre��6    #���   5�   )   $��10(�5�      $��Medium"�5�      $��
Montserrat)�5�      $��0,16,0,0q�5�      �� 5�      -   5         ��Name$ txtUser��5�      $��13(�5�      $��Medium"�5�      $��
Montserrat)�5�      #���   5�        �� 
CaretBrush
 �����
�������$��0,0,0,2q�5�      $��28��5�      $��Center=�5�      $��0,5,0,0q�5�      $��20,0,0,0q�5�      .��6,   ��5�      �� 5�       �� Color$ Transparent��6.   .��5�   .   5�      �� 5�      $��Contraseña��6    #���   5�   -   $��10(�5�      $��Medium"�5�      $��
Montserrat)�5�      $��0,15,0,0q�5�      G� 5�      -   5         G�Name$ txtPass��5�   "   $��12(�5�      $��Medium"�5�      $��
Montserrat)�5�      #���   5�   +    G� 
CaretBrush
 �����
�������$��0,0,0,2q�5�      $��28��5�      $��Center=�5�      $��0,5,0,0q�5�      $��20,0,0,0q�5�      ��5�      �� 5�      $ Transparent��6.   5�      �� 5�      -   5        $ 	btnEntrar��5�      $��0q�5�      $��Entrar��5�      
�������$��12(�5�      $��
Montserrat)�5�      $
 Hand��5�      $��0,25,0,0q�5�      ��5�      �� *Start+��5�      �� 5�      " ��6$   .�5�   "   ��  � ��# [ 6?    5�   "   P� 5�   &   	 �@J�IsMouseOver$

 True��6E   . �5�   *   ��  � ��  buttonHoverColor# �  6G   5�   '   5�      ��5�      �� 5�      " ��6.   .R�5�   "   �� $	��150��6)   $��40��65   $  6��5�   $   #��z��5�   $   ._�5�   &   �� $��Center=�67   $��Center=�5�   2   5�   #   5�      5�      �� 5�      $ 
Horizontal=�6!   $��Center=�5�      $��0,15,0,0q�5�      .+�5�      �� $��Deseas Registrar?��6$   
�������$��12(�5�      $��Medium"�5�      $��
Montserrat)�5�      �� 5�      
�������$��12(�5�   /   $��Medium"�5�   /   $��
Montserrat)�5�   /   $
 Hand��5�   /   $��8,0,0,0q�5�   /   �� 5�        �� Command 6*   �� *	setuser+.�6H   reset5�       5�      5�      5�      5�      5�      5�      