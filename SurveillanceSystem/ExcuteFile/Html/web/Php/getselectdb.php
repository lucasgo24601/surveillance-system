<?php
  session_start();
  $keyvalue = $_POST['selValue'];
 
  $_SESSION['dbname'] = $keyvalue;
     
   echo "選取資料庫  = ". $keyvalue . "\n";
  
?>
<form>
<input class="MyButton" type="button" value="回首頁"
          onclick="window.location.href='http://localhost/test/menu.php'" /> 
</form>