# NYU-Wk12-Maze
 First VR Level for NYU AR/VR Course
 
 ![NYU_KUBIZNE_Wk12-Maze-Screen (0)](https://github.com/jkubizne/NYU-Wk12-Maze/assets/38052491/8562e05c-0483-4d99-8ef1-3695f83246c2)

The Maze: This is a basic "find and fetch" game implementing XR Grab Interactables that allow the player to progress as well as a Teleport system to ease travesing the level in VR. You start outside of a building/complex and world space UI informs you must find a battery to place in the generator. Once the battery is placed in the correct slot, you are able to find your way out with some visual clues and informative UI pop-ups.

Process:
Some challenges in getting this experience to work included ensuring the I could properly get my Valve Index Headset working with Unity. The course material is based around Oculus and so I was on my own in that respect. I had come to understand through reserach that Valve's Steam VR Plug-in for Unity was a bit of a mess currently and opted to go with OpenXR. I chose this route not only to get basic functionality working with the Index but also in the interest of compatiblity across VR hardware. Seeing that OpenXR is standardized and compatible across platforms, I figured I should cover this technical aspect as early as possible, both for my own projects in the future and so that other's could test this creation without technical difficulties. 

There was some growing pains with making sure the input actions were correctly configured, but aside from checking off the steps diligently and cobbling together different sources on Medium and YouTube to get things going, it didn't take much besides a fair chunk of time. Once configured corectly all the tools and features provided in the OpenXR Interaction Toolkit examples performed quite well.

Also in the interests of compatiblity and performance I used URP for the first time, so there was a small learning curve there as well, converting assets and tackling minor graphics issues. My big question is how to ensure functionality on across controllers.

Link to Screenshots and Video Screen Capture:

https://www.dropbox.com/sh/tbe9b1z7bsf7le1/AABh4zGYrKKxXqqbYCTKPeEMa?dl=0

Assets:

https://github.com/Unity-Technologies/XR-Interaction-Toolkit-Examples
https://assetstore.unity.com/packages/3d/environments/sci-fi/sci-fi-styled-modular-pack-82913
https://assetstore.unity.com/packages/3d/environments/sci-fi/free-lowpoly-scifi-110070

Resources:

https://blog.immersive-insiders.com/xr-simulator/
https://www.youtube.com/watch?v=5ZBkEYUyBWQ
https://www.youtube.com/watch?v=d2gEEQeu1b4

