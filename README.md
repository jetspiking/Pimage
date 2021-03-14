# Pimage

Swap every pixel from your favorite .png for a number in Pi!


**Usage**

Simply put a file "pimage.png" in the same directory as the executable. Execute and enter desired fontsize, width and height. That's it! 

_Windows_

Double click the .exe, no extra steps required.

_Mac and Linux_

Change directory in terminal to the same folder as the pimage binary file.

```
cd /Users/dustin/Downloads/Pimage-main/PimagePiDayProject/Pimage/bin/Release/netcoreapp3.1
```
```
./pimage
```

**Building on OS X and Linux**

_Only important if you want to build the application yourself_

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
