   M S B A M L   `   `   `  ����B  >PDFview, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:PDFviewPDFview  5   	       PDFview.ListArchive   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:PDFview     5   	   a ]Syncfusion.SfGrid.WPF, Version=16.1460.0.32, Culture=neutral, PublicKeyToken=3d67ed1f87d44c89a ]Syncfusion.Shared.Wpf, Version=16.1460.0.32, Culture=neutral, PublicKeyToken=3d67ed1f87d44c89/SiaSf!http://schemas.syncfusion.com/wpf   5   	   -   5          � Title$  Lista��5   	   $	��400��6   $	��500��6$    � 	Resources 5
       �� Color   	ColorMain �� 
TargetType  BtnStyle �� Property �� Value3  -Syncfusion.UI.Xaml.Grid.GridHeaderCellControl  headerStyle��%v  &	        &	 &     7   7   &	 I    �� 5   
   $ #e74c3c��6   6*   �� 5   
   " ��6   .�5      ��  � ��8   6+   �� 5       � ��8  6,   �� 5       � ��
 �����6+   �� 5       �@�Cursor$
 Hand��6'   �� 5       � ��$	 100��6&   �� 5       � ��$ 25��6'   �� 5       � ��$ 5q�6'   5      �� 5   
   "  6   .�5      ��  � ��$
 Bold"�6+   �� 5       � ��$ Arial)�6+   �� 5       � ��$ 10(�6)   �� 5       � ��
 �����6+   �� 5       � ��
 �   �6+   �� 5       � ��
 �   �6,   5      5      .��5      �  � RowDefinitions 5    
   �� 5!      �� 5"      $��40 �6   .+�5$   
   (  "Syncfusion.UI.Xaml.Grid.SfDataGrid  -   5          Name$ DataGridArchive��5$      (  "Syncfusion.UI.Xaml.Grid.SfGridBase   AllowResizingColumns . 	   EnableDataVirtualization	 . 
   AllowFiltering
 . $��5q�6�      HeaderStyle# [ 6�   $��10)�6�      Columns 5&      ,  &Syncfusion.UI.Xaml.Grid.GridTextColumn  ,  &Syncfusion.UI.Xaml.Grid.GridColumnBase   MappingName$ idrow��6'      Width$ 50Q�6;     5'         
HeaderText$ cod_trn��6'   $ cod_trn��6<   $ 80Q�6R     5(      $ num_trn��6'   $ num_trn��6<   $	 100Q�6R     5)      $ name_archive��6'   $ name_archive��6A   $	 200Q�6\     5*      $ 	extencion��6'   $ 	extencion��6>   $	 100Q�6V   5,      � 5.   
   $��1��6   
�������.+�5/      ��  �� Orientation$ 
Horizontal=�6   $��Center=�62   .+�50      �� -   5        $��	BtnSelect��50      $��
Selecionar��6*   #��[ 6?   6a   �� 51      -   5        $��BtnSalir��51      $��Salir��6)   #��[ 69   6[   53      54      55      56      