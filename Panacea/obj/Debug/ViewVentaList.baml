   M S B A M L   `   `   `  ����B  >Panacea, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:PanaceaPanacea  5   	       Panacea.ViewVentaList   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:Panacea     5   	   V RMaterialDesignThemes.Wpf, Version=3.1.1.1361, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   
   -   5           MaterialDesignBody#���   5	      $��Regular"�5
      $��13(�5      &   System.Windows.Media.TextOptions    TextFormattingMode$  Ideal=�5         TextRenderingMode$
 Auto=�5        MaterialDesignPaper#���  5        MaterialDesignFont#���  5       � Title$ ViewVentaList��5   	   $��644.048��6   $��974.054��60   
���   �$��1q�6k    � AllowsTransparency .  � WindowStyle$
 None=�6�    � WindowStartupLocation$ CenterScreen=�6�   .��5      � .+�5   
   � ���#99FFFF$��80��6$   $	��Top=�60   .+�5      ��  �� Orientation$ 
Horizontal=�6   .+�5      �� $��Registro de Ventas��6   $��30(�66   $��Center=�6D   $��Showcard Gothic)�6_   5      �� 5      $��
img/vi.jpg��6   $��
0,0,-0.2,0q�6(   $��Right=�6<   �� 5      $��img/em2.jpg��6   $��0,0,114.2,0q�6)   $��Right=�6>   5      � 5   
   $��
3,83,2.6,0q�6   .+�5      �� $��5q�6   .+�5      �� $ 
Horizontal=�6   .+�5      (  "System.Windows.Controls.DatePicker  -   5          Name$ date1��5   !   $	��140��5      )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Fecha��5       $  MaterialDesignOutlinedDatePicker#��[ 5      $��10q�6=     5       -   5        $ date2��5    !   $	��140��5!      $ Fecha��5"      #��[ 5#      $��10q�6=   �� 5$      -   5        	 ��Name$	 	btnSearch��5$      $��Ventas Resgitradas��60   
���   �6e   5&      &   System.Windows.Controls.DataGrid  5'      -   5        
  Name$
 	dgVentasR��5'         CanUserAddRows .  $	��399��6E   $��	5,5,5.2,5q�6R   
���   �$��1q�6y    � ContextMenu 5(      �� 5)      .@�5*      m� -   5         m�Name$ CoInabilitar��5*   '   $��Anular Venta��6=   6S   m� 5+      -   5        $ 	CodarBaja��5+   '   $��Dar de Baja��6:   6O   5,      5.      �� 5/      $��58��6   $��
0,0,-0.4,0q�6)   .+�50      �� $%��Click Derecho Para las Opciones��6    $	��300��6G   �� 51      -   5        $	 btnsalir��51      $��Salir��6/   $	��100��6?   $��Right=�6K   $��0,0,30,0q�6g   
���   �6�   52      53      54      56      57      