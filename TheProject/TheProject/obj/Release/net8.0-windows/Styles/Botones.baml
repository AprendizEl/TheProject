   M S B A M L   `   `   `  ���� W  SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089X TFontAwesome.Sharp, Version=6.6.0.0, Culture=neutral, PublicKeyToken=d16d1e4e568ec10f  �� 
TargetType �� Property   darkBackground �� Value  fontColorPrimary  
darkBorder �� 
TargetType ��Name �� Triggers P� Property P� Value �� 
TargetName  accentColor1  accentColor2  BTnormalize  buttonColor	 �� CornerRadius
 �� Triggers  buttonHoverColor  
menuButton 	 panelHoverColor �� Path �� RelativeSource 
 panelActiveColor  menuButtonIcon!   FontAwesome.Sharp.IconBlock �� AncestorType  menuButtonText  Control  fontColorTertiary  ControlIcon  
iconButton 	 iconI  SwitchToggleButtonStyle A�Name T� X'  !System.Windows.VisualStateManager   VisualStateGroups%  System.Windows.VisualStateGroup   States   System.Windows.VisualState   
Storyboard �� 
TargetName �� TargetProperty	 �� To g� Duration	 W� To  SwitchCheckBoxStyle�� H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation       :x,http://schemas.microsoft.com/winfx/2006/xaml      IfaWPF=http://schemas.awesome.incremented/wpf/xaml/fontawesome.sharp  %�  '��       &	 �    &	 �    &	 �    &	 �    &	 S    &	 �    &	     &	 i	    &	 �	    &	 �    �� "  ��.���  � ��# �   ��  � ��# �  ��  � ��$ 5q���  � ��$ 2q���  � ��# �  ��  � ��$ 1q���  � �� �� " ��.R��� $ Border��#��z��#��z��#��z��._���  P�  �@��
IsSelected$
 True��. ��� $ Border��# �   � ���� $ Border��# �   � ���� # �   � ��P�  �@J�IsMouseOver$
 True��. ��� $ Border��# �   � ���� $ Border��# �   � ���� # �   � ���� "  ��.���  � ��# �  ��  � �� �� " ��.R��� $	 5��#��z��._��� $��Center=�$��Center=�
 P�  �@J�IsMouseOver$
 True��. ���  � ��# �  ��  �@�Cursor$
 Hand���� "  	�.���  � ��$ 50����  � ��$ -5,0,0,5q���  � ��
 ���� ��  � ��# �  ��  � ��
 ���� ��  � �� �� " 	�.R��� #��z��$��4,0,0,0q�#��z��._��� $
��Left=�$��Center=�
 P�  �@J�IsMouseOver$
 True��. ���  � ��$ 0,0,0,5q���  � ��# � 	 ��  � ��# �  ��  � �� �� $	 Tag� �� *Self+��  �@�Cursor$
 Hand��P�  �@d�	IsChecked$
 TrueY�. ���  � ��$ 0,0,0,5q���  � ��# � 
 ��  � �� �� $	 Tag� �� *Self+��  � �� �� $	 Tag� �� *Self+�� "    .���  � �� �� $	 Tag� ��  RadioButton��  � ��$ 22����  � ��$ 22����  � ��$ 	45,0,35,0q���  � ��$ 17(��� "  ��.���  � �� �� $	 Tag� ��  RadioButton��  � ��$ 
Montserrat)���  � ��$ Medium"���  � ��$
 13.5(���  � ��$ Center=��� "  ��.���  � ��$ 35����  � ��$ Center=���  � ��
 ���� ��  � ��# �  ��  � �� �� " ��.R��� #��z��$	 4��._��� $��Center=�$��Center=�
 P�  �@J�IsMouseOver$
 True��. ���  � ��# � 
 ��  � �� �� $	 Tag� �� *Self+��  �@�Cursor$
 Hand���� "    .���  � �� �� $ 
Foreground� �� 
 Button��  � ��$ Center=���  � ��$ Stretch=��� "  ��.���  �@�Cursor$
 Hand����  � ��$ 35����  � ��$ 14(���  � ��
 ���� ��  � ��# �  ��  � �� �� " ��.R��� #��z��._��� $��Center=�$��Center=�
 P�  �@J�IsMouseOver$
 True��. ���  � �� �� $	 Tag� �� *Self+��  �@�Cursor$
 Hand���� "    .���  � �� �� $ 
Foreground� �� 
 Button��  � ��$ 14����  � ��$ 14���� "  d�.���  � �� �� " d�.R�� $��30��$��15��
������ .+��� $ switchBackground��$	 7�����#cccA� $ switchCircle��
�������$��10��$��10��$
��Left=�$��2,2,0,2q�z�T� $ 0Q�   CheckStates��.   	Unchecked��. �� .���� $ switchBackground��$1 +(Border.Background).(SolidColorBrush.Color)� #393E46$ 0:0:0.2D�W� $ switchCircle��$8 2(UIElement.RenderTransform).(TranslateTransform.X)� 0$ 0:0:0.2D�  Checked��. �� .���� $ switchBackground��$1 +(Border.Background).(SolidColorBrush.Color)� #929AAB$ 0:0:0.2D�W� $ switchCircle��$8 2(UIElement.RenderTransform).(TranslateTransform.X)� 15$ 0:0:0.2D��� "  ��.���  � �� �� " ��.R�� $��30��$��15��
������ .+��� $ switchBackground��$	 7�����#cccA� $ switchCircle��
�������$��10��$��10��$
��Left=�$��2,2,0,2q�z�T� $ 0Q�   CheckStates��.   	Unchecked��. �� .���� $ switchBackground��$1 +(Border.Background).(SolidColorBrush.Color)� #393E46$ 0:0:0.2D�W� $ switchCircle��$8 2(UIElement.RenderTransform).(TranslateTransform.X)� 0$ 0:0:0.2D�  Checked��. �� .���� $ switchBackground��$1 +(Border.Background).(SolidColorBrush.Color)� #929AAB$ 0:0:0.2D�W� $ switchCircle��$8 2(UIElement.RenderTransform).(TranslateTransform.X)� 15$ 0:0:0.2D