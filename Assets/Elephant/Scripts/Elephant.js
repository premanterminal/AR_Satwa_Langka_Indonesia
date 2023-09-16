#pragma strict
var elephant : Animator;

function Start () {
}

function Update () {
if(Input.GetKey(KeyCode.Alpha1)){
elephant.SetBool("idle",true);
elephant.SetBool("walking",false);
elephant.SetBool("backward",false);
elephant.SetBool("eating2",false);
elephant.SetBool("trumpet",false);
}
if(Input.GetKey(KeyCode.Alpha2)){
elephant.SetBool("eating2",true);
elephant.SetBool("eating",false);
elephant.SetBool("idle",false);
elephant.SetBool("attack",false);
}
if(Input.GetKey(KeyCode.Alpha3)){
elephant.SetBool("attack",true);
elephant.SetBool("idle",false);
elephant.SetBool("eating",false);
elephant.SetBool("eating2",false);
}
if(Input.GetKey(KeyCode.Alpha4)){
elephant.SetBool("eating",true);
elephant.SetBool("attack",false);
elephant.SetBool("idle",false);
}
if(Input.GetKey(KeyCode.Alpha5)){
elephant.SetBool("trumpet",true);
elephant.SetBool("eating",false);
elephant.SetBool("idle",false);
}
if(Input.GetKey(KeyCode.Alpha6)){
elephant.SetBool("running",false);
elephant.SetBool("died",true);
}
if(Input.GetKey("up")){
elephant.SetBool("walking",true);
elephant.SetBool("idle",false);
elephant.SetBool("running",false);
elephant.SetBool("backward",false);
}
if(Input.GetKey("down")){
elephant.SetBool("backward",true);
elephant.SetBool("walking",false);
elephant.SetBool("idle",false);
}
if(Input.GetKey("left")){
elephant.SetBool("turnleft",true);
elephant.SetBool("walking",false);
walk();
}
if(Input.GetKey("right")){
elephant.SetBool("turnright",true);
elephant.SetBool("walking",false);
walk();
}
if(Input.GetKey(KeyCode.Keypad5)){
elephant.SetBool("running",true);
elephant.SetBool("walking",false);
}
if(Input.GetKey(KeyCode.Keypad4)){
elephant.SetBool("runleft",true);
elephant.SetBool("running",false);
run();
}
if(Input.GetKey(KeyCode.Keypad6)){
elephant.SetBool("runright",true);
elephant.SetBool("running",false);
run();
}
}


function walk(){
yield WaitForSeconds(0.8);
elephant.SetBool("walking",true);
elephant.SetBool("turnleft",false);
elephant.SetBool("turnright",false);
}

function run(){
yield WaitForSeconds(0.7);
elephant.SetBool("running",true);
elephant.SetBool("runleft",false);
elephant.SetBool("runright",false);
}


