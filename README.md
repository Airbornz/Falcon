# Falcon
Falcon is a minimal tech support tool for easy installation of software and some basic scripts.

## What software does it come with?
Falcon comes stripped down of any software not developed by Airbornz. It is up to <b>you</b> to use software that you have rights to use.
There are included scripts for password removals, basic wifi resolution, and creating restore points.

## How do I add software?
Its easy!

Check out the software.xml file here you will fill in the title, file location, and copyright info which will then be added to the app.

```
<options>
	<software>
		<title>Example Software</title>
		<location>example.exe</location>
		<copyright>Example LLC.</copyright>
	</software>
</options>
```

Here is an example of a filled out one:

```
<options>
	<software>
		<title>Google Chrome</title>
		<location>chrome.exe</location>
		<copyright>Google Inc.</copyright>
	</software>
        <software>
		<title>Steam</title>
		<location>steam.exe</location>
		<copyright>Valve Inc.</copyright>
	</software>
</options>
```

## Why is a button disabled?
This happens when a feature is unavailable this may mean that a script or program is not able to be found for that feature.
In the case of the Windows 11 Upgrade button it also checks the current OS and is only available when the current OS is Windows 10.

Here is specifically what each button looks for:

* Install Button : At least one piece of software in software.xml.
* CCleaner Button : File called ccleaner.exe in Falcon directory.
* User Mover : N/A (Shouldn't get disabled).
* Strip Ownership : File called strip.cmd in Falcon directory.
* Wifi Resolver : File called wifi.exe in Falcon directory.
* Create Restore Point : File called crp.cmd in Falcon directory.
* Auto Restore Point : File called arp.cmd in Falcon directory.
* Remove Password : File called passwordRem.cmd in Falcon directory.
* Windows 11 Upgrade : File called windows.exe in Falcon/windows directory AND current OS is Windows 10.
* About : N/A (Shouldn't get disabled).

## Where can I use this?
Wherever! This software currently requires no license or payment to use and can be used for commerical purposes or modified to suite your needs.

<b>Please note: While this software follows that open policy please make sure that you have the proper rights to use any software you add to this one 
by the developer of that software!<b>
