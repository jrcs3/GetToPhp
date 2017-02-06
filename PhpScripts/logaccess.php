<?php

require 'os.php';

define("LOG_FILE_PATH", "../log/get_log.txt");

header('Content-Type: application/json');
$getParamsJSon = '';
$getParamsJSon .= '[';
$first = true;
foreach ( $_GET as $key => $value ) {
    if (!$first)  {
        $getParamsJSon .= ',';
    }
    $getParamsJSon .= "{'$key':'$value'}";
    $first = false;
}
$getParamsJSon .= ']';
file_put_contents(LOG_FILE_PATH, date("Y-m-d H:i:s") . ' - ' . $getParamsJSon . PHP_EOL, FILE_APPEND | LOCK_EX);
echo $getParamsJSon;
?>