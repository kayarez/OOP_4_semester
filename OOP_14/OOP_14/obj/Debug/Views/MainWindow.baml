   M S B A M L   `   `   `  ����A  =OOP_14, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:OOP_14.ViewsOOP_14.Views  5   	   1clr-namespace:OOP_14.CommandsOOP_14.Commands  5   	       OOP_14.Views.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:OOP_14.Views     5   	   +cclr-namespace:OOP_14.Commands     5   	     � Title$  
MainWindow��5
   	   $	��400��6   $	��400��6)   .��5      �  � ColumnDefinitions 5   
   �� 5      �� 5      .+�5   
   �� $ �� IsSynchronizedWithCurrentItem$
 TrueY�67   ��6   �� *TicketsList+��5      �� 5      .R�5      �� 
�������$��1q�62   $��10q�6F   ._�5      �� $��10q�6%   .+�5      �� $
��Bold"�6?   ��6(   �� *Group+6?   �� 5      ��6(   �� *	DayOfWeek+�� 5      ��6(   �� *
DateTime+�� 5       �� Orientation$ 
Horizontal=�6)   .+�5   "   �� $��Осталось:��6,   �� 5   "   $
��Bold"�6P   $
��10,0q�6b   ��6,   �� *Count+ �� Mode$ TwoWay=�6b   �� 5   "   $
��шт��6,   5      5      5      5       5"      �� 5$   
   $��1��6   ��6)   �� *TicketsList+��5%      �� 5&      .R�5'      �� 
�������$��1q�62   $��10q�6F   ._�5(      �� $��10q�6%   .+�5)      �� $��Группа:��6(   �� 5*      $��0,0,0,10q�6d   ��6(   �� *Group+ �� UpdateSourceTrigger$ PropertyChanged=�6d   �� 5,      $2��,Дата и время проведения:��6(   �� 5-      $��0,0,0,10q�6g   ��6(   �� *
DateTime+$ PropertyChanged=�6g   �� 5/      $��День недели:��6(   �� 50      $��0,0,0,10q�6h   ��6(   �� *	DayOfWeek+$ PropertyChanged=�6h   �� 52      $��Тип билета:��6(   �� 53      $��0,0,0,10q�6c   ��6(   �� *Type+$ PropertyChanged=�6c   �� 55      $��Цена билета:��6(   �� 56      $��0,0,0,10q�6c   ��6(   �� *Cost+$ PropertyChanged=�6c   �� 58      $ 
Horizontal=�6)   .+�59   "   �� $��Купить��6)   $
��10,0q�6^   ��6:   �� *GiveItemCommand+6^   �� 5:   "   $��
Сдать��6)   $
��10,0q�6\   ��69   �� *GetItemCommand+6\   5;      5<      5=      5>      5@      5A      5B      