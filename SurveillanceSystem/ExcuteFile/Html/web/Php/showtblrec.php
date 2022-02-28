<?php
 session_start();

 $username = $_SESSION['username'];
  $password = $_SESSION['password'];
  $host = $_SESSION['host'];
  $dbname =$_SESSION['dbname'];
  $tblname  =$_SESSION['tblname'];
  $link = mysql_pconnect($host,$username,$password) or die(mysql_error());
  
  mysql_select_db($dbname) or die(mysql_error());
  mysql_query("SET CHARSET big5");
 
?>
<html>

<head>
<meta http-equiv="Content-Type" content="text/html; charset=big5">
<title>PHP連結MySQL 顯示紀錄</title>

</head>

<body>
<div align="center"><center> 
<table border="1" width="50%" cellspacing="1"> 
資料表:
<?php 
 echo " " . $tblname ."<br>";

  $sql ="SELECT * FROM " .  $tblname ;
  $result = mysql_query($sql);
  if (!$result ) {
    die("Could not open $tblname: " . mysql_error());
  }

  $fldN = mysql_num_fields($result);
   
 $row = mysql_fetch_row($result);
 if ($row != NULL) {
   $i=0;
   while(i<$fldN)
   {
     $na=mysql_field_name($result, $i);
     $ln=mysql_field_len($result, $i);
     echo "<tr>"; 
     echo "<td width='15%' bgcolor='#C0C0C0'><strong>". $na . "</td> ";
     echo "<td width='85%'><input type='text' name=' $na' Value='$row[$i]' size='$ln'></td>";
     echo "</tr>";  
     $i++;
     if ($i>=$fldN)
      {
          break;
      }
   }
 }
 mysql_free_result($result);

?>
</table><br><br> 
<a href= "menu.php"><font size=3>回首頁</font></a><br>
</center></div> 
</body> 
</html>
