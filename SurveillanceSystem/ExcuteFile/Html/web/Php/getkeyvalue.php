<?php
  session_start();
  $keyvalue = $_POST['selValue'];
 
  $_SESSION['keyvalue'] = $keyvalue;
     
   echo "������ =". $keyvalue . "\n";
   $url='http://localhost/showkeyrec.php';
   echo '<META HTTP-EQUIV=REFRESH CONTENT="1; '.$url.'">';
?>
