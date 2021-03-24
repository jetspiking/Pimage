<pre>
_____ _   
|  __  |
| |__) | _ __ ___   __ _  __ _  ___ 
|  ___/ | -_ - _ \ / _- |/ _- |/ _ \
| |   | | | | | | | (_| | (_| |  __/
|_|   |_|_| |_| |_|\__,_|\__, |\___|
                          __/ |     
                         |___/    
</pre>

# Pimage

Swap every pixel from your favorite .png for a number in Pi! When the maximum precision is reached it starts again from the beginning (only when resolution is higher than 100.000 pixels). 


**Usage**

Simply put a file "pimage.png" in the same directory as the executable. Execute and enter desired fontsize, width and height. That's it! Afterwards the result is visible in the file ```pimage_result.png```.

_Windows_

Double click the .exe, no extra steps required. If the application doesn't launch, navigate to the executable directory in commandprompt instead and launch it from there, you will then see a debug log which describes the issue. Most of the time this is due to .net core runtime missing.

_Mac and Linux_

Change directory in terminal to the same folder as the pimage binary file.

```
cd /Users/dustin/Downloads/Pimage-main/PimagePiDayProject/Pimage/bin/Release/netcoreapp3.1
```
```
./pimage
```

**Building on OS X and Linux**

_Only important if you want to build the application yourself, for usage, refer to the above step._

Make sure you have mono-libgdiplus (Mac) or libgdiplus (Linux) installed. Missing this package could cause a program crash that is currently not correctly caught in the code. This steps might be optional. 

For Mac: 
```
brew install mono-libgdiplus
```

For Linux:
```
apt(-get) install libgdiplus
```

**Example**

![Raspberry Large](https://github.com/jetspiking/Pimage/blob/main/pimage_raspberry_big.png)
