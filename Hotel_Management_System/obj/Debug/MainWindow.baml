   M S B A M L   `   `   `  ����  Hotel_Management_System(    "Hotel_Management_System.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   V RMaterialDesignThemes.Wpf, Version=2.6.0.1560, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   :d2http://schemas.microsoft.com/expression/blend/2008  5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -   5          �Name$  MainWindow1��5   	      MaterialDesignBody#���   5   	   $��Regular"�5      $��13(�5	      &   System.Windows.Media.TextOptions   TextFormattingMode$ Ideal=�5
         TextRenderingMode$
 Auto=�5        MaterialDesignPaper#���  5        MaterialDesignFont#���  5      $	��680��5      $
��1250��6'    � WindowStartupLocation$ CenterScreen=�64    � WindowStyle$
 None=�6p    � Icon$ Assets/home.png��6�    � 
ResizeMode$ NoResize=�6�    � WindowState$ 	Maximized=�6�   ��6Y   Z�  � 	Resources 5        MenuOpen	 �� TargetProperty
 �� 
TargetName9  3System.Windows.Media.Animation.EasingDoubleKeyFrame O� KeyTime O� Value  	MenuClose  
NotifyOpen  NotifyClose  	PopUpOpen  
PopUpClose��%  &	       &	 �     &	 �    &	 ^    &	 2    &	     �� 5   
   .��5      U� $	 (FrameworkElement.Width)�6,   $
 GridMenu��6a   .\�5        $ 0��6'   $ 60Q�63     5      $ 0:0:0.4��6'   $	 200Q�69   5      5      �� 5   
   .��5      U� $	 (FrameworkElement.Width)�6,   $
 GridMenu��6a   .\�5        $ 0��6'   $	 200Q�63     5      $ 0:0:0.4��6'   $ 60Q�69   5      5      �� 5    
   .��5!      U� $	 (FrameworkElement.Width)�5"      $
 NotificationMenu��5#      .\�5$        $ 0��6'   $ 0Q�63     5%      $ 0:0:0.4��6'   $	 300Q�69   5&      5'      �� 5)   
   .��5*      U� $	 (FrameworkElement.Width)�5+      $
 NotificationMenu��5,      .\�5-        $ 0��6'   $	 300Q�63     5.      $ 0:0:0.4��6'   $ 0Q�69   5/      50      �� 53   
   .��54      U� $	 (FrameworkElement.Height)�55      $
 PopUpWindow��56      .\�57        $ 0��6'   $ 0Q�63     58      $ 0:0:0.4��6'   $	 680Q�69   59      5:      �� 5<   
   .��5=      U� $	 (FrameworkElement.Height)�5>      $
 PopUpWindow��5?      .\�5@        $ 0��6'   $	 680Q�63     5A      $ 0:0:0.4��6'   $ 0Q�69   5B      5C      5D       � Triggers 5G      :� 5I   
    :� RoutedEvent$ ButtonBase.Click��6    :� 
SourceName$ ButtonOpenMenu��66   .[�5J      �� #��[ 6   5K      :� 5L   
   $ ButtonBase.Click��6   $ ButtonCloseMenu��66   .[�5M      �� #��[ 6   5N      :� 5Q   
   $ ButtonBase.Click��6   $ NotifiMenuOpenBtn��66   .[�5R      �� #��[ 6   5S      :� 5T   
   $ ButtonBase.Click��6   $ NotifiMenuCloseBtn��66   .[�5U      �� #��[ 6   5V      :� 5Y   
   $ ButtonBase.Click��6   $ HelpBtn��66   .[�5Z      �� #��[ 6   5[      :� 5_   
   $ ButtonBase.Click��6   $ PopUpWindowClose��66   .[�5`      �� #��[ 6   5a      .��5e      � .+�5j   
   )  #MaterialDesignThemes.Wpf.DrawerHost  $��Stretch=�5k      $��Stretch=�5l      $��0q�5m       	 MaterialDesignDivider#��� 	 5n      $��60 0 0 0q�69   .��5p      �  � RowDefinitions 5q      �� 5r      $��35 �6$   �� 5s      .+�5x      � -   5         �Name$ TopBar��5x      $��0��6'   .+�5|      #  MaterialDesignThemes.Wpf.Card  -   5        ���	#FF565699$��35��5|   A   $��5 0 0 0q�6�   $��-2 0 0 0q�6�   .��5~      �  � ColumnDefinitions 5      �� 5�   "   �� 5�   "   .+�5�      #  MaterialDesignThemes.Wpf.Chip  $��Nwike Victor��5�      $��0 0 0 0q�6   
