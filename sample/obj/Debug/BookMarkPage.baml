   M S B A M L   `   `   `  ����A  =sample, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:samplesample  5          sample.BookMarkPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      &localclr-namespace:sample     5      -   5          N� Title$  BookMarkPage��5	      .��5      �  � RowDefinitions 5      �� 5      �� 5      $��9* �6    .+�5      &   System.Windows.Controls.DataGrid  -   5        $��histDataGrid��5   $   $��1��6      AutoGenerateColumns .     CanUserAddRows .  $��5q�6k   $��Stretch=�6v   $��Stretch=�6�   ��. $��1q�5      $
��Auto=�6(   $
��Auto=�6Z      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Width5  /System.Windows.Controls.DataGridLengthConverter$ 5* 6)      Header$ BookMark��64      
IsReadOnly . 1  +System.Windows.Controls.DataGridBoundColumn   Binding 6F   �� 	 �� Path$	 Query�6g     5      $ 5* 6)   $
 Date��64    .  6B   �� $
	 Date�6b   4  .System.Windows.Controls.DataGridTemplateColumn  5      
   CellTemplate
 5      �� 5      .R�5   "   �� $��Delete��6)   -   5        $��Delete��5   7   ��5   &   �� 5   *    �� 
TargetType" ��60   .�5   .   ��  �� Property � �� �� Value$ SemiBold"�6K   �� 5   .    � ��
 �����6K   �� 5    .    � ��$ 20(�6I   �� 5!   .    � ��$ 3q�6G   �� 5#   .    � ��
 �����6K   �� 5$   .    �@�Cursor$
 Hand��6G    �� Triggers 5%   .   P� 5&   2    P� Property �@J�IsMouseOver P� Value . . �5'   6   ��  � �� �#ff33336S   5(   3   5+   +   ��5-   &   �� 5.   *    �� 
TargetType" ��6:   .R�5/   .   �� $	��150��65   $��38��6A    �� CornerRadius$ 20��6M   #��z��6_   ._�50   2   �� $��Center=�6C   $��Center=�6`   51   /   52   +   56   #   57      59      ��5=      �� 5>      "  6   .�5?      ��  � ��
 �����63   �� 5@       � ��$ 15(�61   �� 5A       �@�Cursor$
 Hand��6/   �� 5B       �@ GridLinesVisibility$ 
Horizontal=�6<   �� 5C       � ��$ 1q�68   5E      5H      �� 5J   
   -   5         ��Name$ clrbtn��5J      $��ClearAll��6!   $
��Left=�64   $��	19,15,0,0q�6O   $	��Top=�6b   $	��104��6z   ��5K      �� 5L      " ��6   .�5M      ��  � ��$ SemiBold"�63   �� 5N       � ��
 �����63   �� 5O       � ��$ 20(�61   �� 5P       � ��$ 8q�6/   �� 5R       � ��
 �����63   �� 5S       �@�Cursor$
 Hand��6/    5T      P� 5U       �@J�IsMouseOver . . �5V      ��  � �� �#ff33336;   5W      5Z      ��5\      �� 5]      " ��6"   .R�5^      �� $	��100��6   $��30��6)   $ 19��65   #��z��6G   ._�5_      �� $��Center=�6+   $��Center=�6H   5`      5a      5d      5j      5k      