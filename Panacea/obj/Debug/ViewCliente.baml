   M S B A M L   `   `   `  ����B  >Panacea, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:PanaceaPanacea  5   	       Panacea.ViewCliente   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:Panacea     5   	   V RMaterialDesignThemes.Wpf, Version=3.1.1.1361, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      -   5           MaterialDesignBody#���   5	      $��Regular"�5
      $��13(�5      &   System.Windows.Media.TextOptions    TextFormattingMode$  Ideal=�5         TextRenderingMode$
 Auto=�5        MaterialDesignPaper#���  5        MaterialDesignFont#���  5       � Title$ ViewCliente��5   	   $��497.482��6   $��778.417��6.   
���   �$��2q�6i    � AllowsTransparency .  � WindowStyle$
 None=�6�    � WindowStartupLocation$ CenterScreen=�6�   .��5      � .+�5   
   � ���#99FFFF$��80��6$   $	��Top=�60   .+�5      ��  �� Orientation$ 
Horizontal=�6   .+�5      �� $��Agregar Clientes��6   $��30(�64   $��Center=�6B   $��Showcard Gothic)�6]   5      �� 5      $��
img/vi.jpg��6   $��
0,0,-0.2,0q�6(   $��Right=�6<   �� 5      $��img/em2.jpg��6   $��0,0,114.2,0q�6)   $��Right=�6>   5      � 5   
   $	��200��6   $
��Left=�6   $��0,81,0,0q�66   .+�5      �� $ Vertical=�6   .+�5      �� -   5         ��Name$ 	txtnombre��5       ( $MaterialDesignFilledTextFieldTextBox#��[ 6.   $��12(�6l   $	��400��6{   $��70��6�   )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Nombre del Cliente��6�   $��62��6�   $��12,10,17.6,0q�6�   �� 5      -   5        $ txtPape��5      #��[ 6,   $��12(�6j   $	��400��6y   $��70��6�   $ Primer Apellido��6�   $��62��6�   $��12,10,17.6,0q�6�   �� 5      -   5        $ txtSeApe��5      #��[ 6-   $��12(�6k   $	��400��6z   $��70��6�   $ Segundo Apellido��6�   $��62��6�   $��12,10,17.6,0q�6�   �� 5      -   5        $ txtCi��5      #��[ 6*   $��12(�6h   $	��400��6w   $��70��6�   $ Ci��6�   $��62��6�   $��12,10,17.6,0q�6�   �� 5      -   5        	 ��Name$	 
btnAgregar��5      $��Agregar ��6-   $	��100��6@   $��10q�6L   
���   �6q   �� 5       -   5        $	 btnsal��5       $��Salir��6)   $	��100��69   
���   �6X   5!      5#      � 5$   
   $��
206,81,1,0q�6   .+�5%      &   System.Windows.Controls.DataGrid  -   5        
  Name$
 gridClientes��5%      5&      5)      5*      