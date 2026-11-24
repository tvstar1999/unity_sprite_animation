# unity_sprite_animation
Add a simple sprite animation without using the Animator component.
<br>Made with Unity 2020.3.30f1.
<br>
<br>This sample project includes the main script and Kenny Assets assets to display a sprite. 
<br>"call_script" demonstrates script-based initialization.
<br>
<br>***how to use***
<br>1. Define frames on the #sprite list.
<br>2. Specify animation type (0 = static, 1 = loop) on #var anim_type
<br>3. Define loop type (0 = forward, 1 = pingpong) on #var loop_order
<br>4. Define seconds per frame on #var sec
<br>5. Define animation end behaviour on #var returnstate (if true, will return to original sprite)
<br>6. Trigger "start" bool to start animation. If the anim type is loop, it will continue until stopped.
<br>7. "stop" bool will reset the animation and clear the #sprite list.
<br>
<br>The script can be initiated in both the editor and code.
