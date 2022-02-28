<?php
 session_start();
 $username = $_SESSION['username'];
  $password = $_SESSION['password'];
  $host = $_SESSION['host'];
  $dbname =$_SESSION['dbname'];
  $link = mysql_pconnect($host,$username,$password) or die(mysql_error());
  
  mysql_select_db($dbname) or die(mysql_error());
  mysql_query("SET CHARSET big5");
  $result = mysql_query("SELECT Distinct cu_no FROM cuinfo order by cu_no;");
  if (!$result ) {
    die("Could not open cuinfo: " . mysql_error());
  }

?>

<html>

<head>
<meta http-equiv="Content-Type" content="text/html; charset=big5">
<title>PHP連結MySQL 選取鍵值</title>

</head>

<body>
<div align="center"><center> 

<form method="POST" action="getkeyvalue.php">
  <div align="center"><center>
  <table border="0" width="80%" cellspacing="1">
    <tr>
      <td width="15%" bgcolor="#C0C0C0"><strong>編號</strong></td>
      <td width="85%"> <Select name="selValue" >
        <?php
        $row = mysql_fetch_row($result);
        while ($row != NULL)
        {
           list($cu_no) = $row;

          // echo <<<EOD
           echo "<Option Value='" . $cu_no . "'>" . $cu_no . "</Option>";

          // EOD;
           $row = mysql_fetch_row($result);
        }
        mysql_free_result($result);
      ?>

      </Select>
     </td></tr>
    <tr>
      <td width="15%"></td>
      <td width="85%">
         <input type="submit" value="送出" name="send">
         <input type="reset" value="重填"  name="cancel" >
      </td>
    </tr>
  </table>
  </center></div>
</form>
</center></div> 
</body> 
</html>
