
<html>

<head>
<meta http-equiv="Content-Type" content="text/html; charset=big5">
<title>PHP連結MySQL 新增紀錄</title>

</head>

<body>
<div align="center"><center> 

客戶資料表<br>
 
<form method="POST" action="insertrec.php">
  <div align="center"><center><table border="0" width="80%" cellspacing="1">
  <table border="1" width="80%" cellspacing="1"> 
  <tr> 
   <td width="15%" bgcolor="#C0C0C0"><strong>編號</td> 
     <td width="85%"><input type="text" name="cu_no" size="10"></td>
  </tr><tr>
   <td width="15%">公司名稱 </td> 
     <td width="85%"><input type="text" name="cu_na"  size="20"></td>
 </tr><tr>
   <td width="15%">電話 </td> 
     <td width="85%"><input type="text" name="cu_tel"  size="12"></td>
 </tr><tr>
   <td width="15%">手機 </td>
     <td width="85%"><input type="text" name="cu_mtel"  size="12"></td>
 </tr><tr>
   <td width="15%"> Email</td> 
     <td width="85%"><input type="text" name="cu_email"  size="40"></td>
 </tr><tr>
   <td width="15%">聯絡人</td> 
     <td width="85%"><input type="text" name="cu_staf"  size="12"></td>
 </tr><tr>
   <td width="15%">地址 </td> 
     <td width="85%"><input type="text" name="cu_adrs"  size="40"></td>
 </tr><tr>
   <td width="15%">統編</td> 
     <td width="85%"><input type="text" name="cu_txno"  size="10"></td>
 </tr><tr>
   <td width="15%">報表 </td> 
     <td width="85%"><input type="text" name="ml_type" size="4"></td>
</tr> 
 <tr>
      <td width="15%"></td>
      <td width="85%">
         <input type="submit" value="新增" name="send">
         <input type="reset" value="重填"  name="cancel" >
      </td>
    </tr>
</table> 
</center></div> 
</form>
<a href= "menu.php"><font size=3>回首頁</font></a><br>
</body> 
</html>
