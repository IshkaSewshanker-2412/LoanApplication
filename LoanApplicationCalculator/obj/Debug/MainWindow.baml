   M S B A M L   `   `   `  ????T  PLoanApplicationCalculator, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullE'clr-namespace:LoanApplicationCalculatorLoanApplicationCalculator  5   	   *    $LoanApplicationCalculator.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   9local'clr-namespace:LoanApplicationCalculator     5   	     ? Title$!  Loan Application Calculator??5   	   $	??450??6-   $	??800??6:   
???????$??DemiBold"?6Z   .??5
      ? .+?5   
   ?? $*??$Welcome to our loan calculation app!??6   $??Center=?6?   $??	10,10,0,0q?5      $	??Top=?6#   $	??220??6;   $
??Bold"?6G   
????  ?5      ?? 5   
   $>??8Please enter the values for the following, given below: ??6   $
??Left=?6S   $??	10,36,0,0q?5   	   $	??Top=?6   $
??Bold"?64   
????  ?5      ?? 5   
   $.??(Enter amount for gross monthly income:  ??6   $
??Left=?6C   $??	14,73,0,0q?5      $	??Top=?6#   ?? 5   
   -   5        $??txtBox_gross??5   J   $
??Left=?5      $??23??6-   $??
313,73,0,0q?69    ?? TextWrapping$
 Wrap=?5   
   $?? ??6   $	??Top=?6&   $	??120??6>   6J   ?? 5   
   $5??/Enter amount for monthly income tax deducted:  ??6   $
??Left=?6J   $??
14,104,0,0q?5       $	??Top=?6!   ?? 5"   
   -   5         ??Name$ txtBox_income??5#   J   $
??Left=?5"      $??23??6-   $??313,109,0,0q?69   $
 Wrap=?5#   
   $?? ??6   $	??Top=?6&   $	??120??6>   6J   ?? 5'   
   $#??Enter amount for groceries:  ??6   $
??Left=?68   $??
14,136,0,0q?5(      $	??Top=?6!   ?? 5*   
   -   5        $ txtBox_Groc??5+   M   $
??Left=?5*      $??23??6-   $??313,137,0,0q?69   $
 Wrap=?5+      $?? ??6!   $	??Top=?6)   $	??120??6A   6M   ?? 5.   
   $*??$Enter amount for water and lights:  ??6   $
??Left=?6?   $??
14,164,0,0q?5/      $	??Top=?6!   ?? 51   
   -   5        $ 
txtBox_WNL??52   M   $
??Left=?51      $??23??6-   $??313,167,0,0q?69   $
 Wrap=?52      $?? ??6!   $	??Top=?6)   $	??120??6A   6M   ?? 55   
   $6??0Enter amount for cellphone and telephone cost:  ??6   $
??Left=?6K   $??
14,195,0,0q?56      $	??Top=?6!   ?? 58   
   -   5        $ txtBox_Cell??59   M   $
??Left=?58      $??23??6-   $??313,199,0,0q?69   $
 Wrap=?59      $?? ??6!   $	??Top=?6)   $	??120??6A   6M   ?? 5<   
   $%??Enter amount for travel cost:  ??6   $
??Left=?6:   $??
14,229,0,0q?5=      $	??Top=?6!   ?? 5?   
   -   5        $ txtBox_travel??5A      $
??Left=?5?      $??23??6-   $??313,232,0,0q?69   $
 Wrap=?5@   
   $?? ??6   $	??Top=?6&   $	??120??6>   5A      ?? 5D   
   $8??2Please select one of the following options below: ??6   $
??Left=?5E   
   $??
21,318,0,0q?6%   $	??Top=?69   
????  ?$
??Bold"?5F       ?? 5J   
   -   5         ??Name$ btn_SaveAmounts??5L   
   $??Display Amounts Entered??5J      $
??Left=?63   $??
21,272,0,0q?5K   
   $	??Top=?6   $	??145??66   
???  ??5L   #   ?? 5O   
   $
??Left=?6   $??75??6+   $??
664,36,0,0q?67   $	??Top=?5P   
   $	??100??6"   $??
images.png??6.   ?? 5S   
   -   5        $ btn_Home??5T   A   $??Homeloan??5S      $
??Left=?6$   $??
27,364,0,0q?5T   
   $	??Top=?6   $??75??66   
???? ??5U   %   ?? 5X   
   -	   5        $ btn_Vehicle??5Y   B   $??Vehicle??5X      $
??Left=?6#   $??168,364,0,0q?5Y   
   $	??Top=?6   $??75??67   
????  ?5Z   '   ?? 5]   
   -
   5        $ btn_Save??5^   B   $
??Save??5]      $
??Left=?6    $??313,364,0,0q?5^   
   $	??Top=?6   $??75??67   
??? ? ?5_      5t      5u      