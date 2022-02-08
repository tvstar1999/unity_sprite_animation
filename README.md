# unity_sprite_animation
add simple sprite animation without using Animator component
<br>
<br>this sample project includes the main script and assets from kennyassets to display sprite. 
<br>call_script is meant to demostrate script-wise initiation.
<br>
<br>***how to use***
<br>1.define frames on #sprite list.
<br>2.specify animation type (0 = static, 1 = loop) on #var anim_type
<br>3.define loop type (0 = forward, 1 = pingpong) on #var loop_order
<br>4.define seconds per frame on #var sec
<br>5.define animation end behaviour on #var returnstate (if true, will return to original sprite)
<br>6.trigger "start" bool to start animation. if anim type is loop, it will continue until stopped.
<br>7."stop" bool will reset animation and clear #sprite list.
<br>
<br>the script can be initiated on both editor or code.
