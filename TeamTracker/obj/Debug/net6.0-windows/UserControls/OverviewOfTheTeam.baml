   M S B A M L   `   `   `  ����F  BTeamTracker, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullC&clr-namespace:TeamTracker.UserControlsTeamTracker.UserControls  5      ?$clr-namespace:TeamTracker.PropertiesTeamTracker.Properties  5      0    *TeamTracker.UserControls.OverviewOfTheTeam   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      8local&clr-namespace:TeamTracker.UserControls     5      6props$clr-namespace:TeamTracker.Properties     5      
�������  � 	Resources  5
       �� 
TargetType �� Property �� Value   GlowingLabel3  -System.Windows.Media.Effects.DropShadowEffect   ShadowDepth   Color   
BlurRadius �� Triggers :� RoutedEvent	 �� TargetProperty	
 �� To g� Duration g� RepeatBehavior g� AutoReverse��%�  '��       &	  �     �� 5   
   " ��6   .�5      ��  � ��$ Center=�6;   �� 5       � ��
 �����6+   �� 5       � �� �#1B262C6+   �� 5       � ��$ 15(�6)   5      �� 5   
   " ��6%   .�5      ��  � ��
 �����6+   �� 5       � �� �#1B262C6+   �� 5       � ��$ 15(�6)   �� 5       �@J�Effect 5        5      $ 0Q�6'   $ 	Turquoise��67   $ 10Q�6I   5       5      :� 5      $ Loaded��6   .[�5      �� .��5      �� .��5      �� $*	 $(Foreground).(SolidColorBrush.Color)�6-   
 	Turquoise5    )   $ 0:0:1D�68   $ Forever��6I   $
 True��6b   5!      5"      5#      5%      5)      .��5,      �   BackgroundGridStyle#��[ 6    � RowDefinitions 5.      �� 5/      $��* �6    �� 50      $
��0.5* �6    �� 51      $��* �6    �� 52      $��9* �6    �� 53      $��* �6     � ColumnDefinitions 56      �� 57      $��* �6#   �� 58      $��3* �6#   �� 59      $��* �6#   �� 5:      $��3* �6#   �� 5;      $��* �6#   .+�5>   
   �� &    TeamTracker.Properties.Resources   favoriteTeam#��Z 6   $��0��5?      $��1��5@      $��0,20,0,0q�5A      �� 5B   
      oppositeTeam#��Z 6   $��0��5C      $��3��5D      $��0,20,0,0q�5E      �� 5F   
      score#��Z 6   $��0��5G      $��2��5H      $��0,20,0,0q�5I      �� 5L   
   -   5         ��Name$ 	lblResult��5O      $
�� 1:1��5L      $��1��5M      $��2��5N      $��Center=�5P      #��[  5Q      �� 5W   
   -   5         ��Name$ cbFavoriteTeam��5Z      $��1��5W      $��1��5X      $��Stretch=�5Y      5[      �� 5_   
   -   5        $ cbOppositeTeam��5b      $��1��5_      $��3��5`      $��Stretch=�5a      5c      �� 5f   
   -   5         ��Name$ btnViewFavoriteTeamInfo��5i      $��2��5g      $��1��5h         viewInfo#��Z 5j      $
��0,10q�5k        CustomButtonStyle#��[ 5l      5m      �� 5n   
   -   5        $ btnViewOppositeTeamInfo��5q      $��2��5o      $��3��5p      #��Z 5r      $
��0,10q�5s      #��[ 5t      5u      �� 5v   
   $��3��5w      $��1��5x      $
��Auto=�5y      .��5z      �� -   5         ��Name$ lbFavoriteTeam��5{      $��Stretch=�5|      $��Stretch=�5}      $
��Auto��5~       �� DisplayMemberPath$
 Name��5      
����������#0F4C755�      5�      �� 5�   
   $��3��5�      $��3��5�      $
��Auto=�5�      .��5�      �� -   5        $ lbOppositeTeam��5�      $��Stretch=�5�      $��Stretch=�5�      $
 Name��5�      
����������#0F4C755�      5�      �� 5�   
   -   5        $��4��5�      $��1��5�         back#��Z 5�      $
��0,10q�5�      #��[ 5�      5�      �� 5�   
   -	   5        $��4��5�      $��3��5�         next#��Z 5�      $
��0,10q�5�      #��[ 5�      5�      5�      5�      