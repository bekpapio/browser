   M S B A M L   `   `   `  ����A  =sample, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:samplesample  5          sample.HistoryPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      &localclr-namespace:sample     5      Y UFontAwesome.Sharp, Version=5.15.4.0, Culture=neutral, PublicKeyToken=d16d1e4e568ec10fFfa=http://schemas.awesome.incremented/wpf/xaml/fontawesome.sharp  5      -   5          N� Title$  HistoryPage��5
      .��5      �  � RowDefinitions 5   
   �� 5      �� 5      $��9* �6   .+�5   
   &   System.Windows.Controls.DataGrid  -   5        $��histDataGrid��5       $��1��6      AutoGenerateColumns .     CanUserAddRows .  $��5q�6g   $��Stretch=�6r   $��Stretch=�6�   ��. $��1q�5      $
��Auto=�6(   $
��Auto=�6Z      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Width5  /System.Windows.Controls.DataGridLengthConverter$ 5* 6%      Header$ History��60      
IsReadOnly . 1  +System.Windows.Controls.DataGridBoundColumn   Binding 6A   �� 	 �� Path$	 Query�6b     5      $ 5* 6%   $
 Date��60    .  6>   �� $
	 Date�6^   4  .System.Windows.Controls.DataGridTemplateColumn  5      
   CellTemplate
 5      �� 5      .R�5       �� $��delete��6%   -   5        $��Delete��5    3   ��5"   "   �� 5#   &    �� 
TargetType" ��6,   .�5$   *   ��  �� Property � �� �� Value$ SemiBold"�6G   �� 5%   *    � ��
 �����6G   �� 5&   *    � ��$ 20(�6E   �� 5'   *    � ��$ 3q�6C   �� 5)   *    � ��
 �����6G   �� 5*   *    �@�Cursor$
 Hand��6C    �� Triggers 5+   *   P� 5,   .    P� Property �@J�IsMouseOver P� Value . . �5-   2   ��  � �� �#ff33336O   5.   /   51   '   ��53   "   �� 54   &    �� 
TargetType" ��66   .R�55   *   �� $	��150��61   $��38��6=    �� CornerRadius$ 20��6I   #��z��6[   ._�56   .   �� $��Center=�6?   $��Center=�6\   57   +   58   '   5;      5<      5>      ��5B      �� 5C      "  6   .�5D      ��  � ��
 �����63   �� 5E       � ��$ 15(�61   �� 5F       �@�Cursor$
 Hand��6/   �� 5G       �@ GridLinesVisibility$ 
Horizontal=�6<   �� 5H       � ��$ 1q�68   5J      5Q      �� 5T   
   -   5         ��Name$ clrbtn��5T      $��ClearAll��6!   $
��Left=�64   $��	19,15,0,0q�6O   $	��Top=�6b   $	��104��6z   ��5U      �� 5V      " ��6   .�5W      ��  � ��$ SemiBold"�63   �� 5X       � ��
 �����63   �� 5Y       � ��$ 20(�61   �� 5Z       � ��$ 8q�6/   �� 5\       � ��
 �����63   �� 5]       �@�Cursor$
 Hand��6/    5^      P� 5_       �@J�IsMouseOver . . �5`      ��  � �� �#ff33336;   5a      5d      ��5f      �� 5g      " ��6"   .R�5h      �� $	��100��6   $��30��6)   $ 19��65   #��z��6G   ._�5i      �� $��Center=�6+   $��Center=�6H   5j      5k      5n      5r      5s      