�������   Icon 5�   "   �� 5�   &   $��Assets/me.jpg��5�      5�      �� 5�      $��1��6)    �� Orientation$ 
Horizontal=�69   $	��Top=�6R   $��35��6j   $��Right=�6v   .+�5�   "   �� -   5         ��Name$ dateText��5�   ,   
�������$��35��6Q    �� Padding$ 0q�6]   $��0 10 0 0q�6i   �� 5�   "   -   5         ��Name$ HelpBtn��5�   )    0
 ,MaterialDesignFloatingActionMiniAccentButton#��[
 6:   $��35��6�   $��35��6�   $��0q�6�    � ToolTip$
 Help��6�   ��6�   Z� ��6�   Z� .��5�   &   '  !MaterialDesignThemes.Wpf.PackIcon  �  �ControlzEx.PackIconBase`1[[MaterialDesignThemes.Wpf.PackIconKind, MaterialDesignThemes.Wpf, Version=2.6.0.1560, Culture=neutral, PublicKeyToken=null]]   Kind$ QuestionMark=�6>   5�   #   �� 5�   "   #��[
 6)   $��35��6o   $��35��6z   $��0q�6�   ��6�   Z� ��6�   Z� .��5�   &   '  !MaterialDesignThemes.Wpf.PopupBox     PlacementMode$ BottomAndAlignRightEdges=�6>      	StaysOpen .     PopupContent. 5�   *   �� $	��150��65   .+�5�   .   �� -   5        $ PopUpSettings��5�   5   .��5�   2   �� $ 
Horizontal=�6=   .+�5�   6     $ Settings=�6N   �� 5�   6   $��Settings��6@   $��5 0 0 0q�6P   5�   3   5�   /   �� 5�   .   .��5�   2   �� $ 
Horizontal=�6=   .+�5�   6     $ Account=�6N   �� 5�   6   $��Account��6@   $��5 0 0 0q�6O   5�   3   5�   /   �� 5�   .   -   5        $ AboutBtn��5�   5      OpenDrawerCommand#��Z 6G   "	  System.Windows.Controls.Dock 	  Right#��Z 5�   	   .��5�   2   �� $ 
Horizontal=�6=   .+�5�   6     $ About=�6N   �� 5�   6   $��About��6@   $��5 0 0 0q�6M   5�   3   5�   /   �� 5�   .   �� 5�   .   -   5        $ PopUpShutDown��5�   5   .��5�   2   �� $ 
Horizontal=�6=   .+�5�   6     $ Logout=�6N   �� 5�   6   $��LogOut��6@   $��5 0 0 0q�6N   5�   3   5�   /   5�   +   5�   '   5�   #   � 5�   "   .+�5�   &   �� -	   5        $ NotifiMenuOpenBtn��5�   -   $��35��6H   $��35��6S   $��0q�6_   #��[
 6k   $ Notifications��6�   ��6�   Z� ��6�   Z� .��5�   *   � .+�5�   .     $
 Bell=�6F   $��-8 0 0 0q�6R   %
  MaterialDesignThemes.Wpf.Badged
  5�   .     ControlzEx.BadgedEx   Badge$ 3��6D   $��0q�6N   $��10 1 0 0q�6Z   5�   +   5�   '   5�   #   �� 5�   "   -
   5        $ ButtonWindowMinimize��5�   )   #��[
 6G   $��35��6�   $��35��6�   $��0q�6�   $ Minimize Window��6   ��6�   Z� ��6�   Z� .��5�   &     $ WindowMinimize=�6>   $��0 8 0 0q�6T   5�   #   � 5�   "   .+�5�   &   �� -   5        $ ButtonRostoreWindow��5�   -   #��[
 6J   $��35��6�   $��35��6�   $��0q�6�   $ Restore Window��6�   $y�	Collapsed=�6�   ��6�   Z� ��6�   Z� .��5�   *     $ WindowRestore=�6B   5�   '   �� 5�   &   -   5        $ ButtonMaximizeWindow��5�   -   #��[
 6K   $��35��6�   $��35��6�   $��0q�6�   $ Maximize Window��6�   ��6�   Z� ��6�   Z� .��5�   *     $ WindowMaximize=�6B   5�   '   5�   #   �� 5�   "   -   5        $ ButtonClose��5�   )   #��[
 6>   $��35��6�   $��35��6�   $��0q�6�   $��Bottom=�6�   $ Close��6	  ��6�   Z� ��6�   Z� .��5�   &     $ Power=�6>   5�   #   5�      5�      5�      5�      � 5�      -   5        $ MainBody��5�      $��1��6)   
