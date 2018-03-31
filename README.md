**Game Technologies Lab**\
**Jiayu Yan**\
**3D animator system in Unity 3D**\

**Proposal**

Before I started learning unity， I once learned to animate 3D character models with 3D MAX and MAYA. But after learning about unity, I was interested in how to use the Unity game engine to design 3D model actions and animations.\
It is known that unity 3D is a game engine, so how do you give instructions to characters in the game in unity? How to use a button or key to control the character in the code? Can you freely design the action of the character? These are I want to know, so I will choose to do this project.

**Reserach**

During the course of the study I found a very interesting and very different point. That's the difference in making character animations due to the unity version replacement. For example, when we have a 3D character model that already includes animations of various characters, we want to control the character's movements through unity. In previous versions, we were more comfortable using OnGUI to control and operate 3D models. However, in the new version, people can use the animator component that comes with Unity to create animations for 3D characters.

In addition, there are differences between the animation and the animator in unity.

First, although Animation and Animator both control the playback of animations, their usage and related syntax are very different. Animation controls the playback of an animation, while Animator switches between multiple animations, and Animator has an animation controller, commonly known as an animation state machine.

Second, Animator uses it to switch animations is very convenient, but it has one drawback is that it takes up more memory than Animation.

**Porcess**

1. Download a 3D model which called "Little Sword Fighter" with all action animation from Unity asset store and import to the unity scene.

2. Add animator components to the original model.

3. Enter the animator editor, drag existing and produced animations such as Idle, Run, attack into the editor and edit the sequence of actions as you see fit. And assign the edited controller to the animator of the model

4. Write code to control the actions of the model through the keyboard or mouse.

**Project**
After press the start the button, you can press 1 to 4 button on keyboard to do tha action such as run, walk. and Press the left mouse button to randomly make different attacks

**Citation**

https://docs.unity3d.com/ScriptReference/Animation.html \
https://docs.unity3d.com/ScriptReference/Animator.html

