   M S B A M L   `   `   `  ����?  ;Cvet, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:CvetCvet  5   	       Cvet.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   $localclr-namespace:Cvet     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   $	��450��65   $	��800��6E   $	��450��6T   $	��800��6d    � 
ResizeMode$ CanResizeWithGrip=�6s    � WindowStartupLocation$ CenterScreen=�6�   .��5	      �  � RowDefinitions 5
   
   �� 5      $	��77* �6   �� 5      $
��342* �6    � ColumnDefinitions 5   
   �� 5      $
��131* �6   �� 5      $
��661* �6   .+�5   
   �� $��0��6   
�������6"   �� 5   
   $��image/logo.png��6   �� 5      $��1��6   
�������6)   �� 5   
   -   5        $��1��5      $	��100��6!   $��20��6-   $��Right=�69   $��0,0,20,0q�6U   $"��Выйти из Учетки��6g   6�   �� 5   
   $��Аптека��6   $��1��6!   $��30(�61   $��Center=�6?   $��Center=�6\   $��Comic Sans MS)�6w   �� 5   
   $��1��6   
�������.+�5      �� -   5         ��Name$ 	AgentData��5      $	��100��6(   $��20��64   
����� �$��Агент Дата��6V   $��0,20,0,0q�6k   6}   �� 5      -   5        $ 	AgentList��5      $	��100��6(   $��20��64   
����� �$��Агент Лист��6V   $��0,20,0,0q�6k   6}   �� 5      -   5        $ UserList��5      $	��100��6'   $��20��63   
����� �$��Пользователи��6U   $��0,20,0,0q�6l   6~   �� 5      -   5        $	��100��5      $��20��6"   
����� �$��
Выход��6D   $��0,20,0,0q�6T   6f   5       � 5   
   -   5          �Name$ 	MineFrame��5        � NavigationUIVisibility$ Hidden=�6#   $��1��6C   $��1��6S   5      5       