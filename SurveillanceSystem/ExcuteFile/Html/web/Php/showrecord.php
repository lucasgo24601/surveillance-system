<?php
 session_start();
?>
<html>

<head>
<meta http-equiv="Content-Type" content="text/html; charset=big5">
<title>PHP�s��MySQL ����</title>

</head>

<body>
<div align="center"><center> 
<table border="1" width="95%" cellspacing="1"> 
�Ȥ��ƪ�<br>
<tr> 
   <td width="1%">�s��</td> 
   <td width="8%">���q�W�� </td> 
   <td width="10%">�q�� </td> 
   <td width="10%">��� </td> 
   <td width="20%"> Email</td> 
   <td width="5%">�p���H</td> 
   <td width="25%">�a�} </td> 
   <td width="8%">�νs </td> 
   <td width="1%">���� </td> 
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
 $result = mysql_query("SELECT * FROM cuinfo order by cu_no;");
  if (!$result ) {
    die("Could not open cuinfo: " . mysql_error());
  }

 $row = mysql_fetch_row($result);
 while ($row != NULL) {
   list($cu_no, $cu_na, $cu_tel, $cu_mtel, $cu_email,$cu_staf,$cu_adrs,$cu_txno,$ml_type) = $row;

echo <<<EOD
  <tr> 
   <td width="1%">$cu_no</td> 
   <td width="8%">$cu_na</td> 
   <td width="10%">$cu_tel</td> 
   <td width="10%">$cu_mtel</td> 
   <td width="20%"> $cu_emaill</td> 
   <td width="8%">$cu_staf</td> 
   <td width="25%">$cu_adrs</td> 
  <td width="8%">$cu_txno</td> 
  <td width="1%">$ml_type</td> 
  </tr> 

EOD;
   $row = mysql_fetch_row($result);
}
mysql_free_result($result);
?>
</table> 
<a href= "menu.php"><font size=3>�^����</font></a><br>
</center></div> 
</body> 
</html>
