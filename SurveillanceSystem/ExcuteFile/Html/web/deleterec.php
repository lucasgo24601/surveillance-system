<?php
 session_start();
//session_start();
 $username = $_SESSION['username'];
  $password = $_SESSION['password'];
  $host = $_SESSION['host'];
  $dbname =$_SESSION['dbname'];
  $keyvalue=$_SESSION['keyvalue'] ;
  $link = mysql_pconnect($host,$username,$password) or die(mysql_error());
  
  mysql_select_db($dbname) or die(mysql_error());
 
  $sql="Delete from cuinfo where cu_no='" .  $_SESSION['keyvalue'] . "';";

  mysql_query($sql);
  if (mysql_errno())
  {
     echo "Delete Record Failed...";
  }
  else
  {
     echo "Delete Record Successfully...";
  } 
 
?>
<form>
<input class="MyButton" type="button" value="回首頁"
          onclick="window.location.href='http://localhost/menu.php'" /> &nbsp;&nbsp; &nbsp;&nbsp; 
<input class="MyButton" type="button" value="重選鍵值"
          onclick="window.location.href='http://localhost/setkeyvalue.php'" /> 
</form>