   M S B A M L   `   `   `  ����E  APizza menu, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:Pizza_menu
Pizza_menu  5   	       Pizza_menu.Checkout   5   	   W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:Pizza_menu     5   	     � Title$  checkout��5   	   $	��450��6   $	��800��6'   .��5	      � .+�5
   
   &   System.Windows.Controls.DataGrid  -   5          Name$ dtg_BuyingList_Buy��5
      $��265,0,34,149q�6Z      AutoGenerateColumns$ false��6p      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$
 Name��6!   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6/   �� *Name+  5      $ Price��6!    60   �� *Price+4  .System.Windows.Controls.DataGridTemplateColumn  5      $ Description��6%      CellTemplate 5      �� 5      .R�5      �� $
��Wrap=�6A   ��6$   �� *Description+6A   5      5      5      �� 5   
   $1��+Last chance to go back if you want and edit��6   $
��Left=�6F   $��	10,10,0,0q�6a   $	��Top=�6t   �� 5   
   -   5         ��Name$ 
btn_GoBack��5      $��GO Back to order page��6%   $
��Left=�6E   $��135,265,0,0q�6`   $	��Top=�6u   6�   �� 5   
   -   5        $ btn_CheckoutBuy��5      $	��BUY��6*   $
��Left=�68   $��270,331,0,0q�6S   $	��Top=�6h   6�   �� 5   
   -   5         ��Name$ tb_PriceCheckout��5      $
��Left=�6,   $��306,304,0,0q�6G   	 �� TextWrapping$
	 Wrap=�6\   $	��Top=�6p   $	��120��6�   �� 5   
   $��Price��6   $
��Left=�6    $��265,300,0,0q�6;   $	��Top=�6P   5      5      