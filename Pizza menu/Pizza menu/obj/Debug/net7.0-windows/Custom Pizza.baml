   M S B A M L   `   `   `  ����E  APizza menu, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:Pizza_menu
Pizza_menu  5   	       Pizza_menu.Custom_Pizza   5   	   W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:Pizza_menu     5   	     � Title$  Custom_Pizza��5   	   $	��450��6   $	��800��6+   .��5	      � -   5         �Name$ 	dtg_Pizza��5	      .+�5
   
   �� $ ��Current Pizza and toppings��6   $
��Left=�65   $��	52,55,0,0q�6P   $	��Top=�6c   $	��154��6{   �� 5   
   -   5         ��Name$ btn_add��5      $��Add to Order��6"   $
��Left=�69   $��434,261,0,0q�6T   $	��Top=�6i   $��37��6�   $	��113��6�   6�   �� 5   
   -   5        $ btn_Remove_Topping��5      $��Remove From Order��6-   $
��Left=�6I   $��321,261,0,0q�6d   $	��Top=�6y   $��37��6�   $	��113��6�   6�   �� 5   
   $��Toppings��6   $
��Left=�6#   $��
638,55,0,0q�6>   $	��Top=�6R   $��66��6j   �� 5   
   -   5         ��Name$ tb_price_custom��5      $
��Left=�6+   $��321,379,0,0q�6F    �� TextWrapping$
 Wrap=�6[   $	��Top=�6p   $	��120��6�   �� 5   
   $��Price��6   $
��Left=�6    $��321,348,0,0q�6;   $	��Top=�6P   �� 5   
   -   5        $ btn_Save��5      $��Save canges��6#   $
��Left=�69   $��321,303,0,0q�6T   $	��Top=�6i   $��36��6�   $	��113��6�   6�   �� 5   
   -   5        $ 
btn_GoBack��5      $��Cancel��6%   $
��Left=�66   $��434,303,0,0q�6Q   $	��Top=�6f   $	��113��6~    J� RenderTransformOrigin$ 0.551,-1.24&�6�   $��36��6�   6�   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ dtg_Toppings��5      $��552,108,0,37q�6T      AutoGenerateColumns$
 true��6j     5   
   -   5        $ dtg_PizzaWToppings��5      $��
10,113,0,0q�6/   $	��Top=�6C   $
��Left=�6[   $	��296��6v   $ False��6�      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn	   Header$
	 Name��6%   1  +System.Windows.Controls.DataGridBoundColumn
   Binding
 63   �� *Topping.Name+  5      $	 Price Per Topping��6%   
 6@   �� *Topping.Price+ �� StringFormat$ C2��  5      $	 Quantity��6%   
 67   �� *
Quantity+  5      $	 Total Price��6%   
 6:   �� *
TotalPrice+$ C2��5      �� 5   
   -	   5        $ tb_Selected_pizza��5      $
��Left=�6-   $��
104,86,0,0q�6H   $
 Wrap=�6\   $�� ��6p   $	��Top=�6x   $	��120��6�   �� 5   
   $��Selected Pizza��6   $
��Left=�6)   $��	10,82,0,0q�6D   $	��Top=�6W   $��89��6o   5      5      