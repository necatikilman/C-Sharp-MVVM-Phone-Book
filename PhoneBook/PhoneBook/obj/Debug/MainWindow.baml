   M S B A M L   `   `   `  ����D  @PhoneBook, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:PhoneBook	PhoneBook  5   	       PhoneBook.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:PhoneBook     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)    � DataContext 5
        PhoneBook.MainViewModel  5   
    � 	Resources 5       �� 
TargetType �� Property �� Value��%�   '��       '�� j     �� 5   
   " ��6   .�5      ��  � ��$ 2q�6'   �� 5       � ��$ 5q�6(   5      �� 5   
   " ��6   .�5      ��  � ��$ 2q�6'   �� 5       � ��$ 5q�6(   5      5      .��5      �  � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6   .+�5   
   �� ��6   �� *
Contacts+ �� SelectedItem 63   �� *SelectedContact+��5      �� 5       .R�5!      �  � RowDefinitions 5"      �� 5#      $
��auto �6,   �� 5$      $
��auto �6,    5&      �� 5'      $��* �6/   �� 5(      $��* �6/   .+�5*      �� $��0��6>   $��0��6K   ��6    �� *	Firstname+6K   �� 5+      $��0��6=   $��1��6J   ��6    �� *
Lastname+6J   �� 5,      $��1��6@   $��0��6M   ��6    �� *PhoneNumber+6M   �� 5-      $��1��6:   $��1��6G   ��6    �� *Email+6G   5.      5/      51      � 53   
   $��1��6    54      �� 55      $
��auto �6#   �� 56      $��* �6#    59      �� 5:      $
��auto �6    �� 5;      $
��auto �6    �� 5<      $
��auto �6    �� 5=      $
��auto �6    �� 5>      $
��auto �6    .+�5A      �� $��Lastname��6   �� 5B      $��	Firstname��6   $��1��6)   �� 5C      $��Phone Number��6   $��2��6,   �� 5D      $��Email��6   $��3��6$   �� 5E      $
��Save��6]   $��4��6l   $��1��6y   ��6   �� *SaveCommand+{�65   �� *SaveButtonEnabled+6y   �� 5F      $��Delete��6a   $��4��6r   $��0��6   ��6   �� *DeleteCommand+{�67   �� *DeleteButtonEnabled+6   �� 5H      $��0��60   $��1��6=   ��6   �� *
Lastname+6=   �� 5I      $��1��61   $��1��6>   ��6   �� *	Firstname+6>   �� 5J      $��2��6-   $��1��6:   ��6   �� *Email+6:   �� 5K      $��3��63   $��1��6@   ��6   �� *PhoneNumber+6@   5L      5N      5O      