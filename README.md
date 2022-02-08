# unity_sprite_animation
add simple sprite animation without using Animator component

this sample project includes the main script and assets from kennyassets to display sprite. 
call_script is meant to demostrate script-wise initiation.

***how to use***
1.define frames on #sprite list.
2.specify animation type (0 = static, 1 = loop) on #var anim_type
3.define loop type (0 = forward, 1 = pingpong) on #var loop_order
4.define seconds per frame on #var sec
5.define animation end behaviour on #var returnstate (if true, will return to original sprite)
6.trigger "start" bool to start animation. if anim type is loop, it will continue until stopped. see 7. 
7."stop" bool will reset animation and clear #sprite list.

the script can be initiated on both editor or code.
