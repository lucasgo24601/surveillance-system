<?php
 session_start();
 session_destroy();
$url='http://localhost/20151203/html/web/index.html';
    echo '<META HTTP-EQUIV=REFRESH CONTENT="0; '.$url.'">';
?>
