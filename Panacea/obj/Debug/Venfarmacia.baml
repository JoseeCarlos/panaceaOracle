   M S B A M L   `   `   `  ����B  >Panacea, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:PanaceaPanacea  5      d `Microsoft.Maps.MapControl.WPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35tRclr-namespace:Microsoft.Maps.MapControl.WPF;assembly=Microsoft.Maps.MapControl.WPFMicrosoft.Maps.MapControl.WPF 5          Panacea.Venfarmacia   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      'localclr-namespace:Panacea     5      V RMaterialDesignThemes.Wpf, Version=3.1.1.1361, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      ZmRclr-namespace:Microsoft.Maps.MapControl.WPF;assembly=Microsoft.Maps.MapControl.WPF  5      -   5           MaterialDesignBody#���   5	      $��Regular"�5
      $��13(�5      &   System.Windows.Media.TextOptions    TextFormattingMode$  Ideal=�5         TextRenderingMode$
 Auto=�5        MaterialDesignPaper N� 
Background# �  5        MaterialDesignFont N� 
FontFamily# �  5       N� Title$ Venfarmacia��5      .��5      � 
�������$��0,0,-244.2,-171q�6   .+�5   
   � ���#99FFFF$��80��6$   $	��Top=�60   .+�5      ��  �� Orientation$ 
Horizontal=�6   .+�5      �� $��Regitro De Proveedor��6   $��30(�68   $��Center=�6F   $��Showcard Gothic)�6a   5      �� 5      $��
img/vi.jpg��6   $��
0,0,-0.2,0q�6(   $��Right=�6<   �� 5      $��img/em2.jpg��6   $��0,0,114.2,0q�6)   $��Right=�6>   5      � 5   
   $	��290��6   $
��Left=�6   $��0,82,0,-0.4q�66   .+�5      �� $��Center=�6   $ Vertical=�66   $��
0,0,0,-0.4q�6M   .+�5      �� $��Ingrese los Datos ��6   $��25(�66   $��10q�6D   
���   � �� TextAlignment$ Center=�6c   $��Arial Black)�6z   �� 5      -   5         ��Name$ 	combopais��5       $
��0 15q�5         MaterialDesignFilledComboBox#��[ 5      )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Seleccione el Pais��5"      $	��256��5#      5%      �� 5&      -   5        $ combociudad��5(      #��[ 5'      $ Seleccione la Ciudad��5*      $	��256��5+      5-      �� 5.      -   5        	 ��Name$	 	txtnombre��5.       ( $MaterialDesignFilledTextFieldTextBox#��[ 6.   $��17(�6l   $	��400��6{   $��70��6�   $ Nombre Proveedor��6�   $��69��6�   $��
12,10,18,0q�6�   �� 5/      -   5        $	 txtdirec��5/      #��[ 6-   $��17(�6k   $	��400��6z   $��70��6�   $ 	Direccion��6�   $��69��6�   $��
16,10,15,0q�6�   �� 50      -   5        $	 txtTelefono��50      #��[ 60   $��17(�6n   $	��400��6}   $��70��6�   $ Telefono��6�   $��69��6�   $��
16,10,12,0q�6�   �� 51      -   5        
 ��Name$
 btnregis��51      
���   �$��	Registrar��6>   $��Center=�6R   $��10q�6o   $	��101��6}   6�   �� 52      -   5        $
 	btnCancel��52      
���   �$��Cancelar��6?   $��Center=�6R   $	��103��6q   $��1��6}   53      54      � 55   
   $	��797��6   $��Right=�6   $��	0,81,0,-1q�67    � RowDefinitions 57      �� 58      $
��481* �6    �� 59      $	��59* �6    .+�5;      '  !Microsoft.Maps.MapControl.WPF.Map  -	   5          Name$ myMap��5;      $��-3,32,23,51.2q�6#   +  %Microsoft.Maps.MapControl.WPF.MapCore   CredentialsProviderT  NMicrosoft.Maps.MapControl.WPF.Design.ApplicationIdCredentialsProviderConverter$F @AlRJpzgX-PTCB1V_d9mNmyezG45V1rwt6khgeBKas3DxDqe2RuNV0o9Hjtqpz1gw 6:      	ZoomLevel$ 12Q�6�      Center<  6Microsoft.Maps.MapControl.WPF.Design.LocationConverter$ -17.387324 ,-66.166499 6�   $��2��6�   �� 5<      -
   5        $
 btnsatelite��5<      
���   �$��Satelite��6=   $��87��6S   $��167,12,543,15.2q�6x   $��1��6�   �� 5=      -   5        $
 	btncalles��5=      $��Calles��6(   
���   �$��83��6M   $��279,9,435,18.2q�6p   $��1��6�   �� 5>      -   5        $
 btnmas��5>      $��+��6%   
���   �$��75��6E   $��379,12,343,15.2q�6e   $��1��6~   �� 5?      -   5        $
 btnmenos��5?      $��-��6'   
���   �$��75��6G   $��482,10,240,17.2q�6i   $��1��6�   5C      5I      5J      