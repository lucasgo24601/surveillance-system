<?php
 session_start();

  $username = $_POST['username'];
  $password = $_POST['password'];
  $host = $_POST['host'];
  $dbname = $_POST['dbname'];
  $_SESSION['username'] = $username;
  $_SESSION['password'] = $password;
  $_SESSION['host'] = $host;
  $_SESSION['dbname'] = $dbname;
  $link = mysql_pconnect($host,$username,$password) or die(mysql_error());
  
  mysql_select_db($dbname) or die(mysql_error());
  mysql_query("SET CHARSET big5");
  if (mysql_errno()) {
    header("HTTP/1.1 500 Internal Server Error");
    echo $query.'\n';
    echo mysql_error();
  }
  else
  {
    
    echo "Connect successfully...\n";
    $url='http://120.105.132.39//20151203/html/web/index.html';
    echo '<META HTTP-EQUIV=REFRESH CONTENT="1; '.$url.'">';
  }
?>