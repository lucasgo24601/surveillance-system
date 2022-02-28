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


  $no = $_POST['A'];
  $na = $_POST['B'];
  $tel = $_POST['C'];
  $mtel = $_POST['D'];
  $ml = $_POST['E'];
  $st = $_POST['F'];
  $ad = $_POST['G'];

  $ss = "";




$sam = $no.$na.$tel.$mtel.$ml.$st.$ad;










  $sql="Insert Into send Values ('','" . $no . "','"  . $na . "','" . $tel . "','" . $mtel . "','" . $ml . "','" . $st .  "','" . $ad .  "','"  . $sam . "')";





//exec('mode COM1: baud=38400 data=8 stop=1 parity=n');
//$fd = dio_open('COM1:', O_RDWR);
//dio_write($fd,$sam);
//dio_close($fd);






  mysql_query($sql);
  //echo $sql;
  if (mysql_errno())
  {

     echo "Failed...";
  }
  else
  {
     echo "Insert Successfully...";

    $url='http://120.105.132.39//20151203/html/web/index.html';
    echo '<META HTTP-EQUIV=REFRESH CONTENT="1; '.$url.'">';

   } 

?>