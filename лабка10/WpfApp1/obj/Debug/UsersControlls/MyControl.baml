   M S B A M L   `   `   `  ����B  >WpfApp1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:WpfApp1.UsersControllsWpfApp1.UsersControlls  5      &     WpfApp1.UsersControlls.MyControl   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      6local$clr-namespace:WpfApp1.UsersControlls     5        � 	Resources  5	      "   WpfApp1.UsersControlls.Chips   Price   Title   Lays��%<   &	          5
   
   $	 600��6   $
 Lays��6"   6/   5      .��5      � -   5         �Name$ grid1��5       � DataContext# [  6    � RowDefinitions 5   
   �� 5      $	��18* �6   �� 5      $	��50* �6   �� 5      $	��55* �6   �� 5      $	��57* �6   �� 5      $
��141* �6   �� 5      $
��127* �6   �� 5      $
��119* �6   �� 5      $��2* �6    � ColumnDefinitions 5   
   �� 5      $
��133* �6   �� 5      $	��20* �6   �� 5      $
��239* �6   .+�5   
   �� $��
Чипсы��6   
���P��$��0,1,0,0q�64   $��1��6E   �� 5   
   $��1��6+   $��0,1,0,0q�6;   $��1��6L   $��2��6Y   ��6   �� *Title+6Y   �� 5   
   $��Цена��6   $��2��6    
���<��6-   �� 5   
   $��1��66   $��2��6F   $��2��6S   ��6   �� *Price+ �� Mode$ TwoWay=�6S   �� 5    
   -   5        $��Проверка��5       $��3��6$   $��1��61   $��2��6V   �� 5"   
   -   5        $��0��5"      $��Center=�6%   $��80��5#      $��	4,30,3,31q�6!   $��2��64   $��4��6H   .+�5$      �� -   5         ��Name$ button3��5$      $��57��6&   $��32,10,33,10q�5%      ���	#FF55DACE.��5&      A� -   5        $��38��5&      $��33��6%   
���   �6>   5'      5(      �� 5)   
   -   5        	 ��Name$	 
textBlock3��5)      $��2��6(   
 �� Padding$
 5q�68   $��	10,8,19,7q�6D   $��9(�6W   $��4��6d   �� 5,   
   -   5        $��0��5,      $��Center=�6%   $��80��6^   $��	6,29,1,18q�6j   $��2��6}   $��5��6�   .+�5-      �� -   5        $ button1��5-      $��57��6&   $��32,10,33,10q�6P   ���	#FF55DACE.��5.      A� -	   5        $��38��5.      $��33��6%   
���   �6>   5/      50      �� 51   
   -
   5        $	 
textBlock1��51      $��2��6(   $
 5q�68   $��	14,2,15,2q�6D   $��9(�6W   $��5��6d   �� 53   
   -   5        $��0��53      $��Center=�6%   $��2��54   ;   $��	1,23,2,14q�55      $��6��6(   $��82��65   .+�56      �� -   5        $ button2��56      $��57��6&   $��35,10,36,10q�58      ���	#FF55DACE.��59      A� -   5        $��42��59      $��37��6%   
���   �5:      5;      5<      �� 5=   
   -   5        $	 
textBlock2��5=      $��2��6(   $
 5q�68   $��	16,3,13,3q�6D   $��9(�6W   $��6��6d   5A      5B      