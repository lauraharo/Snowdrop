   M S B A M L   `   `   `  ����A  =Kooste, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:KoosteKooste  5   	       Kooste.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   &localclr-namespace:Kooste     5   	   -   5          � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5	      �  J� RenderTransformOrigin$ 0.576,0.438&�6   .+�5
   
   o� $	��Top=�6   .@�5      m� $��_File��6   .@�5      m� -   5         m�Name$ menuOpen��5      $��
_Open text��6-   6A   m� 5      -   5        $ menuSave��5      $��
_Save text��6-   6A   m� 5      -   5        $ menuExit��5      $��_Exit��6-   6<   5      m� 5      $��_Edit��6   .@�5      m� $��_Copy��6    m� Command$ ApplicationCommands.Copy��6*   m� 5      $��_Paste��6   $ ApplicationCommands.Paste��6+   5      m� 5      $��_Paint��6   .@�5      m� -   5        $��_Draw...��5      6-   5      m� 5      $
��_Web��6   .@�5      m� -   5        $ browser��5      $��_Browser...��6,   6A   5      5      �� 5   
   -   5         ��Name$ textBox��5      $
��Left=�6#   $	��208��6>   $��	10,54,0,0q�6K    �� TextWrapping$
 Wrap=�6^   $��Write or add a line...��6r   $	��Top=�6�   $	��215��6�    �� AcceptsReturn . ��6�   �� *Value+ �� ElementName$ slider1��6�   �� 5   
   $��
Write here��6   $
��Left=�6%   $��	10,23,0,0q�6@   $	��Top=�6S   $��Segoe WP Black)�6k   $��16(�6�   �� 5   
   -   5         ��Name$ canvas��5      $
��Left=�6!   $	��208��6<   $��
298,54,0,0q�6I   $	��Top=�6]   $	��319��6u   ���	#FFDCECE5.+�5      A� -	   5        	 A�Name$	 ellipse��5      ���	#FF9B9BEA$��49��68   
 �� Left$	
 132��6D   
 �� Top$ 82��6V   $��49��6f   6�   �� 5      -
   5         ��Name$ 
buttonDown��5      $
��Down��6)   $
 81��68   $	 213��6I   $��75��6Z   $ 0.776,0.551&�6e   6�   5       �� 5!   
   -   5        $ buttonUp��5!      $��Up��6#   $
��Left=�60   $��298,267,0,0q�6K   $	��Top=�6`   $��75��6x   6�   �� 5"   
   -   5        $ 
buttonLeft��5"      $
��Left��6%   $
��Left=�64   $��462,267,0,0q�6O   $	��Top=�6d   $��75��6|   6�   �� 5#   
   -   5        $ buttonRight��5#      $��Right��6&   $
��Left=�66   $��542,267,0,0q�6Q   $	��Top=�6f   $��75��6~   $ 0.389,0.435&�6�   6�   �� 5$   
   -   5        $ textBox2��5$      $
��Left=�6$   $��20��6?   $��
10,267,0,0q�6K   $
 Wrap=�6_   $��Write or drop a line...��6s   $	��Top=�6�   $	��120��6�   �� 5%   
   -   5        $ 	buttonAdd��5%      $	��Add��6$   $
��Left=�62   $��150,266,0,0q�6M   $	��Top=�6b   $��75��6z   6�   �� 5&   
   -   5        $ reset��5&      $��Reset��6    $
��Left=�60   $��298,292,0,0q�6K   $	��Top=�6`   $��75��6x   6�   �� 5'   
   -   5         ��Name$ slider1��5'      $
��Left=�6"   $��
10,333,0,0q�6=   $	��Top=�6Q   $	��215��6i    �� IsSnapToTickEnabled .  �� TickPlacement$ BottomRight=�6�    � Value$ 12Q�6�    � Maximum$ 50Q�6�    � Minimum$ 10Q�6�   �� 5(   
   $��Adjust font size��6   $
��Left=�6+   $��
10,302,0,0q�6F   $	��Top=�6Z   $��Segoe UI Black)�6r   5*      5+      