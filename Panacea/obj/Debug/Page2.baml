   M S B A M L   `   `   `  ����B  >Panacea, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:PanaceaPanacea  5          Panacea.Page2   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      'localclr-namespace:Panacea     5      V RMaterialDesignThemes.Wpf, Version=3.1.1.1361, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5	         MaterialDesignBody#���   5
      $��Regular"�5      $��13(�5      &   System.Windows.Media.TextOptions    TextFormattingMode$  Ideal=�5         TextRenderingMode$
 Auto=�5        MaterialDesignPaper N� 
Background# �  5        MaterialDesignFont N� 
FontFamily# �  5       N� Title$ Page2��5      .��5      � 
�������$��0,0,-294.2,-211q�6   .+�5   
   � ���#99FFFF$��80��6$   $	��Top=�60   .+�5      ��  �� Orientation$ 
Horizontal=�6   .+�5      �� $��Regitro De Enfermedad��6   $��30(�69   $��Center=�6G   $��Showcard Gothic)�6b   5      �� 5      $��
img/vi.jpg��6   $��
0,0,-0.2,0q�6(   $��Right=�6<   �� 5      $��img/em2.jpg��6   $��0,0,114.2,0q�6)   $��Right=�6>   5      �� 5   
   -   5         ��Name$ 	txtnombre��5      $
��Left=�6%   $��34��6@   $��143,255,0,0q�6L    �� TextWrapping$
 Wrap=�6a   $�� ��6u   $	��Top=�6~   $	��122��6�   �� 5   
   $"��Agregar o Modificar Registro��6   $��20(�67   $
��Left=�6E   $��
39,104,0,0q�6`   $	��Top=�6t   $��40��6�   $	��308��6�   $��Segoe UI Black)�6�   �� 5   
   $��Nombre:��6   $��17(�6"   $
��Left=�60   $��
38,258,0,0q�6K   $	��Top=�6_   $��29��6w   $��80��6�   �� 5   
   $��Descripcion:��6   $��17(�6'   $
��Left=�65   $��
34,311,0,0q�6P   $	��Top=�6d   $��39��6|   $	��100��6�   �� 5   
   $��Rama Medica��6   $��17(�6&   $
��Left=�64   $��
74,421,0,0q�6O   $	��Top=�6c   �� 5    
   -   5         ��Name$ comboramame��5       )  #MaterialDesignThemes.Wpf.HintAssist	   Hint$	 CARDIOLOGIA��6)   
 J� RenderTransformOrigin$
 
0.238,1.35&�6W   $��75,454,919,172q�6z   $��33��6�   .@�5!      �� .��6   CARDIOLOGIA5#      �� 5$      .��6   DERMATOLIGA5&      �� 5'      .��6   CARDIOLOGIA5)      5+      �� 5-   
   -   5        $ 	txtdescri��5-       * &MaterialDesignOutlinedTextFieldTextBox#��[ 5.      $	��Top=�5/      $	��100��50       �� AcceptsReturn . $
 Wrap=�52      " �� VerticalScrollBarVisibility$
 Auto=�53      $	 Escribe Aqui��54      $��151,309,808,0q�55      �� 56   
   $��ID��6   $��17(�6   $
��Left=�6+   $��
77,218,0,0q�6F   $	��Top=�6Z   $��26��6r   $��25��6~   �� 57   
   -   5        $ txtid��57      $
��Left=�6!   {�.  $��23��6N   $��146,218,0,0q�6Z   $
 Wrap=�6o   $�� ��6�   $	��Top=�6�   $	��120��6�   �� 58   
   -   5         ��Name$ 
btnagregar��58      
���   ����#99FFFF{�.  $��Agregar��6_   $
��Left=�6q   $��
66,535,0,0q�6�   $	��Top=�6�   $��99��6�   6�   �� 59   
   -   5        $ btnmodificar��59      ���#99FFFF
���   �{�.  $��	Modificar��6a   $
��Left=�6u   $��185,537,0,0q�6�   $	��Top=�6�   $	��109��6�   6�   �� 5:   
   -   5         ��Name$ 	checkagre��5:      $��Agregar��6'   $
��Left=�69   $��
79,176,0,0q�6T   $	��Top=�6h   $��Arial Black)�6�   �� 5;   
   -   5        $ 	checkmodi��5;      $��Arial Black)�6&   $��	Modificar��6?   $
��Left=�6S   $��178,177,0,0q�6n   $	��Top=�6�   6�   �� 5<   
   -	   5        $ checkeli��5<      $��Arial Black)�6%   $��Eliminar��6>   $
��Left=�6Q   $��285,176,0,0q�6l   $	��Top=�6�   6�   �� 5=   
   -
   5        $ btneliminar��5=      ���#99FFFF
���   �{�.  $��Eliminar��6`   $
��Left=�6s   $��310,537,0,0q�6�   $	��Top=�6�   $	��109��6�   6�   &   System.Windows.Controls.DataGrid  5>   
   -   5          Name$ datalist��5>      $
��Left=�6%   $	��454��6@   $��629,128,0,0q�6M   $	��Top=�6b   $	��444��6z   �� 5?   
   -   5        $ btnregis��5?      ���#99FFFF
���   �$��Listar Registros��6K   $
��Left=�6f   $��781,588,0,0q�6�   $	��Top=�6�   $	��133��6�   6�   �� 5@   
   $�� Registros ��6   $��20(�6&   $
��Left=�64   $��
797,92,0,0q�6O   $	��Top=�6c   $��40��6{   $	��138��6�   $��Segoe UI Black)�6�   5B      5C      