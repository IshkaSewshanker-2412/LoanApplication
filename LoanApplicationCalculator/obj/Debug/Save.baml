   M S B A M L   `   `   `  ????T  PLoanApplicationCalculator, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullE'clr-namespace:LoanApplicationCalculatorLoanApplicationCalculator  5   	   $    LoanApplicationCalculator.Save   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   9local'clr-namespace:LoanApplicationCalculator     5   	     ? Title$
  Save??5   	   $	??450??6   $	??800??6#   
???????$??DemiBold"?6F   .??5	      ? .+?5   
   ?? $*??$Welcome to our loan calculation app!??6   $??Center=?6?   $??	10,10,0,0q?5      $	??Top=?6#   $	??220??6;   $
??Bold"?6G   
????  ?5      ?? 5   
   $'??!You have chosen the Save option! ??6   $
??Left=?6<   $??
105,65,0,0q?5   	   $	??Top=?6   $
??Bold"?65   
???  ??$??35(?5   !   ?? 5   
   $
??Left=?6   $	??100??6+   $??642,127,0,0q?68   $	??Top=?5      $	??100??6(   $??save.jpg??64    J? RenderTransformOrigin$ 
0.498,0.71&?6F   ?? 5   
   -   5         ??Name$ btn_Save??5   R   $??Click to calculate??5      $
??Left=?6.   $??291,312,0,0q?6I   $	??Top=?5      $??30??6)   $	??202??65   
???  ??6d   ?? 5   
   -   5        $??Go Back??5      $
??Left=?6#   $??291,361,0,0q?6>   
???? ??$	??Top=?5   )   $??30??6A   $	??202??5      6   ?? 5    
   $4??.Please enter reason for choosing save option: ??6   $
??Left=?6I   $??
50,127,0,0q?5!      $	??Top=?6$   ?? 5#   
   -   5         ??Name$ txtBox_Reason??5$   J   $
??Left=?5#      $??23??6-   $??391,131,0,0q?69    ?? TextWrapping$
 Wrap=?5$   
   $?? ??6   $	??Top=?6&   $	??150??6>   6J   ?? 5'   
   $)??#Enter the amount you wish to save: ??6   $
??Left=?6>   $??
50,158,0,0q?5(      $	??Top=?6$   ?? 5*   
   -   5        $ txtBox_saveAmount??5+   6   $
??Left=?5*      $??23??6-   $??391,170,0,0q?69   $
 Wrap=?6N   $?? ??5+   
   $	??Top=?6   $	??150??6*   66   ?? 5.   
   $??Enter interest amount: ??6   $
??Left=?62   $??
50,209,0,0q?6M   $	??Top=?5/   
   ?? 51   
   -   5        $ txtBox_interestRate??52   J   $
??Left=?51      $??23??6-   $??391,213,0,0q?69   $
 Wrap=?52   
   $?? ??6   $	??Top=?6&   $	??150??6>   6J   ?? 55   
   $2??,Enter the time period you wish to save for: ??6   $
??Left=?56   
   $??
50,256,0,0q?6%   $	??Top=?69   ?? 58   
   -   5        $ txtBox_TimePeriod??59   5   $
??Left=?58      $??23??6-   $??391,256,0,0q?69   $
 Wrap=?6N   $?? ??59   	   $	??Top=?6   $	??150??6)   65   5C      5D      