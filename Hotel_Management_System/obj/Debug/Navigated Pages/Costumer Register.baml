   M S B A M L   `   `   `  ����R  NHotel_Management_System, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullA%clr-namespace:Hotel_Management_SystemHotel_Management_System  5      /    )Hotel_Management_System.Costumer_Register   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      7local%clr-namespace:Hotel_Management_System     5      V RMaterialDesignThemes.Wpf, Version=2.6.0.1560, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5	      -   5           MaterialDesignBody#���   5   	   $��Regular"�5      $��13(�5      &   System.Windows.Media.TextOptions    TextFormattingMode$  Ideal=�5         TextRenderingMode$
 Auto=�5        MaterialDesignPaper#���  5        MaterialDesignFont#���  5       � 	Resources 5        costumerRegisterViewSource  
NotifyOpen �� TargetProperty �� 
TargetName9  3System.Windows.Media.Animation.EasingDoubleKeyFrame O� KeyTime O� Value��%�   &	       &	      �� 5   
   6   �� 5   
   .��5      U� $ (FrameworkElement.Height)�6,   $ NotifySnack��6b   .\�5        $ 0��6'   $ 50Q�63     5      $ 0:0:0.4��6'   $ 0Q�69   5      5       5!       � Triggers 5$      :� 5%   
    :� RoutedEvent$ ButtonBase.Click��6   	 :� 
SourceName$	 BtSave��66   .[�5&      �� #��[ 6   5'      .��5)      � .+�5*   
   ?  9MaterialDesignThemes.Wpf.Transitions.TransitioningContent  -   5        
  Name$
 TrasitioningContentSlide��5*   .   C  =MaterialDesignThemes.Wpf.Transitions.TransitioningContentBase   OpeningEffect 6P   D  >MaterialDesignThemes.Wpf.Transitions.TransitionEffectExtension  *SlideInFromLeft+   Duration$ 0:0:0.8X�.��5,      �  � RowDefinitions 5.      �� 5/      $
��Auto �6$   �� 50      .+�57      � $��1��6    � ColumnDefinitions 58      �� 59      $
��Auto �6+   �� 5:      .+�5>      #  MaterialDesignThemes.Wpf.Card  -   5          Name$ RegPanel��5>   *   $��0��6<   $��4 0 4 4q�6L   $��Stretch=�6]   $��Stretch=�6y   $	��300��6�   .��5@      �  � DataContext# [ 6   .+�5C      � -   5         �Name$ grid2��5C      $��Stretch=�6.   $	��Top=�6L   $��0 5 4 0q�6d    5D      �� 5E   "   $	��120 �63   �� 5F   "    5H      �� 5I   "   $
��Auto �60   �� 5J   "   $
��Auto �60   �� 5K   "   $
��Auto �60   �� 5L   "   $
��Auto �60   �� 5M   "   $
��Auto �60   �� 5N   "   $
��Auto �60   �� 5O   "   $
��Auto �60   �� 5P   "   $	��120 �60   �� 5Q   "   $
��Auto �60   �� 5R   "   $
��Auto �60   �� 5S   "   $
��Auto �60   .+�5V   "   ��  # MaterialDesignHeadlineTextBlock#��[ 6,   $��0��6e   $��2��6r   Costumer Register6�   �� 5X      $��First Name:��6$   $��0��6:   $��3q�6J   $��1��6U   $��Bottom=�6b   $��Bottom=�6}   $��Stretch=�6�   �� 5Y      -   5         ��Name$ firstNameTextBox��5Y   &   $��1��6@   $��24��6P   $��1��6\   )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ 	FirstName��6i   $��Center=�6�   $��Stretch=�6  $��Stretch=�64  $�� 0 0 3 0q�6R  ��6�   �� *	FirstName+ �� Mode$ TwoWay=� �� NotifyOnValidationError .  �� ValidatesOnExceptions . 6R  �� 5[      $��
Last Name:��6$   $��0��69   $��3q�6I   $��2��6T   $��Bottom=�6a   �� 5\   "   -   5        $ lastNameTextBox��5\   *   $ LastName��6C   $��1��6m   $��2��6}   $��Center=�6�   $�� 0 0 3 0q�6  ��6�   �� *
LastName+$ TwoWay=� .  . 6  �� 5^      $��Gender:��6$   $��0��66   $��3q�6F   $��3��6Q   $��Bottom=�6^   $��Bottom=�6y   $��Stretch=�6�   �� 5_   "   -   5         ��Name$ genderComboBox��5_   p   $��3��6+   $��1��68   $ Gender��6H   $�� 0 0 3 0q�6�    �� Text 6�   �� *Gender+.@�5`   "   �� $
��Male��6/   �� 5a   "   $��Female��6/   5b      �� 5f      $��Phone Number:��6$   $��0��6<   $��3q�6L   $��4��6W   $��Bottom=�6d   �� 5g   "   -   5        $ phoneNumberTextBox1��5g   *   $ Phone Number��6G   $��1��6u   $��4��6�   $��Center=�6�   $�� 0 0 3 0q�6  ��6�   �� *TellNo+$ TwoWay=� .  . 6  �� 5i      $��Occupation:��6$   $��0��6:   $��3q�6J   $��5��6U   $��Bottom=�6b   �� 5j   "   -	   5        $ occupationTextBox1��5j   *   $ 
Occupation��6F   $��1��6r   $��5��6�   $��Center=�6�   $�� 0 0 3 0q�6  ��6�   �� *
Occupation+$ TwoWay=� .  . 6  �� 5l      $��Home Address:��6$   $��0��6<   $��3q�6L   $��6��6W   $��Bottom=�6d   �� 5m   "   -
   5        $ address1TextBox��5m   *   $ Home Address��6C   $��1��6q   $��6��6�   $�� 0 0 3 0q�6�    �� TextWrapping$ WrapWithOverflow=�6  ��6�   �� *
