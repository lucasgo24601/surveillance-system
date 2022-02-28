<?php
 session_start();
 $username = $_SESSION['username'];
  $password = $_SESSION['password'];
  $host = $_SESSION['host'];
  $dbname =$_SESSION['dbname'];
  $link = mysql_pconnect($host,$username,$password) or die(mysql_error());
  
  mysql_select_db($dbname) or die(mysql_error());
  mysql_query("SET CHARSET big5");
  $result = mysql_query("show tables;");
  if (!$result ) {
    die("Could not open Database: " . mysql_error());
  }

?>

<html>

<head>
<meta http-equiv="Content-Type" content="text/html; charset=big5">
<title>PHP連結MySQL 選取資料表</title>

</head>

<body>
<div align="center"><center> 

<form method="POST" action="getselecttbl.php">
  <div align="center"><center>
  <table border="0" width="80%" cellspacing="1">
    <tr>
      <td width="15%" bgcolor="#C0C0C0"><strong>資料表</strong></td>
      <td width="85%"> <Select name="selValue" >
        <?php
        $row = mysql_fetch_row($result);
        while ($row != NULL)
        {
           list($tbl) = $row;
           echo "<Option Value='" . $tbl . "'>" . $tbl . "</Option>";
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
