   M S B A M L   `   `   `  ?????  ;dogs, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:dogsdogs  5   	       dogs.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   $localclr-namespace:dogs     5   	   ] YXceed.Wpf.Toolkit.NET5, Version=4.5.0.0, Culture=neutral, PublicKeyToken=3e4669d2f30244f47toolkit)http://schemas.xceed.com/wpf/xaml/toolkit  5   	     ? Title$  
MainWindow??5	   	   $	??350??6   $	??800??6)   .??5      ? $??10q?6    ? RowDefinitions 5   
   ?? 5      $
??0.3* ?6   6,   ?? 5      6   ?? 5      $
??0.3* ?6   6,    ? ColumnDefinitions 5   
   ?? 5      $
??0.7* ?6   6.   ?? 5      6!   ?? 5      $
??0.7* ?6   6.   .+?5   
   ?? $??Minimalny zakłąd: 5zł??6   $??0??60   $??0??6=   $
??Left=?6M   $??Bottom=?6h   $??18(?6?   $
??Bold"?6?   ?? 5   
   $??Zakłady??6   $??0??6"   $??1??6/   $
??Left=?6?   $??Bottom=?6Z   $??18(?6u   $
??Bold"?6?   ?? 5   
   $??0??6   $??1??6%   $??10q?62   $??Center=?6>   .+?5      	? -   5         	?Name$ 
janekRadio??5   e    	? 	GroupName$
 name??6   $
??0,10q?6+   $??16(?69   6e   	? 5      -   5        $ bartekRadio??5   e   $
 name??6   $
??0,10q?6+   $??16(?69   6e   	? 5      -   5        $ 
antekRadio??5   e   $
 name??6   $
??0,10q?6+   $??16(?69   6e   5       ?? 5"   
   $??1??6   $??1??6%   $??10q?62   $??Center=?6>   .+?5#      ?? -   5         ??Name$ janekTextBox??5#      $
??0,10q?6,   $??16(?6:   ${?False??6I   ?? 5$      -   5        $ bartekTextBox??5$      $
??0,10q?6-   $??16(?6;   ${?False??6I   ?? 5%      -   5        $ antekTextBox??5%      $
??0,10q?6,   $??16(?6:   ${?False??6H   5&      ?? 5(   
   -   5         ??Name$ 
gameButton??5(   ?   $??START!??6   $??2??6#   $??1??63   $??20,35q?6@   $??20(?6O   $??Medium"?6]   ${?False??6?   ?? 5*   
   $??2??6   $??2??6"   $??5q?66   $??Center=?6A    ?? Orientation$ 
Horizontal=?6\   .+?5+      ?? -   5         ??Name$ personLable??5+   O   $??16(?6   $
??20,0q?6&   $
??Left=?64   6O   ?? 5,      -	   5        $??
nie stawia??5,      $	??8,2q?6*   
?????? $
??10,0q?6Q   6_   %  Xceed.Wpf.Toolkit.IntegerUpDown  5-      -
   5        	  Name$	 betInput??5-   R   ?  ?Xceed.Wpf.Toolkit.Primitives.UpDownBase`1[[System.Nullable`1[[System.Int32, System.Runtime, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], System.Runtime, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]]
   Minimum
 56$      Maximum 1560      Value 56=   $??60??6G   ${?False??6d   ?? 5.      $??zł na charta numer??6   $??Center=?61   $
??10,0q?6L     5/      -   5        $	 dogNumberInput??5/   Q   
 16$    460    16<   $??60??6F   ${?False??6i   ?? 51      -   5        $ submitButton??51      $
??30,0q?6+   $??
Zatwierdź??69   $	??8,0q?6M   ${?False??6p   53      56      57      