   M S B A M L   `   `   `  ����U  QKinectKickboxingBVversion1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullG(clr-namespace:KinectKickboxingBVversion1KinectKickboxingBVversion1  5   	   +    %KinectKickboxingBVversion1.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   \ XMicrosoft.Kinect.Toolkit.Controls, Version=0.0.0.0, Culture=neutral, PublicKeyToken=nullS OMicrosoft.Kinect.Toolkit, Version=1.8.0.0, Culture=neutral, PublicKeyToken=null2k(http://schemas.microsoft.com/kinect/2013   5   	   6local(clr-namespace:KinectKickboxingBVversion1   5   	   -   5        $��ControlsBasicsWindow��5	   	     � Title$  
MainWindow��5   	   $��377.612��5   	   $��637.313��5   	    � 	Resources 5         KinectHoverButtonStyle �� 
TargetType2  ,KinectKickboxingBVversion1.KinectHoverButton �� Property �� Value �� 
TargetType �� Triggers P� Property P� Value��%&  &	        �� 5   
   "  6/   .�5      ��  � ��
 �����6+   �� 5       � ��
 �����6,   �� 5       � ��$ 0q�60   6<   �� 5       � ��
 �����6;   �� 5       � �� 5      �� 5      "  6&   .R�5      � $��Stretch=�6   $��Stretch=�6=   #��z��6Y   #��z��6�   #��z��6�   .+�5      �� #��z��6%   #��z��6Y   ._�5   "   �� $��Stretch=�63   $��Stretch=�6Q   #��z��6m   6�   5      5      5      5       5      P� 5        � {� .  . �5!      ��  � ��
 �����63   �� 5"       � ��
 �����64   �� 5#       � ��
 ���� 6I   5$      P� 5%       �@ IsHandPointerOver . . �5&      ��  � �� �#5A5B5B63   �� 5'       � ��
 �����63   5(      5*      5.      .��5/      � -   5        	 �Name$	 MenuFrm��5/      
 � ColumnDefinitions
 50   
   �� 51      $	��45* �6   �� 52      $
��472* �6   ��54   
   �� 55       �� ImageSource$ Images/BoxingBags.jpg��6    �� Opacity$	 0.3Q�6=   .+�58   
   �� -   5        $��KinectVideo��58      $��200,20,200,190q�6#   $��1��6;   � 5:   
   $��2��6    � RowDefinitions 5;      �� 5<      $
��Auto �6    �� 5=      $��* �6    .+�5@      � $��0��6   $��
10 0 10 20q�6!   .+�5B      8  2Microsoft.Kinect.Toolkit.Controls.KinectUserViewer  $	��100��6f   $��10,30,490,10q�6s   $	��Top=�6�   4  .Microsoft.Kinect.Toolkit.Controls.KinectRegion   KinectRegion 6%   ��  �� ElementName$ kinectRegion��6�   4  .Microsoft.Kinect.Toolkit.KinectSensorChooserUI  5C      -   5        $��sensorChooserUi��5C   _   $��Center=�6*   $	��Top=�6G   6_   5E      5F        5H   
   -   5          Name$ kinectRegion��5H      $��2��6/   .��5J      � -   5        $	 kinectRegionGrid��5J      $��10,20,10,20q�6-    5K      �� 5L      $��* �6$   �� 5M      $	��170 �6$   .+�5R      �� � 5T      $��1��6   $��Stretch=�6$   $��Stretch=�6B   $��0, 10, 0, 10q�6^   
 5U      �� 5V      $��* �6+   �� 5W      $��10 �6+   �� 5X      $��* �6+   .+�5Z      8  2Microsoft.Kinect.Toolkit.Controls.KinectTileButton  -   5        $��0��5Z   )      Label$ Training��69   $
��Auto��6d   $
��Auto��6r     5[      -   5        $��2��5[   )   $ Conditioning��69   $
��Auto��6l   $
��Auto��6z   5\      5]      5^      5a      5b      