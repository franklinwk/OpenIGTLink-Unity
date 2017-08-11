# OpenIGTLink-Unity

A basic example scene is provided in /Assets/Scenes/

The scripts are only configured to run as an OpenIGTLink client. If connection to 3D Slicer is desired, 3D Slicer must run OpenIGTLinkIF as a server.

The server configuration is read in from /config.txt, not from the values set within the Unity editor.
  - When running in the editor, config.txt should be placed in the project directory.
  - When running in a compiled build, config.txt should be placed in the same directory as the executable.

The OpenIGTLinkConnect script should be added to a GameObject in the scene.

The OpenIGTLinkFlag script should be added to all GameObjects that will receive or send data.
  - Transforms currently are sent with the same name as the GameObject they are attached to up to the character limit of OpenIGTLink
  - Transforms received currently apply to objects with the same name as the transform in the OpenIGTLink message

The Matrix4x4 definition originates from a SteamVR extension. A replacement implementation would be required with any project not using SteamVR.
