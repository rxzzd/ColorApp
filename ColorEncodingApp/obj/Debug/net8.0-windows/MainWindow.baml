   M S B A M L   `   `   `  ����K  GColorEncodingApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:ColorEncodingAppColorEncodingApp  5   	   I)clr-namespace:ColorEncodingApp.ConvertersColorEncodingApp.Converters  5   	   !    ColorEncodingApp.MainWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:ColorEncodingApp     5   	   @
converters)clr-namespace:ColorEncodingApp.Converters     5   	     � Title$  Color Encoding App��5	   	   $	��720��6$   $
��1280��64    � 
ResizeMode$ NoResize=�6D    � SizeToContent$ WidthAndHeight=�6Z    � 	Resources 5
      4   .ColorEncodingApp.Converters.HtmlColorConverter   HtmlColorConverter��%   &	          5   
   6(   5      .��5      �  J� RenderTransformOrigin$ 0.581,0.488&�6   ��5   
   �� 5       �� ImageSource$ /background.jpg��6    � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $��* �6    � ColumnDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $
��813* �6   �� 5      $
��367* �6   .+�5   
   �� -   5        $��LoadImageButton��5      $��
Load Image��6(   $��10,10,10,664q�6[   $��2��6q   $��24(�6�   ��5      �� 5       �� EndPoint$ 0.5,1&�6&   	 �� 
StartPoint$	 0.5,0&�67   .��5      � 
 � Color$
 Black��6#    � Offset$ 0Q�61   � 5      $
 	#FFFFCCCC��6#   $ 0Q�65   5       5"      �� 5$   
   $��1��6   $��0��6$   $��1��64   $��10,10,10,10q�6H   $
��Auto=�6]   $	��560��6�   $	��560��6�   .��5%      �  5&      �� 5'      $
��Auto �6$   �� 5(      $��* �6$   .+�5-      �� -   5        $��ColorListPanel��5-      $��0��63   $��0,10,0,0q�6@   .+�5.      �� $��Top 10 Colors:��6    $
��Bold"�66   $��0,0,0,5q�6H   $��24(�6Y   �� 5/      -   5        $��ColorListBox��5/      
���   �$��1q�6F   $
��True��6Z    �� SelectionMode$ Extended=�6k   ��50      �� 51      .R�52   "   ��  �� Orientation$ 
Horizontal=�6-   $��5q�6F   .+�53   &   �� $��25��60   $��25��6;   $��5q�6G   ��54   *   �� 55   .    �� Color 6>   �� *
HtmlCode+ �� 	Converter# [  57   '   �� 58   &   .+�59   *   �� $��2q�6N   ��64   �� *
HtmlCode+6N   �� 5:   *   $��2q�6b   ��64   �� *Red+ �� StringFormat$ Red: {0}��6b   �� 5;   *   $��2q�6f   ��64   �� *Green+$ 
Green: {0}��6f   �� 5<   *   $��2q�6d   ��64   �� *Blue+$ 	Blue: {0}��6d   �� 5=   *   $��2q�6f   ��64   �� *Count+$ 
Count: {0}��6f   5>   '   5?   #   5@      5B      5C      5D      5E      �� 5G   
   -   5        $��ImageBorder��5G      $��1��6$   $��1��61   $��10,10,10,38q�6A   
���   �$��1q�6j    � Cursor$ Cross��6~   ��5H      �� 5I      ._�5K      (� $
��Left=�6   $	��701��61   $  ��6=   $ 0.004,0.505&�6G   .��5L      �� -   5        $��LoadedImage��5L      $ Cross��6a   $��Center=�6p   $��Center=�6�   $
��Fill=�6�   5M      5N      �� 5P   
   -   5        $��SelectedColorBorder��5P      $��2��6,   $��54,4,101,33q�6<   
���   �$
}�True��6e   $��1��6y   ._�5Q      �� -   5        $��SelectedColorPanel��5Q      $��	10,0,0,10q�63   $	��210��6F   .+�5R      �� -   5         ��Name$ SelectedColorRectangle��5R      $	��155��6<   $	��193��6H   
���   �$ 0.5,0.5&�6d   z�5S      V� 5T      .~�5U      �� �� 5V      �� 5W      T� 5X       T� Y$	 150Q�61   5Y      5[      �� 5\      $	��210��6   $��89��6)   $ 0.5,0.5&�65   z�5]      V� 5^      .~�5_      �� �� 5`      �� 5a      T� 5b      $	 150Q�61   5c      .+�5e      �� -	   5         ��Name$ SelectedColorCode��5e       $��5q�6;   $��24(�6F   �� 5f      -
   5        $ SelectedColorRGB��5f       $��5q�6:   $��24(�6E   $	��200��6S   5g      5h      5i      5j      5k      