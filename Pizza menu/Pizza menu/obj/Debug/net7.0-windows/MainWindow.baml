   M S B A M L   `   `   `  ����E  APizza menu, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:Pizza_menu
Pizza_menu  5   	       Pizza_menu.MainWindow   5   	   W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:Pizza_menu     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5	      �  � ColumnDefinitions 5
   
   �� 5      $
��387* �6   �� 5      $
��413* �6   .+�5   
   �� -   5         ��Name$ btn_ADD_to_order��5      $��ADD TO ORDER��6+   $��Right=�6B   $��0,297,253,0q�6^   $	��Top=�6s   $��25��6�   $	��137��6�   $��1��6�   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ dtg_Menu��5      $��	0,65,13,0q�6%   $	��359��68   $	��Top=�6E      AutoGenerateColumns$ False��6]   $��Right=�6y   $	��364��6�      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$
 Name��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 63   �� *Name+  5      $ Price��6%    64   �� *Price+4  .System.Windows.Controls.DataGridTemplateColumn  5      $ Description��6)      CellTemplate 5      �� 5      .R�5      �� $
��Wrap=�6E   ��6(   �� *Description+6E   5      5      5        5   
   -   5        $ dtg_BuyingList_Buy��5      $��
0,65,14,67q�6Z   $��Right=�6n   $	��231��6�   $ False��6�   $��1��6�    5        5      $
 Name��6%    63   �� *Name+  5      $ Price��6%    64   �� *Price+  5       $ Description��6)    5!      �� 5"      .R�5#      �� $
��Wrap=�6E   ��6(   �� *Description+6E   5$      5&      5(      �� 5)   
   -   5        	 ��Name$	 tb_Price��5)      $��Right=�6$   $��
0,373,17,0q�6@   
 �� TextWrapping$

 Wrap=�6T   $	��Top=�6h   $	��231��6�   $��20��6�   $��1��6�   �� 5*   
   $��Price��6   $��Right=�6    $��0,370,253,0q�6<   $	��Top=�6Q   $��1��6i   $��26��6y   $��36��6�   �� 5+   
   -   5        $ btn_Remove_From_Order��5+      $��REMOVE FROM ORDER��60   $��Right=�6L   $��0,327,253,0q�6h   $	��Top=�6}   $��25��6�   $	��137��6�   $��1��6�   �� 5,   
   -   5        $ btn_Menu_Buy��5,      $	��BUY��6'   $��Right=�65   $��0,396,258,0q�6Q   $	��Top=�6f   $��1��6�   $��20��6�   $��26��6�   �� 5-   
   $
��Menu��6   $��Right=�6   $��
0,10,247,0q�6;   $	��Top=�6O   $��26��6g   $��41��6s   �� 5.   
   $��Checkout list��6   $��Right=�6(   $��	0,10,94,0q�6D   $	��Top=�6W   $��1��6o   $��26��6   $��78��6�   �� 5/   
   -   5         ��Name$ cmb_Menu_Selection��5/      $��Right=�6/   $��
0,38,208,0q�6K   $	��Top=�6_   $	��120��6w    �� DisplayMemberPath$
 Text��6�   $��22��6�   .@�50      �� $��Select your Menu��6   �� 51      $��Drinks��6   
 � Tag$ Drinks��6,   �� 52      $��Extra��6   $ Extra��6+   �� 53      $��Pizza��6   $ Pizza��6+   54      �� 55   
   -   5        $ 
btn_Custom��55      $��Customise Pizza��6%   $��Right=�6?   $��0,266,253,0q�6[   $	��Top=�6p   $��26��6�   $	��137��6�   $��1��6�   �� 56   
   -	   5        $	 tb_Quantity��56      $��1��6'   $
��Left=�67   $��	97,65,0,0q�6R   $

 Wrap=�6e   $�� ��6y   $	��Top=�6�   $��63��6�   $��22��6�   �� 57   
   $��1��6   $��Quantity��6    $
��Left=�63   $��	41,63,0,0q�6N   $	��Top=�6a   58      59      