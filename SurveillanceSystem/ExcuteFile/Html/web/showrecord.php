<?php
 session_start();
?>
<html>

<head>
<meta http-equiv="Content-Type" content="text/html; charset=big5">
<title>PHP連結MySQL 首頁</title>

</head>

<body>
<div align="center"><center> 
<table border="1" width="95%" cellspacing="1"> 
指令資料表<br>
<tr> 
   <td width="4%">檔案編號</td> 
   <td width="30%">原始資料 </td> 
   <td width="2%">A </td> 
   <td width="2%">B </td> 
   <td width="4%">C </td> 
   <td width="8%">D </td> 
   <td width="4%">E </td> 
   <td width="4%">F </td> 
   <td width="25%">W </td> 
   <td width="4%">X </td>  
   <td width="13%">時間 </td> 
</tr> 

<?php
 //session_start();
 $username = $_SESSION['username'];
  $password = $_SESSION['password'];
  $host = $_SESSION['host'];
  $dbname =$_SESSION['dbname'];
  
  $link = mysql_pconnect($host,$username,$password) or die(mysql_error());
  
  mysql_select_db($dbname) or die(mysql_error());
  mysql_query("SET CHARSET big5");
 //mysql_query("use mysal",$link);
 $result = mysql_query("SELECT * FROM command order by 檔案編號;");
  if (!$result ) {
    die("Could not open command: " . mysql_error());
  }

 $row = mysql_fetch_row($result);
 while ($row != NULL) {
   list($cmd_no, $cmd_src, $cmd_a, $cmd_b, $cmd_c,$cmd_d,$cmd_e,$cmd_f,$cmd_w,$cmd_x,$cmd_time) = $row;

echo <<<EOD
  <tr> 
   <td width="4%">$cmd_no</td> 
   <td width="30%">$cmd_src</td> 
   <td width="2%">$cmd_a</td> 
   <td width="2%">$cmd_b</td> 
   <td width="4%"> $cmd_c</td> 
   <td width="8%">$cmd_d</td> 
   <td width="4%">$cmd_e</td> 
   <td width="4%">$cmd_f</td> 
   <td width="25%">$cmd_w</td> 
   <td width="4%">$cmd_x</td> 
   <td width="13%">$cmd_time</td> 
  </tr> 

EOD;
   $row = mysql_fetch_row($result);
}
mysql_free_result($result);
?>
</table> 
<a href= "menu.php"><font size=3>回首頁</font></a><br>
</center></div> 
</body> 
</html>
