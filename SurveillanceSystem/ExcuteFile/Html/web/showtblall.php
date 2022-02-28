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
<table border="1" width="95%" cellspacing="1"> 
資料表:  
<?php 
 echo " " . $tblname ."<br>"
 ?>
<tr> 
  <?php
  $sql ="SELECT * FROM " .  $tblname ;
  $result = mysql_query($sql);
  if (!$result ) {
    die("Could not open $tblname: " . mysql_error());
  }

  $fldN = mysql_num_fields($result);
  //echo "N= " . $fldN . "<BR>";

  echo "<tr>"; 
   $i=0;
   while(i<$fldN)
   {
       echo "<td >" . mysql_field_name($result, $i) . "</td> ";
       $i++;
       if ($i>=$fldN)  //不加此段將產生error
       {
          break;
       }
   }
  echo "</tr>"; 

  ?>
</tr> 

<?php
 $row = mysql_fetch_row($result);
 while ($row != NULL) {
 
  echo "<tr>"; 
  $i=0;
   while(i<$fldN)
   {
     echo " <td >" . $row[$i] . "</td> ";
     $i++;
     if ($i>=$fldN)
      {
          break;
      }
   }

   echo "</tr>"; 

   $row = mysql_fetch_row($result);
}
 mysql_free_result($result);

?>
</table> 
<a href= "menu.php"><font size=3>回首頁</font></a><br>
</center></div> 
</body> 
</html>
