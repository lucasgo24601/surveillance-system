<?php
  session_start();
  $keyvalue = $_POST['selValue'];
 
  $_SESSION['tblname'] = $keyvalue;
     
   echo "選取資料表  = ". $keyvalue . "\n";
  
?>
<form>
<input class="MyButton" type="button" value="回首頁"
          onclick="window.location.href='http://localhost/menu.php'" /> 
</form>