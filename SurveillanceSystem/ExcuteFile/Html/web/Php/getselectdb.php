<?php
  session_start();
  $keyvalue = $_POST['selValue'];
 
  $_SESSION['dbname'] = $keyvalue;
     
   echo "�����Ʈw  = ". $keyvalue . "\n";
  
?>
<form>
<input class="MyButton" type="button" value="�^����"
          onclick="window.location.href='http://localhost/test/menu.php'" /> 
</form>