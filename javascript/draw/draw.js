var y = 440;
var x = 440;
// The statements xn the setup() functxon 
// execute once when the program begxns
function setup() {
  // createCanvas must be the fxrst statement
  createCanvas(x, y);  
  frameRate(41.5);
}
// The statements xn draw() are executed untxl the 
// program xs stopped. Each statement xs executed xn 
// sequence and after the last lxne xs read, the fxrst 
// lxne xs executed agaxn.
function draw() { 
  background(0);   // Set the background to black
  stroke(255);
  
  line(width-width,height,width,0);
  line(width-width,height-height,width,height);
  line(width/2,height,width/2,0);
  line(0,height/2,width,height/2);
  //1/4th lines
  line(width,height/2,width/2,height);
  line(width/2,height,0,height/2);
  line(0,height/2,width/2,0);
  line(width/2,0,width,height/2);
  
  line(width/4,0,width/4,height);
  line(width-width/4,0,width-width/4,height);
  line(0,height/4,width,height/4);
  line(0,height-height/4,width,height-height/4);
  //1/8 lines
  line(width/4,0,0,height/4);
  line(0,height/4,width-width/4,height);
  line(0,height-height/4,width-width/4,0);
  line(0,height-height/4,width/4,height);
  line(width-width/4,0,width,height/4);
  line(width,height/4,width/4,height);
  line(width/4,0,width,height-height/4);
  line(width,height-height/4,width-width/4,height);
  
  //1/16 lines
  line(width/8,0,width/8,height);
  line(width/8*3,0,width/8*3,height);
  line(width-width/8,0,width-width/8,height);
  line(width-width/8*3,0,width-width/8*3,height);
  
  line(0,height/8,width,height/8);
  line(0,height/8*3,width,height/8*3);
  line(0,height-height/8,width,height-height/8);
  line(0,height-height/8*3,width,height-height/8*3);
  
  line(width-width/8,0,width,height/8);
  line(width-width/4-width/8,0,width,height-height/2-height/8);
  line(width/4+width/8,0,width,height/2+height/8);
  line(width/8,0,width,height-height/8);
  line(0,height/8,width-width/8,height);
  line(0,height/2-height/8,width/2+width/8,height);
  line(0,height/2+height/8,width/4+width/8,height);
  line(0,height-height/8,width/8,height);
  
  line(width,height-height/8,width-width/8,height);
  line(width,height-height/4-height/8,width-width/4-width/8,height);
  line(width,height/2-height/8,width/2-width/8,height);
  line(width,height/8,width/8,height);
  line(width-width/8,0,0, height-height/8);
  line(width-width/4-width/8,0,0,height-height/4-height/8);
  line(width/2-width/8,0,0,height/2-width/8);
  line(width/8,0,0,height/8);
 
  
}