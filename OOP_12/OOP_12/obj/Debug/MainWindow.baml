   M S B A M L   `   `   `  ����A  =OOP_12, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:OOP_12OOP_12  5   	       OOP_12.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   &localclr-namespace:OOP_12     5   	     � Title$  
MainWindow��5   	   $	��500��6   $	��800��6)   
������� � 
ResizeMode$ NoResize=�6P    � WindowStartupLocation$ CenterScreen=�6f   .��5	      �  � ColumnDefinitions 5
   
   �� 5      $	��150 �6   �� 5      $	��450 �6   �� 5       � RowDefinitions 5   
   �� 5      $��70 �6   �� 5      $��70 �6   �� 5      $��70 �6   �� 5      $��70 �6   �� 5      �� 5      �� 5      �� 5      .+�5   
   �� -   5         ��Name$ SearchGroupTextBox��5      $��0��6.   $��0��6;   $��2��6K   $��20 20 20 20q�6_   $��20(�6t   6�   �� 5   
   -   5        $0��*Поиск по специальности��5   1   $��0��6R   $��3��6_   $��20 10 20 10q�6o   6�   �� 5   
   -   5        $ SearchSurnameTextBox��5      $��1��60   $��0��6=   $��2��6M   $��20 20 20 20q�6a   $��20(�6v   6�   �� 5   
   -   5        $$��Поиск по фамилии��5   3   $��1��6N   $��3��6[   $��20 10 20 10q�6k   6�   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ StudentDataGrid��5   q   $��2��6   $��2��6    $��0��61   $��2��6A      AutoGenerateColumns .     Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn	   Header$	 Имя��6%   
   Width5  /System.Windows.Controls.DataGridLengthConverter$
 * 6_      
IsReadOnly .  1  +System.Windows.Controls.DataGridBoundColumn   Binding 62   ��  �� Path$
 Name� �� Mode$ TwoWay=�6~     5       $	 Фамилия��6%   $
 * 6f    .   66   �� $ Surname�$ TwoWay=�6�     5!      $ 	 Специальность��6%   $
 * 6t    .   6<   �� $ Group.Specialty�$ TwoWay=�6�     5"      $	 Курс��6%   $
 * 6i    .   63   �� $ Course.Number�$ TwoWay=�6�   5$      �� 5%   
   -   5        $��Сохранить��5%   *   $��2��6>   $��3��6K   $��20 10 20 10q�6[   6s   �� 5&   
   -   5        $��Удалить��5&   ,   $��3��6>   $��3��6K   $��20 10 20 10q�6[   6s   �� 5'   
   $��4��6   $��Имя��6   $��20(�6,   $��Center=�6:   $��Center=�6W   �� 5(   
   -   5        $��txtName��5(   /   $��4��6   $��1��6   $��40 10 40 10q�6>   $��20(�6S   �� 5)   
   $��5��6   $��Фамилия��6   $��20(�60   $��Center=�6>   $��Center=�6[   �� 5*   
   -	   5        $��
txtSurname��5*   /   $��5��6   $��1��6   $��
40 0 40 10q�6A   $��20(�6U   �� 5+   
   $��6��6   $ ��Специальность��6   $��20(�66   $��Center=�6D   $��Center=�6a   �� 5,   
   -
   5        $��txtGroup��5,   /   $��6��6   $��1��6   $��
40 0 40 10q�6?   $��20(�6S   �� 5-   
   $��7��6   $��Курс��6   $��20(�6-   $��Center=�6;   $��Center=�6X   �� 5.   
   -   5        $��	txtCourse��5.   /   $��7��6   $��1��6   $��
40 0 40 10q�6@   $��20(�6T   �� 5/   
   -   5        $��Добавить��5/   )   $��5��6<   $��3��6I   $��20 10 20 10q�6Y   6q   50      51      