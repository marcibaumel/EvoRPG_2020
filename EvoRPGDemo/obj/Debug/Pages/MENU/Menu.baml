   M S B A M L   `   `   `  ����E  AEvoRPGDemo, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:EvoRPG.Pages.MENUEvoRPG.Pages.MENU  5          EvoRPG.Pages.MENU.Menu   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      1localclr-namespace:EvoRPG.Pages.MENU     5        N� Title$
  Menu��5	       � 	Resources 5         BetterButton �� 
TargetType �� Property �� Value u� Left �� 
TargetType �� Triggers P� Property	 P� Value��%�  &	        �� 5   
   " ��6%   .�5      ��  �@�OverridesDefaultStyle . 66   �� 5       � ��
 � ���6+   �� 5       � ��$ Comic Sans Ms)�6+   �� 5       � ��$ 50(�6)   �� 5       � ��$
 Bold"�6+   �� 5       � ��$
 Left=�64   �� 5       � �� 5      u� 5      $ 50Q�6    5      �� 5       � �� 5      �� 5      " ��6&   .R�5      �� $��border��6!   $��0q�5      #��z��5       ._�5!      �� $
��Left=�6/   $��Center=�6J   5"       5#      P� 5$       �@J�IsMouseOver	 . . �5%   "   ��  � ��
 �<��6?   �� 5&   "    � �� 5'   &   u� 5(   *   $ 70Q�64   5*   #   5,      5.      50      51      52      .��54      � ��55   
   �� 56      
 �� ImageSource$@
 :free-fantasy-world-wallpaper-31953-32689-hd-wallpapers.jpg��6    � ColumnDefinitions 58   
   �� 59      $
��503* �6   �� 5:      $
��289* �6    � RowDefinitions 5=   
   �� 5>      $	��72* �6   �� 5?      $
��137* �6   �� 5@      $
��132* �6   �� 5A      $
��110* �6   �� 5B      $
��118* �6   .+�5E   
   �� -   5        $��_ExitButton��5E   7   #��[  6    � Cursor$
 Hand��6J   $��0��6X   $	��492��6h   $	��110��6t   $	��Top=�6�   $��
10,107,0,0q�6�   $��80(�6�   $��Segoe Script)�6�   $��2��6�   $��2��6�   .��6  	Exit Game��5G      �� 5H       �� Color$ White��6"    �� Opacity$ 0Q�60   5J      �� 5K   
   -   5        $��_LoadButton��5K   7   #��[  6   $
 Hand��6J   $��0��6X   $	��492��6h   $	��132��6t   $��Bottom=�6�   $��
10,0,0,107q�6�   $��80(�6�   $��Segoe Script)�6�   $��2��6�   $��2��6�   $y�Hidden=�6  .��6$  	Load Game��5M      �� 5N      $ White��6"   $ 0Q�60   5P      �� 5Q   
   -   5        $��_StartButton��5Q   7   #��[  6   $
 Hand��6K   $��0��6Y   $	��483��6i   $	��125��6u   $��Bottom=�6�   $��	10,0,0,57q�6�   $��80(�6�   $��Segoe Script)�6�   $��1��6�   $��2��6   .��6  
New Game��5S      �� 5T      $ White��6"   $ 0Q�60   5V      5Z      5[      