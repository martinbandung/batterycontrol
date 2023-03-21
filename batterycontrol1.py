import serial
import threading
import psutil
from datetime import datetime

openstat=True

while(openstat):
    port='/dev/ttyUSB0'
    try:
        ser=serial.Serial(port, 19200, timeout=1)
        openstat=False
    except:
        print('Port cannot be opened!')

#ser.write(b'fungsi1:1')

# https://www.geeksforgeeks.org/python-script-to-shows-laptop-battery-percentage/
# python script showing battery details

  
# function returning time in hh:mm:ss
def convertTime(seconds):
    minutes, seconds = divmod(seconds, 60)
    hours, minutes = divmod(minutes, 60)
    return "%d:%02d:%02d" % (hours, minutes, seconds)
  
# returns a tuple

  
#print("Battery percentage : ", battery.percent)

#print("Power plugged in : ", battery.power_plugged)
  
# converting seconds to hh:mm:ss


min= 57.5
max= min+5.0

def checkbat():
    threading.Timer(30.0, checkbat).start()
    battery = psutil.sensors_battery()
    now = datetime.now()
    current_time = now.strftime("%H:%M:%S")
    
    print(current_time)
    #print("Battery left\t: ", convertTime(battery.secsleft))
    

    if(battery.percent>=max):
        ser.write(b'fungsi1:0')
        
    if(battery.percent<=min):
        ser.write(b'fungsi1:1')
        
    battery = psutil.sensors_battery()    
    print("Battery percentage\t: ", round(battery.percent,1))
    print("Power plugged in\t: ", battery.power_plugged)
    

checkbat()
