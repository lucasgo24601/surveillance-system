<?php
  session_start();
  $keyvalue = $_POST['selValue'];
 
  $_SESSION['tblname'] = $keyvalue;
     
   echo "�����ƪ�  = ". $keyvalue . "\n";
  
?>
<form>
<input class="MyButton" type="button" value="�^����"
          onclick="window.location.href='http://localhost/menu.php'" /> 
</form>