   M S B A M L   `   `   `  ????F  BCMDFrontend, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:CMDFrontendCMDFrontend  5   	       CMDFrontend.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:CMDFrontend     5   	     ? Title$  
MainWindow??5   	   $	??450??6   $	??800??6)    ? 	Resources 5	         LoginButtonStyle ?? 
TargetType ?? Property ?? Value??%`  &	        ?? 5
   
   " ??6)   .?5      ??  ? ?? ?#06283D6+   ?? 5       ? ??$ Italic$?6*   ?? 5       ? ??
 ?????6+   ?? 5       ? ??$ Center=?64   ?? 5       ? ??$ 0q?6'   ?? 5       ? ??$	 100??6&   ?? 5       ? ??$ 20??6'   ?? 5       ? ??
 ?????6,   5      5      .??5      ?  ? RowDefinitions 5   
   ?? 5      $??40 ?6   5      ?? 5      .+?5   
   ? ???#06283D.+?5      o? $??Right=?6   ???#06283D$??1q?5!      $??Center=?5"      .@?5#      m? $??Sign Up??6   $??Italic$?5$      $??18(?5%      
???????$??Center=?5'      .@?5(      m? -   5        $??As a Doctor??5(      
???   ?5*      m? 5+      -   5        $??As a Patient??5+      
???   ?5-      5.      5/      50      ? 51   
   $??1??6    ? ColumnDefinitions 52      ?? 53      ?? 54      .+?56      ?? $??\Image\LoginImage.png??6   $
??Left=?57      ? 58      $??1??6    59      ?? 5:      ?? 5;      $??2* ?6$   ?? 5<      $??80 ?6$   .+?5?      ?? $??0??6   $??Welcome to CMD??5@      $??Center=?5A      ???#06283D$??30(?5C      $??10,15q?5D      ?? 5E      $??1??6   .+?5F      ?? $??Username??6   $??Center=?5G      $??
10,15,10,5q?5H      ?? 5I      -   5         ??Name$ UsernameTextBox??5I      $
??10,5q?67   $	??150??5J      ???#C4D7E05K      ?? 5M      $??Password??6   $??Center=?5N      $??
10,15,10,5q?5O      G? 5P      -   5         G?Name$ PasswordBox??5P   "   $
??10,5q?67   $	??150??5Q   "   ???#C4D7E05R   "   5c      ?? 5d      $??2??6   .+?5f      ?? -   5        	 ??Name$	 DoctorLoginButton??5f      $??Login as Doctor???5g      #??[  5h      5i      ?? 5j      -   5        $	 PatientLoginButton??5j      $??Login as Patient???5k      #??[  5l      5m      5n      5q      5r      5t      5u      