�������$��0 0 0 0q�6M   .+�5�        -   5           Name$  
MainCanvas��5�   d   $��3q�6*   
�������$��Stretch=�6H   $��2��6x   .��5�       � -   5        !  �Name$! GridPrincipal2��5�       "  � NavigationUIVisibility$" Hidden=�68   5�        5�      -   5        $  NotificationMenu��5�   *   $��0��6D   $��Stretch=�6N   $��Right=�6j   $��1��6�   .��5�      �  5�      �� 5�   "   $��50 �60   �� 5�   "   .+�5�      � $��50��6#   $��0��6/    5�   "   �� 5�   &   $��50 �67   �� 5�   &   .+�5�   "   �� -   5        $ NotifiMenuCloseBtn��5�   )   $��50��6E   $��50��6Q   $
��Left=�6\   #��[
 6w   $��0q�6�   
���������6�   Z� ��6�   Z� .��5�   &     $ Close=�6>   $��48��6K   $��40��6W   5�   #   �� 5   "    # MaterialDesignHeadlineTextBlock#��[ 6,   $��1��6e   $��8 0 0 0q�6u   $��Center=�6�   Notifications 🔻6�   5     � 5     $��1��6#   .+�5  "   �� ��5  &   �� 5  *   .R�5  .     $	��270��6B   $	��100��6N   .��5  2   � .+�5	  6   �� .+�5
  :     $ NotificationsActive=�6R   $��30��6m   $��30��6y   
��� ���$��2q�6�   �� 5  :   $-��'This is a sample text of a notification��6D   $��WrapWithOverflow=�6s   $��5 3 5 3q�6�   $��Center=�6�   $��18(�6�   5  7   5  3   5  /   5  +   .@�5  &     $	��290��6:   $	��100��6F   $��4q�6S   5  '     5  &   $	��290��6:   $	��100��6F   $��4q�6S   5  '     5  &   $	��290��6:   $	��100��6F   $��4q�6S   5  '     5  &   $	��290��6:   $	��100��6F   $��4q�6S   5  '     5  &   $	��290��6:   $	��100��6F   $��4q�6S   5  '     5   &   $	��290��6:   $	��100��6F   $��4q�6S   5"  '     5#  &   $	��290��6:   $	��100��6F   $��4q�6S   5%  '   5&  #   5(     5*     5+     5,     �� 5/      & "MaterialDesignFloatingActionButton#��[ 6   $ Quik Action��50     $��Bottom=�60   $��Right=�6K   $��	0,0,40,30q�6g   $��1��6z   #��Z 6�   
# 	  Top#��Z# 51  	   .��53       $
 Plus=�6.   $��24��6:   $��24��6F   54     56     $   RightDrawerContent$ 59     �� 5:     $��16q�5;     .+�5<     �� $��4q�5=  	   $��Center=�5>  	   ABOUT THIS SOFTWARE5@     5C     %   TopDrawerContent% 5F     �� 5G     $��16q�5H     $��Center=�5I     $ 
Horizontal=�5J     .+�5K     �� $��4q�5L  	   $��Center=�5M  	   
TOP BANANA5O     �� 5P     &   CloseDrawerCommand#��Z& 5Q  	     MaterialDesignFlatButton#���  5R  	   $��4q�5S  	   $��Center=�5T  	   .��6$   	CLOSE ALL5V     �� 5W     #��Z& 5X  	   #��Z# 5Y  	   #���  5Z  	   $��4q�5[  	   $��Center=�5\  	   .��6$   
CLOSE THIS5^     5_     5c     � 5f  
   .+�5i       -   5        $  GridMenu��5i  "   $��60��64   ���	#FF19739C$��Stretch=�6V   $
