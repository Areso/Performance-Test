 <html>
 <head>
  <title>PHP Test</title>
 </head>
 <body>
 <?php 
 $sum =  0;
 $i = 0;
 $time = microtime();
 for ($i = 0; $i < 1000000; $i++) {
    $sum = $sum + $i;
 }
 $time2 = microtime();
 $time3 = $time2-$time;
 echo $time3;
 echo '<p>';
 echo $sum;
 echo '<p>Hello World</p>'; 
 ?> 
 </body>
</html>