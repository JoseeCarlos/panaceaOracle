   M S B A M L   `   `   `  ����B  >Panacea, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:PanaceaPanacea  5   	       Panacea.ViewVenta   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:Panacea     5   	   V RMaterialDesignThemes.Wpf, Version=3.1.1.1361, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      -   5           MaterialDesignBody#���   5	      $��Regular"�5
      $��13(�5      &   System.Windows.Media.TextOptions    TextFormattingMode$  Ideal=�5         TextRenderingMode$
 Auto=�5        MaterialDesignPaper#���  5        MaterialDesignFont#���  5       � Title$ 	ViewVenta��5   	   $��723.723��6   $��1058.339��6,    � WindowStartupLocation$ CenterScreen=�6T   
���   �$��2q�6�    � AllowsTransparency .  � WindowStyle$
 None=�6�   .��5      � .+�5   
   � ���#99FFFF$��80��6$   $	��Top=�60   .+�5      ��  �� Orientation$ 
Horizontal=�6   .+�5      �� $��Realizar Venta��6   $��30(�62   $��Center=�6@   $��Showcard Gothic)�6[   5      �� 5      $��
img/vi.jpg��6   $��
0,0,-0.2,0q�6(   $��Right=�6<   �� 5      $��img/em2.jpg��6   $��0,0,114.2,0q�6)   $��Right=�6>   5      � 5   
   $	��343��6   $
��Left=�6   $��0,80,0,-0.4q�66   .+�5      �� $ Vertical=�6   .+�5      �� -   5         ��Name$ 
bntCliente��5      $��Nuevo Cliente��6-   $	��140��6E   $	��0,5q�6Q   
���   �6q   �� 5      -   5         ��Name$ comboCliente��5      $
��0 15q�5      	 �� 
IsEditable	 .    MaterialDesignFilledComboBox#��[ 5      )  #MaterialDesignThemes.Wpf.HintAssist
   Hint$
 Seleccione el Cliente��5       $	��256��5!      5#      �� 5$      $��Seleccione El Producto��6   $��32,0,35.2,0q�6:   �� 5%      -   5         ��Name$ 	txtProduc��5%       * &MaterialDesignOutlinedTextFieldTextBox#��[ 5&      $	��200��5'      $��40��5(       �� AcceptsReturn .  �� TextWrapping$
 Wrap=�5*      " �� VerticalScrollBarVisibility$
 Auto=�5+      $
 Producto��5,      $��10q�6/   6;   &   System.Windows.Controls.DataGrid  5-      -   5          Name$ dataProduct��5-      $	��330��60   $	��240��6<      CanUserAddRows .  
���   �$��1q�6t   6�   �� 5.      -   5         ��Name$ imageProduct��5.      $	��200��6.   $	��150��6:   $��5q�6G   �� 5/      -   5        $��Agregar Al Carrito��5/      $	��200��66   $��5q�6B   
���   �$��1q�6v   
���   �6�   52      53      � 54   
   $��345,82,2,515.4q�6   .+�55      �� $ 
Horizontal=�6   .+�56      �� -   5        $ txtUser��56      {�.  #��[ 57      $	��200��58      $��40��59       . $
 Wrap=�5;      $
 Auto=�5<      $
 Usuario��5=      $��70,10,40,10q�6.   �� 5>      -	   5        $ txtTotal��5>      #��[ 5?      $	��200��5@      $��40��5A       . $
 Wrap=�5C      $
 Auto=�5D      $
 Total a Pagar��5E      $��10q�64   5F      5G      � 5H   
   $��350,182,3,0.4q�6   .+�5I      �� $ Vertical=�6   .+�5J        -
   5        $ 
dtProductl��5J      $	��374��6/   $��10,10,10.2,10q�6<      AutoGenerateColumns .   .  
���   �$��1q�6�   ��6�   �� *
products+   Columns 5K      0  *System.Windows.Controls.DataGridTextColumn  5L      -   5        dgcproductid��,  &System.Windows.Controls.DataGridColumn   Header$ Id��5L   C   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6O   �� *
IdProducto+  5M      -   5        
dgcnamepro��$ Producto��5M   A    6S   �� *NombreProducto+  5N      -   5        	dgcprecio��$ Precio��5N   @    6P   �� *Precio+  5O      -   5        dgcCantidad��$ Cantidad��5O   B    6T   �� *
Cantidad+ � ContextMenu 5R      �� 5S      .@�5T      m� -   5         m�Name$ 	btnquitar��5T   '   $��Quitar��6:   6J   5V      5X      �� 5Y      $ 
Horizontal=�6   $��0,50,0,0q�66   $��Center=�6H   .+�5Z      �� -   5        $ btnlim��5Z      $��Vaciar Carrito��6-   $
��20,0q�6F   
���   �6g   �� 5[      -   5        $ btnVenta��5[      $��VENDER ��6/   $
��20,0q�6A   
���   �6f   �� 5\      -   5        $ BtExist��5\      $��CANCELAR��6.   $
��20,0q�6A   
���   �6e   5]      5^      5_      5b      5c      