��Left=�6r   .��5k     �� -   5        ' ��Name$' SideBarStack��5k     .+�5l     � $��40��6   ���	#FF19739C.+�5m     �� -   5        $ ButtonCloseMenu��5m  !   $��35��6:   $��35��6E   $	��Top=�6~   $��Right=�6�   #��[
 6�   $y�	Collapsed=�6�   $��0 0 10 0q�6  ��6Q   Z� ��6g   Z� .��5n       
�������$ 	ArrowLeft=�6I   $��35��6Z   $��35��6e   5o     �� 5p     -   5        $ ButtonOpenMenu��5p  !   $��35��69   $��35��6D   $	��Top=�6}   #��[
 6�   $��	10 0 12 0q�6�   $��Right=�6  ��6P   Z� ��6f   Z� .��5q       
�������$
 Menu=�6I   $��35��6U   $��35��6`   5r     5s     � 5v     .+�5x     ?  9MaterialDesignThemes.Wpf.Transitions.TransitioningContent  -   5        (  Name$( TrasitioningContentSlide��5x  >   C  =MaterialDesignThemes.Wpf.Transitions.TransitioningContentBase)   OpeningEffect) 6`   D  >MaterialDesignThemes.Wpf.Transitions.TransitionEffectExtension  *SlideInFromLeft+*   Duration$* 0:0:0.4X�.��5y     � -   5        $ 
GridCursor��5y  #   ���	#FFA8C5DC$��6��6N   $��60��6X   $
��Left=�6e   $	��Top=�6�   $��0 0 0 0q�6�   5z     �� 5}     -   5        + ��Name$+ ListViewMenu��5}  #   $��Disabled=�69   
�������, �� SelectedIndex$, 0��6�   .@�5~     �� $��60��6+   .��5  "   �� $ 
Horizontal=�6-   $��10 0 0 0q�6F   .+�5�  &     $
 Home=�6>   $��25��6J   $��25��6U   $��Center=�6a   �� 5�  &   $
