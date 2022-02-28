<?php
  session_start();
  $username = $_SESSION['username'];
  $password = $_SESSION['password'];
  $host = $_SESSION['host'];
  $dbname =$_SESSION['dbname'];
  $keyvalue=$_SESSION['keyvalue'] ;
  
$link = mysql_pconnect($host,$username,$password) or die(mysql_error());
  
  mysql_select_db($dbname) or die(mysql_error());
  mysql_query("SET CHARSET big5");


  $no = $_POST['cu_no'];
  $na = $_POST['cu_na'];
  $tel = $_POST['cu_tel'];
  $mtel = $_POST['cu_mtel'];
  $ml = $_POST['cu_email'];
  $st = $_POST['cu_staf'];
  $ad = $_POST['cu_adrs'];
  $tx = $_POST['cu_txno'];
  $tp = $_POST['ml_type'];
  

  $sql="Update cuinfo set cu_no='" . $no . "'";
  $sql=$sql . ", cu_name='" . $na . "'";
  $sql=$sql . ", cu_tel='" . $tel . "'";
  $sql=$sql . ", cu_mtel='" . $mtel . "'";
  $sql=$sql . ", cu_email='" . $ml . "'";
  $sql=$sql . ", cu_staf='" . $st . "'";
  $sql=$sql . ", cu_adrs='" . $ad . "'";
  $sql=$sql . ", cu_txno='" . $tx . "'";
  $sql=$sql . ", ml_type='" . $tp . "' where cu_no='" .  $_SESSION['keyvalue'] . "';";

  mysql_query($sql);
  //echo $sql;
  if (mysql_errno())
  {
     echo "Failed...";
  }
  else
  {
     echo "Update Successfully...";
  } 
  mysql_free_result($result);
?>

<form>
<input class="MyButton" type="button" value="回首頁"
          onclick="window.location.href='http://localhost/test/menu.php'" /> &nbsp;&nbsp; &nbsp;&nbsp; 
<input class="MyButton" type="button" value="重選鍵值"
          onclick="window.location.href='http://localhost/test/setkeyvalue.php'" /> 
</form>