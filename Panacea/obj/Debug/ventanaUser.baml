   M S B A M L   `   `   `  ����B  >Panacea, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:PanaceaPanacea  5          Panacea.ventanaUser   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      'localclr-namespace:Panacea     5      V RMaterialDesignThemes.Wpf, Version=3.1.1.1361, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5	         MaterialDesignBody#���   5
      $��Regular"�5      $��13(�5      &   System.Windows.Media.TextOptions    TextFormattingMode$  Ideal=�5         TextRenderingMode$
 Auto=�5        MaterialDesignPaper N� 
Background# �  5        MaterialDesignFont N� 
FontFamily# �  5       N� Title$ ventanaUser��5      .��5      � 
�������$��0,0,-294.2,-221q�6   .+�5   
   � ���#99FFFF$��80��6$   $	��Top=�60   .+�5      ��  �� Orientation$ 
Horizontal=�6   .+�5      �� $��Regitro De Usuarios��6   $��30(�67   $��Center=�6E   $��Showcard Gothic)�6`   5      �� 5      $��
img/vi.jpg��6   $��
0,0,-0.2,0q�6(   $��Right=�6<   �� 5      $��img/em2.jpg��6   $��0,0,114.2,0q�6)   $��Right=�6>   5      � 5   
   $��199,81,480,0q�6   .+�5      �� $ Vertical=�6   .+�5      �� $��Agregar un Usuario��6   $��20(�65   $��Center=�6C   $��	81,5,86,5q�6`   $	��Top=�6s   $��40��6�   $	��233��6�   $��Segoe UI Black)�6�   �� 5      -   5         ��Name$ txtnom��5       ( $MaterialDesignFilledTextFieldTextBox#��[ 6+   $��17(�6i   $	��400��6x   $��70��6�   )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Nombre Usuario��6�   $��69��6�   $��	76,0,71,0q�6�   �� 5      -   5        $ txtpape��5      #��[ 6,   $��17(�6j   $	��400��6y   $��70��6�   $ Pri. Apellido��6�   $��69��6�   $��	76,0,71,0q�6�   �� 5       -   5        $ txtsApe��5       #��[ 6,   $��17(�6j   $	��400��6y   $��70��6�   $ S. Apellido��6�   $��69��6�   $��	76,0,71,0q�6�   (  "System.Windows.Controls.DatePicker  5!      -   5          Name$ datepik1��5!      $ Fecha de nacimiento��5"      $��17(�68   
���   � ( $MaterialDesignFloatingHintDatePicker#��[ 5#      $	��260��6A   $��10q�6M   �� 5$      -   5        	 ��Name$	 	combogene��5$      $��17(�6.   $��10q�6<   
���   �$ GENERO��6[   
 J� RenderTransformOrigin$
 
0.238,1.35&�6�   $	��250��6�   $��50��6�   .@�5%      �� .��6#   M5'      �� 5(      .��6#   F5*      5+      �� 5,      -   5        $ 	txtcorreo��5,      #��[ 6.   $��17(�6l   $	��400��6{   $��70��6�   $ Correo��6�   $��69��6�   $��	35,0,29,0q�6�   �� 5-      -   5        $	 	comborole��5-      $��17(�6.   $��10q�6<   
���   �$ ROL DE USUARIO��6[   $
 
0.238,1.35&�6�   $	��250��6�   $��50��6�   .@�5.      �� .��6#   Administrador50      �� 51      .��6#   Ventas53      �� 54      .��6#   
Inventario56      58      �� 59      -   5         ��Name$ 
btnagregar��59      
���   ����#99FFFF$��Agregar��6V   $��Center=�6h   $	��Top=�6�   $	��150��6�   $��40��6�   6�   5;      5>      � 5?   
   $��629,80,185,0q�6   .+�5@      �� .+�5A      �� $��Seleccione la imagen��6   $��20(�67   $��Center=�6E   $��Segoe UI Semibold)�6b   �� 5B      -	   5        $ btnfile��5B      $	��...��6*   $	��100��68   $��50��6D   $��5q�6P   6[   �� 5C      -
   5         ��Name$ 	imageUser��5C      $	��250��6+   $
�� 200��67   $��10q�6E   5D      5E      5I      5J      