Address1+$ TwoWay=� .  . 6  �� 5o      $��Next Of Kin:��6$   $��0��6;   $��3q�6K   $��7��6V   $��Center=�6c   �� 5p   "    �� Orientation$ Vertical=�6-   $��7��6D   $��1��6Q   .+�5q   &   �� -   5        $ nextOfKinName��5q   .    % !MaterialDesignFloatingHintTextBox#��[ 6E   $��1��6�   $��4��6�   $ Next of Kin Name��6  $�� 0 0 3 0q�64  ��6�   �� *NxtOfKinName+$ TwoWay=� .  . 64  �� 5r   "   �� 5s   &   -   5        $ nextOfKinPhone��5s   .   #��[ 6F   $��1��6�   $��4��6�   $ Next of Kin Number��6  $�� 0 0 3 0q�69  ��6�   �� *NxtOfKinNumber+$ TwoWay=� .  . 69  �� 5t   "   �� 5u   &   -   5        $ nextOfKinRelation��5u   /    & "MaterialDesignFloatingHintComboBox#��[ 6J   $��1��6�   $��4��6�   $# RelationShip with Next of Kin��6  $�� 0 0 3 0q�6O   6�   �� *NxtOfKinRelationship+$ TwoWay=� .  . .@�5v   &   �� $��Brother��63   �� 5w   &   $��Sister��63   �� 5x   &   $
��Wife��63   �� 5y   &   $��Husband��63   �� 5z   &   $��Friend��63   �� 5{   &   $��Family Member��63   �� 5|   &   $��Coleague��63   5}   #   5~      �� 5�      $��0��6)   $��8��69   $ Vertical=�6F   .+�5�   "   �� $��Picture:��6(   $��3q�6;   $��Center=�6F   �� 5�   "   -   5         ��Name$ BrowsePicture��5�   )   $��12 10q�6@   $��Browse��6O   6`   5�      �� 5�   "   -   5         ��Name$ pictureImage��5�   (   $��1��6>   $��23��6N   $��10,48,96,48q�6Z   $��8��6o   ��6|   �� *	Picture+�� 5�   "   $��
Address 2:��6(   $��0��6=   $��3q�6M   $��9��6X   $��Bottom=�6e   �� 5�      -   5        $ address2TextBox��5�   &   $��1��6?   $��9��6O   ��6\   �� *
Address2+$ TwoWay=� .  . 5�      5�      5�        5�      $��4 0 4 4q�6&   $��1��67   $��Stretch=�6G   .��5�      � # [ 6    5�      �� 5�      $��40 �6,   �� 5�      .+�5�      � -   5        $��0��5�       $�� 3 3 3 0q�6-   .+�5�      �� -   5        $ 	SearchBox��5�   &   $ SEARCH TABLE��69   #��[ 6g   $��Champagne & Limousines)�6�   $��18(�6�   6�   5�      &   System.Windows.Controls.DataGrid  5�      -   5          Name$ costumerRegisterDataGrid1��5�   �   -	  'MaterialDesignThemes.Wpf.DataGridAssist 	  CellPadding$ 5q�6#    	  ColumnHeaderPadding$ 4q�6Q       AutoGenerateColumns  .  !   EnableRowVirtualization! . $��1��6  $" �� IsSynchronizedWithCurrentItem$
" TrueY�6$  $��1q�6I  $��Stretch=�6�  $��Stretch=�6�  ��6�   �� #   Columns# 5�      0
  *System.Windows.Controls.DataGridTextColumn
  5�   &   -   5        clientIDColumn1��,  &System.Windows.Controls.DataGridColumn$   Header$$ 	Client ID��5�   o   %   Width5  /System.Windows.Controls.DataGridLengthConverter$% SizeToHeader 6�   1  +System.Windows.Controls.DataGridBoundColumn&   Binding& 6R   �� *
ClientID+6�   
  5�   "   -   5        firstNameColumn1��$$ 
First Name��5�   m   $% SizeToHeader 6�   & 6O   �� *	FirstName+6�   
  5�   "   -   5        lastNameColumn1��$$ 	Last Name��5�   k   $% SizeToHeader 6~   & 6N   �� *
LastName+6~   
  5�   "   -   5        genderColumn1��$$ Gender��5�   g   $% SizeToHeader 6w   & 6L   �� *Gender+6w   
  5�   "   -   5        tellNoColumn1��$$ Phone Number��5�   g   $% SizeToHeader 6}   & 6L   �� *TellNo+6}   
  5�   "   -   5        occupationColumn1��$$ 
Occupation��5�   o   $% SizeToHeader 6�   & 6P   �� *
Occupation+6�   
  5�   "   -   5        address1Column1��$$ Home Address��5�   k   $% SizeToHeader 6�   & 6N   �� *
Address1+6�   
  5�   "   -   5        nxtOfKinNameColumn1��$$ Next of Kin��5�   s   $% SizeToHeader 6�   & 6R   �� *NxtOfKinName+6�   
  5�   "   -   5        nxtOfKinNumberColumn1��$$ NxtOfKinNumber��5�   w   $% SizeToHeader 6�   & 6T   �� *NxtOfKinNumber+6�   
  5�   "   -   5        nxtOfKinRelationColumn1��$$ NxtOfKinRelationship��5�      $% SizeToHeader 6�   & 6V   �� *NxtOfKinRelationship+6�   
  5�   "   -   5        dateRegisteredColumn1��$$ Date Registered��5�   w   $% SizeToHeader 6�   & 6T   �� *DateRegistered+6�   
  5�   "   -   5        address2Column1��$$ 	Address 2��5�   k   $% SizeToHeader 6~   & 6N   �� *
Address2+6~   4  .System.Windows.Controls.DataGridTemplateColumn  5�   "   -    5        pictureColumn1��$$ Picture��5�   Q   $% SizeToHeader 6b   '   CellTemplate' 5�   &   �� 5�   *   .R�5�   .   �� ��64   �� *	Picture+5�   +   5�   #   5�      5�      5�      5�      � 5�      $��0��6   .+�5�        $��40��6*   .��5�      � .+�5�      �� $ 
Horizontal=�6)   .+�5�   "   �� -!   5        $ BtNew��5�   )   $��3 0 10 0q�69   ( � ToolTip$( Register new Costumer��6_   .��5�   &   �� $ 
Horizontal=�61   .+�5�   *   '  !MaterialDesignThemes.Wpf.PackIcon  �  �ControlzEx.PackIconBase`1[[MaterialDesignThemes.Wpf.PackIconKind, MaterialDesignThemes.Wpf, Version=2.6.0.1560, Culture=neutral, PublicKeyToken=null]])   Kind$) NewBox=�6B   �� 5�   *   $	��New��64   $��2 0 0 0q�6?   5�   '   5�   #   �� 5�   "   -"   5        $ BtCancel��5�   )   $��0 0 10 0q�6;   $( Disable Panel��6d   .��5�   &   �� $ 
Horizontal=�61   .+�5�   *     $) Cancel=�6B   �� 5�   *   $��Cancel��64   $��2 0 0 0q�6B   5�   '   5�   #   �� 5�   "   -#   5        $ BtEdit��5�   )   $��0 0 10 0q�69   $$( Edit selected Costumer details��6`   .��5�   &   �� $ 
Horizontal=�61   .+�5�   *     $
) Edit=�6B   �� 5�   *   $
��Edit��64   $��2 0 0 0q�6@   5�   '   5�   #   �� 5�   "   -$   5        $ BtSave��5�   )   $��0 0 10 0q�69   $( Save new costumer details��6`   .��5�   &   �� $ 
Horizontal=�61   .+�5�   *     $) ContentSave=�6B   �� 5�   *   $
��Save��64   $��2 0 0 0q�6@   5�   '   5�   #   �� 5�   "   -%   5        $ BtDelete��5�   )   $��0 0 10 0q�6;   $&(  Delete selected costumer details��6d   .��5�   &   �� $ 
Horizontal=�61   .+�5�   *     $) Delete=�6B   �� 5�   *   $��Delete��64   $��2 0 0 0q�6B   5�   '   5�   #   �� 5�   "   -&   5        $ BtUpdate��5�   )   $��0 0 10 0q�6;   $%( Update current costumer details��6d   .��5�   &   �� $ 
Horizontal=�61   .+�5�   *     $) Update=�6B   �� 5�   *   $��Update��64   $��2 0 0 0q�6B   5�   '   5�   #   �� 5�   "   -'   5        $ Previuos��5�   ;   $��0 0 10 0q�6)   $( 	Scroll up��6d   .��5�   &     $) ArrowUp=�6>   5�   #   �� 5�   "   -(   5        $
 Next��5�   ;   $��0 0 10 0q�6)   $( Scroll downs��6\   .��5�   &     $) 	ArrowDown=�6>   5   #   �� 5  "   -)   5        $ RefreshButton��5  )   $( Refresh Table��6\   .��5  &     $) Refresh=�6>   5  #   5     5     5     5     5
     5     '  !MaterialDesignThemes.Wpf.Snackbar  5  
   -*   5        *  Name$* NotifySnack��5  "   +   IsActive+ .  ,   Message., 5     .  (MaterialDesignThemes.Wpf.SnackbarMessage  $��Data Saved Successfully!��5     -   ActionContent$- ACCENT��5     5     5     5     