   M S B A M L   `   `   `  ����A  =Tetris, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:TetrisTetris  5   	       Tetris.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   &localclr-namespace:Tetris     5   	   -   5          � Title$  Tetris��5   	   $	��600��6   $	��800��6%   $	��600��5	   	   $	��600��6   
�������$��Segoe UI Light)�5   	   $��28(�6%   .��5      �  � RowDefinitions 5   
   �� 5      $
��auto �6   �� 5      $��* �6    � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5      $
��auto �6   �� 5      $��* �6   ��5   
   �� 5       �� ImageSource$ Assets/Background.PNG��6   .+�5   
   (� $��1��6   $��1��5      $��0,0,0,20q�5      .��5       �� -   5         ��Name$ 
GameCanvas��5       
���   �$	��250��5"      $	��510��5#      $
}�True��5$      5%      5&      �� 5(   
   -   5         ��Name$ 	ScoreText��5(      $��0��5)      $��1��5*      $��Score: ��5+      $
��0,10q�5,       �� TextAlignment$ Center=�5-      �� 5/   
   $��1��6   $��2��50      $��Center=�51      $
��Left=�52      .+�53      �� $
��Next��6   $ Center=�54      �� 55      -   5         ��Name$ 	NextImage��55      $��20q�56      $	��125��57      58      � 5:   
   -   5         �Name$ GameOverManu��5:      ���	#CC000000$��2��5<      $��3��5=      $y�Hidden=�5>      .+�5@      �� $��Center=�6   $��Center=�5A      .+�5B      �� $��	Game Over��6   $��48(�5C      $ Center=�5D      �� 5F      -   5        $ FinalScoreText��5F      $��Score��5G      $��36(�5H      $ Center=�5I      �� 5K      -   5        $��
Play Again��5K      
����İ�$��0,20,0,0q�5M      $��5q�5N      5O      5Q      5R      5Y      5Z      