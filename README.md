<h1 align="center">N2D - Node2Deauther</h1>

An **easy to use** tool that will convert any ESP8266 development board into a deauther as long as it's compatible with Space Huhns firmware.

### UPDATE: Advanced version of N2D for advanced users (or anyone who wants customization) ![8](https://github.com/mrvodka007/n2dX)

###### How to use the program (*for beginners*)

1. On this page, click on **ReleaseWin32-64** then **N2D.exe** where is says 11MB look over to the right and click **Download**.

2. Open the file that you have downloaded, and allow it through your anti-virus in case it warns you of unfamiliar apps. If Windows SmartScreen interfers, click **More Info** then **Run Anyway**.

3. Once you arrive at the main page:

![1](https://raw.githubusercontent.com/mrvodka007/n2d/master/Preview-IMG/ScreenShot1.PNG)

Plug in your development board, it make take a few seconds to detect your device. If nothing happens after 3 seconds please click **Install Drivers**. If the application finds it, skip to step 7.

4. You will see a screen like this, choose your UART Model or "**I don't know**" for both.

![2](https://raw.githubusercontent.com/mrvodka007/n2d/master/Preview-IMG/ScreenShot2.PNG)

5. Click **Download and Install** and this screen will appear, AT THIS POINT - your firewall may ask to allow Internet access, please 
do!

![3](https://raw.githubusercontent.com/mrvodka007/n2d/master/Preview-IMG/ScreenShot4.PNG)

6. Proceed with the driver installation and once you're done, the application will restart. Unplug and plug in your device again. If nothing still happens, please reboot your computer or try a different driver. If nothing works contact me (Click About)

7. Once you see this page:

![4](https://raw.githubusercontent.com/mrvodka007/n2d/master/Preview-IMG/ScreenShot5.PNG)

You are okay, please keep in mind your device name could be differnet (that one is mine).
8. Click **Begin Flash**. The program will ask you to download or choose your firmware file. 

9.--- If you chose yes then you will need to browse for a file if nt the downloader will launch.

![5](https://raw.githubusercontent.com/mrvodka007/n2d/master/Preview-IMG/ScreenShot6.PNG)

Then it will progress to this:

![6](https://raw.githubusercontent.com/mrvodka007/n2d/master/Preview-IMG/Update1-FLASH.PNG)

10. The flash process should take around 50 seconds but no longer than 2 minutes.

Once everything is complete you will be greeted with the final page where the connection details are given to you.
At this point you will need to reboot the development board, either by hititng the reset switch or by unpluging it and pluging it back in.
&nbsp;

![7](https://raw.githubusercontent.com/mrvodka007/n2d/master/Preview-IMG/ScreenShot8.PNG)




If you are a developer / advanced user then the source code is in **Source Code\N2D-Master**.
