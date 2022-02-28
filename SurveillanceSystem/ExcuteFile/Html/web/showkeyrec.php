<?php
 session_start();
//session_start();
 $username = $_SESSION['username'];
  $password = $_SESSION['password'];
  $host = $_SESSION['host'];
  $dbname =$_SESSION['dbname'];
  $keyvalue=$_SESSION['keyvalue'] ;
  $link = mysql_pconnect($host,$username,$password) or die(mysql_error());
  
  mysql_select_db($dbname) or die(mysql_error());
  mysql_query("SET CHARSET big5");
  $sql ="SELECT * FROM command where 檔案編號='" . $keyvalue . "'";
  $result = mysql_query($sql);
  if (!$result ) {
    die("Could not open cuinfo: " . mysql_error());
  }

  $row = mysql_fetch_row($result);
  if ($row != NULL)
   {
   }
  else
   {
     echo $sql . "\n";
     echo "無對應紀錄...";
 
   }
 ?>

<html>

<head>
<meta http-equiv="Content-Type" content="text/html; charset=big5">
<title>PHP連結MySQL 顯示鍵值紀錄</title>

</head>

<body>

<div align="center"><center> 

資料表<br>
 <?php
   list($cu_no, $cu_na, $cu_tel, $cu_mtel, $cu_email,$cu_staf,$cu_adrs,$cu_txno,$ml_type) = $row;  
 ?>
<form method="POST" action="updaterec.php">
  <div align="center"><center><table border="0" width="80%" cellspacing="1">
  <table border="1" width="60%" cellspacing="1"> 
  <tr> 
   <td width="15%" bgcolor="#C0C0C0"><strong>檔案編號</td> 
     <td width="85%"><input type="text" name="cu_no" Value="<?=$cu_no?>" size="10"></td>
  </tr><tr>
   <td width="15%">原始資料</td> 
     <td width="85%"><input type="text" name="cu_na" Value="<?=$cu_na?>" size="50"></td>
 </tr><tr>
   <td width="15%">A</td> 
     <td width="85%"><input type="text" name="cu_tel" Value="<?=$cu_tel?>" size="12"></td>
 </tr><tr>
   <td width="15%">B</td>
     <td width="85%"><input type="text" name="cu_mtel" Value="<?=$cu_mtel?>" size="12"></td>
 </tr><tr>
   <td width="15%">C</td> 
     <td width="85%"><input type="text" name="cu_email" Value="<?=$cu_email?>" size="40"></td>
 </tr><tr>
   <td width="15%">D</td> 
     <td width="85%"><input type="text" name="cu_staf" Value="<?=$cu_staf?>" size="12"></td>
 </tr><tr>
   <td width="15%">E</td> 
     <td width="85%"><input type="text" name="cu_adrs" Value="<?=$cu_adrs?>" size="40"></td>
 </tr><tr>
   <td width="15%">F</td> 
     <td width="85%"><input type="text" name="cu_txno" Value="<?=$cu_txno?>" size="10"></td>
 </tr><tr>
   <td width="15%">W </td> 
     <td width="85%"><input type="text" name="ml_type" Value="<?=$ml_type?>" size="40"></td>
 </tr><tr>
      <td width="15%">
          <input class="MyButton" type="button" value="回首頁"
          onclick="window.location.href='http://localhost/20151203/html/web/menu.php'" />
       </td>
      <td width="85%">
         
         <input class="MyButton" type="button" value="重選鍵值"
          onclick="window.location.href='http://localhost/20151203/html/web/setkeyvalue.php'" />
              
      </td>
    </tr>
 
</table> 
</center></div> 
</form>
<a href= "menu.php"><font size=3>回首頁</font></a><br>
</body> 
</html>
