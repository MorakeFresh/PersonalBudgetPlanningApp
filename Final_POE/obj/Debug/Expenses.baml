   M S B A M L   `   `   `  ????D  @Final_POE, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:Final_POE	Final_POE  5   	       Final_POE.Expenses   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:Final_POE     5   	     ? Title$  LOANS??5   	   $	??450??6   $	??800??6$    ? WindowStyle$
 None=?5	   	    ? 
ResizeMode$ NoResize=?5
   	   
???????.??5      ?  ? RowDefinitions 5   
   ?? 5      $??25 ?6   ?? 5       ? ColumnDefinitions 5   
   ?? 5      $
??413* ?6   ?? 5      $
??387* ?6   .+?5   
   ? 
???p?$??2??6*    5      ?? 5      ?? 5      ?? 5      .+?5      ?? $??LOANS??6   
???????$??0??6<   $??Center=?5      $??Center=?63   $??25(?6P   $
??Bold"?6^   5       ?? 5"      -   5         ??Name$ Btn_Exit??5"      $
??EXIT??6'   $??2??66   
???????$??14(?6]   $??Medium"?6k   $??	162,0,0,0q?5#      $	??Top=?6(   $??25??6@   ??5$      ?? 5%       ?? 
TargetType" ??6   .?5&      ??  ?? Property ? ?? ?? Value
 ?  ??67   ?? 5'       ?@?Cursor$
 Hand??63   	 ?? Triggers	 5)      P? 5*      
 P? Property
 ?@J?IsMouseOver P? Value . . ?5+   "   ??  ? ??
 ?  ??6?   5,      5.      ??51      ?? 52       ?? 
TargetType" ??6&   .R?53      ?? $??80??6!   $??20??6,    ?? CornerRadius$ 12??68   #??z??6J   ._?54      ?? $??Center=?6/   $??Center=?6J   55      56      58      ?? 5:      -   5        $ Btn_Back??5:      $
??BACK??6'   $??2??66   
???????$??14(?6]   $??Medium"?6k   $
??Left=?5;      $??80,2,0,0q?60   $	??Top=?6B   $??82??6Z   ??5<      ?? 5=      " ??6   .?5>      ??  ? ??
 ?  ??67   ?? 5?       ?@?Cursor$
 Hand??63   	 5A      P? 5B      
 ?@J?IsMouseOver . . ?5C   "   ??  ? ??
 ?  ??6?   5D      5F      ??5I      ?? 5J      " ??6&   .R?5K      ?? $??80??6!   $??20??6,   $ 12??68   #??z??6J   ._?5L      ?? $??Center=?6/   $??Center=?6J   5M      5N      5P      5R      ?? 5T   
   $??1??6   $??Center=?6"   $	??405??6=   $??10,10,291,10q?6J   $??2??6`   .+?5U      ?? $-??'Please enter your gross monthly income.??6   
???   ?$??15(?6Z   $
??Bold"?5V      $??10,10,215,0q?6#   $??21??68   $
??Wrap=?6D   5W      ?? 5Y      $??Income??6   
???   ?$??15(?68   $??Medium"?5Z      $??30??6%   $??
10,0,429,0q?61    J? RenderTransformOrigin$ 1.279,0.929&?6E   ?? 5[      -   5         ??Name$ txtBox_Income??5[      $??
10,0,349,0q?6-   
???p?6A   ?? 5]      
???   ?$??15(?6+   $
??Bold"?5^      $??10,10,139,0q?6#   $??41??68   $
??Wrap=?6D   ?? 6Y   $)?#Please enter your monthly expenses.??6]    ?? 5_      $? ??6   ?? 6!   ?? 6'   ?? 63   $?Note!! ??67   ?? 6H   $#?Tax will be calculated Based ??6L   ?? 6s   $?	on Income??6w   ?? 6?   $?.??6?   6?   ?? 5a      $??	Groceries??6   
???   ?$??15(?6;   $??Medium"?5b      $??28??6%   $??
10,0,409,0q?61   $ 1.279,0.929&?6E   ?? 5c      -   5        $ txtBox_Groceries??5c      $??
10,0,349,0q?60   
???p?6D   ?? 5e      $??Water and Electricity??6   
???   ?$??15(?6G   $??Medium"?5f      $??29??6%   $??
10,0,329,0q?61   $ 1.279,0.929&?6E   ?? 5g      -   5        $  txtBox_WaterAndElectricity??5g      $??
10,0,349,0q?6:   
???p?6N   ?? 5i      $??Travel Costs??6   
???   ?$??15(?6>   $??Medium"?5j      $??28??6%   $??
10,0,390,0q?61   $ 1.279,0.929&?6E   ?? 5k      -   5        $ txtBox_TravelCosts??5k      $??
10,0,349,0q?62   
???p?6F   ?? 5m      $??Tele-Communications??6   
???   ?$??15(?6E   $??Medium"?5n      $??28??6%   $??
10,0,329,0q?61   $ 1.279,0.929&?6E   ?? 5o      -   5        $ txtBox_Tele??5o      $??
10,0,349,0q?6+   
???p?6?   ?? 5q      $??Other Expenses??6   
???   ?$??15(?6@   $??Medium"?5r      $??28??6%   $??
10,0,369,0q?61   $ 1.279,0.929&?6E   ?? 5s      -   5        $ txtBox_OtherExp??5s      $??
10,0,349,0q?6/   
???p?6C   ?? 5u      -	   5        $ Btn_Sub??5u      $??SUBMIT??6&   
???????$??14(?6N   $??Medium"?6\   $??46??6p   $??0,0,10,0q?6|   ??5v      ?? 5w      " ??6   .?5x      ??  ? ??
 ?p?67   ?? 5y       ?@?Cursor$
 Hand??63   	 5{      P? 5|      
 ?@J?IsMouseOver . . ?5}   "   ??  ? ??
 ??i??6?   5~      5?      ??5?      ?? 5?      " ??6&   .R?5?      ?? $	??100??6!   $??25??6-   $ 12??69   #??z??6K   ._?5?      ?? $??Center=?6/   $??Center=?6J   5?      5?      5?      5?      ?? 5?   
    ?? Orientation$ 
Horizontal=?6   $
??10,0q?6.   ? 5?   
   $??1??6   $??2??6   $??93,-354,-543,74q?60    K? ZIndex$ -1??5?      z?5?      ?? 5?       ?? Angle$ 50Q?6"   .+?5?      ?? $ 
Horizontal=?6   $??-350, 250, -255, -250q?62   .+?5?      ?? $ 
0.46,0.447&?6   .+?5?      ?? $	??700??6   $??35??6)   
????i??$??	150,0,0,0q?5?      $ 20??6,   ?? 5?      $	??700??6   $??35??6)   
???p?$??0,15,0,0q?5?      $ 20??6+   ?? 5?      $	??700??6   $??35??6)   
????i??$??	75,15,0,0q?5?      $ 20??6,   5?      ?? 5?      .+?5?      ?? $	??700??6   $??35??6)   
????i??$??	150,0,0,0q?5?      $ 20??6,   ?? 5?      $	??700??6   $??35??6)   
???p?$??0,15,0,0q?5?      $ 20??6+   ?? 5?      $	??700??6   $??35??6)   
????i??$??	75,15,0,0q?5?      $ 20??6,   5?      5?      5?      5?      5?      