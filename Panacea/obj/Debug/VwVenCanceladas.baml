   M S B A M L   `   `   `  ����B  >Panacea, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:PanaceaPanacea  5   	       Panacea.VwVenCanceladas   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:Panacea     5   	   V RMaterialDesignThemes.Wpf, Version=3.1.1.1361, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   
   -   5           MaterialDesignBody#���   5	      $��Regular"�5
      $��13(�5      &   System.Windows.Media.TextOptions    TextFormattingMode$  Ideal=�5         TextRenderingMode$
 Auto=�5        MaterialDesignPaper#���  5        MaterialDesignFont#���  5       � Title$ VwVenCanceladas��5   	   $��812.4��6!   $��988.4��60    � AllowsTransparency .  � WindowStyle$
 None=�6X   
���   �$��2q�6    � WindowStartupLocation$ CenterScreen=�6�   .��5      � .+�5   
   � ���#99FFFF$��80��6$   $	��Top=�60   .+�5      ��  �� Orientation$ 
Horizontal=�6   .+�5      �� $��Registro de Ventas��6   $��30(�66   $��Center=�6D   $��Showcard Gothic)�6_   5      �� 5      $��
img/vi.jpg��6   $��
0,0,-0.2,0q�6(   $��Right=�6<   �� 5      $��img/em2.jpg��6   $��0,0,114.2,0q�6)   $��Right=�6>   5      � 5   
   $��0,82,0,308.6q�6   .+�5      �� $��5,5,4.6,48.2q�6   .+�5      �� .+�5      �� $!��Registro de ventas anuladas��6    $��Center=�6C   5      �� 5      $ 
Horizontal=�6   .+�5       (  "System.Windows.Controls.DatePicker  -   5          Name$ date1��5    !   $	��140��5!      )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ FECHA��5"       $  MaterialDesignOutlinedDatePicker#��[ 5#      $��10q�6=     5$      -   5        $ date2��5$   !   $	��140��5%      $ FECHA��5&      #��[ 5'      $��10q�6=   �� 5(      -   5        	 ��Name$	 	btnSearch��5(      $��Ventas Resgitradas��60   
���   �6M   5*      &   System.Windows.Controls.DataGrid  5+      -   5        
  Name$
 	dgVentasR��5+         CanUserAddRows .  $	��200��6E   $��	5,5,5.2,5q�6R   
���   �$��1q�6y   5-      5.      � 5/   
   $��4,421,-4.4,1.8q�6   .+�50      �� $��5q�6   .+�51      �� .+�52      �� $&�� Registro de ventas Dadas de Baja��6    $��Center=�6H   53      �� 54      $ 
Horizontal=�6   .+�55        -   5        $ d��55   !   $	��140��56      $ P��57      #��[ 58      $��10q�6=     59      -   5        $ A��59   !   $	��140��5:      $ 	Pick Date��5;      #��[ 5<      $��10q�6=   �� 5=      -   5        $	 C��5=      $��Ventas Resgitradas��6(   
���   �6E   5?        5@      -	   5        $
 	datagrid2��5@       .  $	��200��6E   $��	5,5,5.2,5q�6R   
���   �$��1q�6y   �� 5A      .+�5B      �� -
   5        $	 btnexit��5B      $��Salir��6.   $	��100��6>   $��Right=�6`   $��	0,10,30,0q�6|   
���   �6�   5C      5D      5E      5G      5H      