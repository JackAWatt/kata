boolean flip = false;
void setup(){
  size(400,400,P3D);
  frameRate(1);
}

void draw(){
  background(134);
  stroke(1);
  strokeWeight(3);
  for (int i = 0;i<400;i++){
    for (int j = 0;j<400;j++){
      if (flip && i%4==0 || j%6==0){
        stroke(random(255),random(255),random(255));
        line(i,j,j,i);
        
      } else {
          stroke(random(255),random(255),random(255));
          line(j,j,i,j);
      }
      
      flip = !flip;
      if (flip){
        stroke(random(255),random(255),random(255));
        line(i,j/2,i,i);
      } else {
        stroke(random(255),random(255),random(255));
        line(i,j,j,i);
      }
      if (i<width/2){
        stroke(random(255),random(255),random(255));
        line(i,j,j,i);
      }
    }
  }
  if (flip){
    
  }
  

}