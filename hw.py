import datetime;
print ("Hello, Python!");
sum =  0;
i = 0;
time1 = datetime.datetime.now();
for i in range(0,1000000): 
	sum = sum + i;
time2 = datetime.datetime.now();
time3 = time2 - time1;
print (time3);
print (sum);


