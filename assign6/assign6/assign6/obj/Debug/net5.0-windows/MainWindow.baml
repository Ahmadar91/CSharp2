   M S B A M L   `   `   `  ����?  ;View, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:assign6assign6  5   	       assign6.MainWindow   5   	   \ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:assign6     5   	     � Title$  
MainWindow��5   	   $	��857��6   $
��1043��6)   $	��870��5	   	   $
��1050��6   $	��870��5
   	   $
��1050��6   .��5      � $��0,0,0,0q�6    � ColumnDefinitions 5   
   �� 5      $��20 �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $��* �6   �� 5      $��20 �6     � RowDefinitions 5   
   �� 5      $��20 �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $��* �6   �� 5      $	�� 20 �6   .+�5   
   �� -   5         ��Name$ InvoiceNumberLabel��5      $��1��60   $��5��6@   $��15(�6M   $��Invoice Number��6[   $��642,69,238,701q�6q   $��3��6�   �� 5    
   -   5         ��Name$ listView��5       $��3��6%   $��1��62   $��3��6B   $��4q�5!      
���   �$��
35,231,0,0q�6;   $	��328��5"      $	��Top=�6    $
��Left=�68   $	��937��6S   $��3��6_    �� View 5#      �� 5$       �� AllowsColumnReorder$
 true��6    �� ColumnHeaderToolTip$ Flights information��5%      .P�5'      �� $��Description��5)   %    �� Width$	 280��6:   	 �� DisplayMemberBinding	 5'   %   �� *Description+5)   :   �� 5*      $��Quantity��5,   %   $	 100��67   	 5*   %   �� 
 �� Path$
 Quantity�5,   7   �� 5-      $��Price��5/   %   $	 120��64   	 5-   %   �� $
 	UnitPrice�5/   4   �� 50      $��Tax(%)��52   %   $	 120��65   	 50   %   �� $	
 Tax�52   5   �� 53      $��	Total Tax��55   %   $	 120��68   	 53   %   �� $
 TotalTax�55   8   �� 56      $��Total��58   %   $	 100��64   	 56   %   �� $
 Total�58   4   59      5;      �� 5<   
   -   5        $ DiscountLabel��5<      $��3��6+   $��5��6;   $��15(�6H   $��	Discount:��6V   $��692,616,227,142q�6g   $��3��6�   �� 5=   
   -   5         ��Name$ discountBox��5=      $��3��6'   $��5��67   $��771,616,92,152q�6D   6\   �� 5>   
   -   5        $ 
TotalLabel��5>      $��3��6(   $��5��68   $��15(�6E   $
��Bold"�6S   $��Total:��6e   $��692,682,225,86q�6s   $��3��6�   �� 5?   
   -   5        $ totalBox��5?      $��3��6$   $��5��64   $��771,682,92,86q�6A   �� 5@   
   -   5        $ ContactLabel��5@      $��2��6*   $��5��6:   $��20(�6G   $
��Bold"�6U   $��Contact��6g   $��405,590,506,180q�6v   $��3��6�    J� RenderTransformOrigin$ -0.263,0.495&�6�   �� 5A   
   -   5        $ AddressLabel��5A      $��1��6*   $��5��6:   $��20(�6G   $
��Bold"�6U   $��Address��6g   $��48,586,800,168q�6v   $��3��6�   $ -0.263,0.495&�6�   �� 5B   
   -	   5        $ 	DateLabel��5B      $��3��6'   $��5��67   $��15(�6D   $��Invoice Date��6R   $��642,115,249,660q�6f   �� 5C   
   -
   5        $ DueDateLabel��5C      $��1��6*   $��5��6:   $��15(�6G   $��Due Date��6U   $��642,166,262,610q�6e   $��3��6~   �� 5D   
   -   5        $ companyName��5D      $��1��6)   $��5��69   $��30(�6F   $�� ��6T   $��35,125,624,607q�6\   $��3��6t   $��	ExtraBold"�6�   �� 5E   
   -   5        $ receiverAddress��5E      $��1��6-   $��5��6=   $��15(�6J   $�� ��6X   $��436,82,404,607q�6`   $��3��6x   �� 5F   
   -   5        $ senderAddress��5F      $��1��6+   $��5��6;   $��15(�6H   $�� ��6V   $��48,636,708,40q�6^   $��3��6u   �� 5G   
   -   5        $ senderContact��5G      $��1��6+   $��5��6;   $��15(�6H   $�� ��6V   $��405,636,374,40q�6^   $��3��6v   ]� 5H   
   $��0��6   $��0��6%   $��5��62   .+�5I      o� $	��Top=�6   $��23��6(   .@�5J      m� $��_File��6   .@�5K      m� -   5        $��_Open Invoice��5K      66   m� 5L      $��
_Load Logo��6   ${�False��63   �� 5M      m� 5N      $��_Print��6   ${�False��6/   m� 5O      $��_Save As Image��6   ${�False��67   �� 5P      m� 5Q      -   5        $��_Exit��5Q      6.   5R      m� 5S      $��_Help��6   ${� False��6*   5T      5U      �� 5V       �� AcceptsReturn$
 True��6   5W      (  "System.Windows.Controls.DatePicker  5X   
   -   5          Name$ InvoiceDate��5X      $��3��6+   $
��Left=�6;   $��794,114,0,0q�6V   $��5��6k   $	��Top=�6x   $	��178��6�     5Y   
   -   5        $ DueDate��5Y      $��3��6(   $
��Left=�68   $��794,166,0,0q�6S   $��5��6h   $	��Top=�6u   $	��178��6�   �� 5Z   
   -   5        $ InvoiceNumber��5Z      
���  ��$��1��6<   $��5��6L   $��15(�6Y   $�� ��6g   $��821,69,46,685q�6o   $��3��6�   5[      5\      