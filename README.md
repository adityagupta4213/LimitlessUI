# EULA:
You are allowed to change/modify/update and use this library as long as it is not used for commercial use.

<br>
<br>

# Documentation:

<br>

## ArchProgressBar:
### Description:
Nearly the same thing as CircularProgressBar just more customisible, has several styles (That determen labels positions and count).
### Properties:
1. Angle - Determens angle of the arch (360 - Full circle, 180 - Half a circle)
2. BackLineThikness - Thikness of back line.
3. ProgressLineThikness - Thikness of line that shows progress.
4. ProgressBackCollor - Color of a back line (Gray - By default).
5. ProgressColor - Collor of line that shows progress (Lime - By default).
6. Style - Styles that changes labels layout (Style1, Style2, Style3, None)
7. Text1, Text2, Text3 - Text of labels.
8. Text1Color, Text2Color, Text3Color - Colors of labels.
9. Font1, Font2, Font3 - Fonts of labels.
10. IgnoreHeight - If False: "Increase progressBar radius as long as height allows".
### Notes:
For updating labels method "UpdateText" should be used UNLESS there is a need to update only one label.

<br>

## DragControl:
### Description:
A way to drag borderless forms. Has double left click functionality to maximise form.
### Properties:
1. Fixed - True - to drag the form, False - to drag it withing the form. (if that makes sense)
2. MaximiseOnDoubleClick - If setted to true - maximises form on double-click.
3. TargetControl -  Control that is your grip.
4. DraggableInnerControls - Makes so you can use conntrols withing pane to drag the form. (tho, it disables buttons)

<br>

## DropDown:
### Description:
Really simple DropDown.
### Properties:
1. ArrowSize - Size of the arrow. 
2. ArrowThikness - Thikness of arrow.
3. SetLayout - Control that supposed to be Dropped down.
4. TextDistance - Changes drawn text distance from  the left.
5. PointsDown - sets arrow pointing direction
6. UpImage, DownImage - Custom image of the arrow
<br>

## Elipse:
### Description:
A way to round the conners of something, usualy used for borderless forms.
### Properties:
ConnerRadius - Conner radius...
TargetControl - Control that supposed to have rounded conners.

<br>

## FlatButton:
### Description:
Flat button that works as a tab, usualy used for navigations.
### Properties:
1. ActiveColor - Color that background changes whenever button is pressed.
2. ActiveTextColor -  Color that text changes to whenever button is pressed.
3. Image - Image that gets placed to the right of the text.
4. ImageSize - Size of the image.
5. OnHoverColor - Color of the background whenever mouse is hovering it.
6. OnHoverTextColor - Color of the text whenever mouse is hovering it.
7. Selected - If setted to true - default text and backgroud collor will be set to "active".
8. TextAligment - Aligment of the text.
9. ActiveImage - Image that shows whenever button is active
10. DefaultBack(Fore)Color - needed to be set to default one if button is selected by default
11. DrawImage - If setted to true - draws Image (if avalible)
12. DrawText - If setted to true - draws image, if false - then button can be used as basic pictureBox
13. IsTab - Sets button as a tab
14. TextOffset - Offsets text by specified amout of pixels
15. UseActiveImageWhileHovering - Does what is says. (goash its a long name :D)

<br>

## GradientPanel:
### Description:
Panel with gradient drawn on top of it.
### Properties:
1. Angle - Gradient angle.
2. StartColor - Color that gradient starts with.
3. EndColor - color that gradient ends with.

<br>
## ListView:
### Description:
ListView that accepts UserControls as its childs
### Properties:
1. AutoExpang - If setted to true, ListView changes its Height instead of having scrollbars.
2. Vertical - If setted to true, it adds childs verticly (From top to bottom), if setted to false - adds childs horizoticly - from left to right.
### Methods:
1. Add();
2. Clear();
3. Remove();
<br>

## ProgressBar:
### Description:
Basic ProgressBar.
### Properties:
1. BackLineThikness - Thikness of back line.
2. FrontLineThikness - Thikness of front line.
3. ProgressBackColor - Color of back line.
4. ForeColor - Color of front line.
5. Rounded - Rounds lines endings.
6. Smooth - enables anti-alias.
7. Value - value of the progressBar.

<br>

## Seperator:
### Description:
Line that is usually used to seperate components or parts of UI.
Recently added animation that is implemented in TextBox_WOC.cs
### Properties:
1. LineColor - Color of the line.
2. LineThikness - Thikness of hte line.
3. AnimationEnabled - If setted to false - animatoin will not be drawn.
4. Angle - Angle of the line.
5. AnimationColor - Color of the animation.
6. Val - Value of the animation.
7. Vertical - On this parameter depends how line size is calculated.
### Methods:
1. StartAnimating - Params: interval - How often should animation be drawn(16 for full 60fps), progress - how much should animation be changed each frame, startValue - value from which animation should be started drawn (-1 for current value)
### Notes:
  Compatible with Left and right paddings. :)
  
  
<br>

## Slider:
### Description:
Slider - aka trakbar.
### Properties:
1. BackLineThikness - Thikness of back line.
2. CircleSize - Diameter of a circle.
3. DrawCircle - if setted to true - draws circle, false othervise.
4. FrontLineThikness - Thikness of front line.
5. MaxValue - Slider max value.
6. Value - Value.


<br>

## Switch:
### Description:
Basic switch.
### Properties:
1. IsOn - If setted to true - on by default.
2. OnColor -  Color of switch while its on.
3. OffColor - Same but while off.
4. OnText - Text that shows while switch is on.
5. OffText - Same but while Switch is off.
6. TextEnable - If setted to true, shows text.

<br>

## TabsAdapter:
### Description:
Component that helps to manage "tabs" (using UserControls as tabs).
### Properties:
1. Control - Control that works as "Tab Holder"
### Methods:
1. addTab()
2. showTab()
<br>

## Tab_WOC.cs(Class):
### Description:
Interface that adds OnShow method IF used with TabsAdapter

<br>

## Form_WOC.cs (Class):
### Description:
Class that adds resisible grip to borderless forms edges. 
### How to use it:
  1. Change forms inharance from "Form" to "Form_WOC".
  2. Add padding of ur choice (Reccomended 2-3).
### Notes:
  Grip is drawn on the edges of the form, that means that form needs to have small padding (3-4). To hide that padding - drawLine method was created, view sample code to learn more
  
  
<br>

### TextBox:
### Description:
Material styled TextBox with animation
### How to use it:
  1. TextBoxText - Text of the TextBox.
  2. AnimationColor - Color of animation.
  3. TextBox - Returns TextBox itself.
  4. Underline - Returns underline(that is seperator).

<br>


### Animator:
### Description:
Allows to animate controls. As of right now - it is only able to change size of them
### Properties:
1. Control - Control that you wish to animate
2. Delay - Number that determens how often should it be updated. (lower number == higher cpu usage)
### How to use it:
1. Add it
2. Set animation(s) of your choice (programaticly - by using method). (as of right now - only "changeSize(int speed, int x, int y)" is avalible.
3. Use "startAnimation()" to start an animation.
### Listeners:
1. onWidthChanged(Control control, int change, bool isExpanding);
2. onHeightChanged(Control control, int change, bool isExpanding);
3. onAnimationTick(Control control);