��HOME��60   $��Center=�6<   $
��Left=�6W   $��20 10q�6r   5�  #   5�     �� 5�     $��60��6+   .��5�  "   �� $ 
Horizontal=�6-   $��10 0 0 0q�6F   .+�5�  &     $ Account=�6>   $��25��6M   $��25��6X   $��Center=�6d   �� 5�  &   $��COSTUMER REGISTER��60   $��Center=�6I   $
��Left=�6d   $��20 10q�6   5�  #   5�     �� 5�     $��60��6+   .��5�  "   �� $ 
Horizontal=�6-   $��10 0 0 0q�6F   .+�5�  &     $	 Bed=�6>   $��25��6I   $��25��6T   $��Center=�6`   �� 5�  &   $��ROOM BOOKING��60   $��Center=�6D   $
��Left=�6_   $��20 10q�6z   5�  #   5�     �� 5�     $��60��6+   .��5�  "   �� $ 
Horizontal=�6-   $��10 0 0 0q�6F   .+�5�  &     $ 
Restaurant=�6>   $��25��6P   $��25��6[   $��Center=�6g   �� 5�  &   $��RESTAURANT POS��60   $��Center=�6F   $
��Left=�6a   $��20 10q�6|   5�  #   5�     �� 5�     $��60��6+   .��5�  "   �� $ 
Horizontal=�6-   $��10 0 0 0q�6F   .+�5�  &     $
 Food=�6>   $��25��6J   $��25��6U   $��Center=�6a   �� 5�  &   $��MEAL REQUEST��60   $��Center=�6D   $
��Left=�6_   $��20 10q�6z   5�  #   5�     �� 5�     $��60��6+   .��5�  "   �� $ 
Horizontal=�6-   $��10 0 0 0q�6F   .+�5�  &     $ ClothesHanger=�6>   $��25��6S   $��25��6^   $��Center=�6j   �� 5�  &   $��LAUNDRY SERVICE��60   $��Center=�6G   $
��Left=�6b   $��20 10q�6}   5�  #   5�     �� 5�     $��60��6+   .��5�  "   �� $ 
Horizontal=�6-   $��10 0 0 0q�6F   .+�5�  &     $ Arena=�6>   $��25��6K   $��25��6V   $��Center=�6b   �� 5�  &   $��HALL BOOKING��60   $��Center=�6D   $
��Left=�6_   $��20 10q�6z   5�  #   5�     �� 5�     $��60��6+   .��5�  "   �� $ 
Horizontal=�6-   $��10 0 0 0q�6F   .+�5�  &     $ 	Landscape=�6>   $��25��6O   $��25��6Z   $��Center=�6f   �� 5�  &   $��GARDEN BOOKING��60   $��Center=�6F   $
��Left=�6a   $��20 10q�6|   5�  #   5�     �� 5�     $��60��6+   .��5�  "   �� $ 
Horizontal=�6-   $��10 0 0 0q�6F   .+�5�  &     $	 Car=�6>   $��25��6I   $��25��6T   $��Center=�6`   �� 5�  &   $��
CAR RENTAL��60   $��Center=�6B   $
��Left=�6]   $��20 10q�6x   5�  #   5�     �� 5�     $��60��6+   .��5�  "   �� $ 
Horizontal=�6-   $��10 0 0 0q�6F   .+�5�  &     $ Settings=�6>   $��25��6N   $��25��6Y   $��Center=�6e   �� 5�  &   $��SETTINGS��60   $��Center=�6@   $
��Left=�6[   $��20 10q�6v   5�  #   5�     5�     5�     5�     5�       5�     -   5        $  PopUpWindow��5�  "   $��Bottom=�67   $��Center=�6R   $��0��6o   $	��650��6z   
�������+  %MaterialDesignThemes.Wpf.ShadowAssist-   ShadowDepth$- Depth5=�6�   .   Darken. . /   ShadowEdges$	/ All=�6�   .��5�     �  5�     �� 5�     $��50 �6(   �� 5�     .+�5�     � $��0��6   .+�5�     �� #��[ 6$   $��1��6]   $��8 0 0 0q�6m   $��Center=�6~   $
��Left=�6�   Help6�   �� 5�     -   5        $ PopUpWindowClose��5�  !   $��50��6;   $��50��6G   $��Right=�6R   #��[
 6n   $��0q�6�   
�������$ Close��6  ��6�   Z� ��6�   Z� .��5�       $ Close=�66   $��40��6C   $��40��6O   5�     5�     �� 5�     $��1��6#   .��5�     �� .+�5�         MaterialDesignBackground#���  5�     .��5�     �� .+�5�  "   9� $��Stretch=�5�     $��Expander Example 2a��5�     .��5�  &   �� $ Vertical=�5�  	   #���   5�  	   $��
24,8,24,16q�5�  	   .+�5�  *   �� $��Your Content��5�     �� 5�  *   0 J� Opacity$	0 .68Q�5�     $����Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.��5�     $
��Wrap=�5�     5�  '   5�  #   �� 5�  "   #��� 	 5�     $��1��5�     $��Stretch=�5�     1 J� SnapsToDevicePixels1 . 5�     9� 5�  "   $��Stretch=�5�     $��Expander Example 2b��5�     .��5�  &   �� $ Vertical=�5�  	   #���   5�  	   $��
24,8,24,16q�5�  	   .+�5�  *   �� $��Your Content��5�     �� 5�  *   $	0 .68Q�5�     $����Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.��5�     $
��Wrap=�5�     5�  '   5�  #   �� 5�  "   #��� 	 5�     $��1��5�     $��Stretch=�5�     1 . 5�     9� 5�  "   $��Stretch=�5�     $��Expander Example 2c��5�     .��5�  &   �� $ Vertical=�5   	   #���   5  	   $��
24,8,24,16q�5  	   .+�5  *   �� $��Your Content��5     �� 5  *   $	0 .68Q�5     $����Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.��5     $
��Wrap=�5     5	  '   5
  #   5     5     5     5     5     5     5     5     5     