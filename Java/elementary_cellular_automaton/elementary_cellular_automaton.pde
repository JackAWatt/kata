int xx = 200, yy = 200;
int[][] board = new int[xx][yy];
int[] rule = new int[8];
void setup(){
  size(1000,1000,P3D);
  board[xx/2][yy/2] = 1;
  for (int i = 0; i < 8;i++){
    rule[i] = int(random(0,1));
  }
}

void draw(){
  background(111);
  stroke(1);
  strokeWeight(4);
  for (int i = 0; i <xx;i++){
    for (int j = 0; j<yy;j++){
      if (board[i][j] == 1){
        point(i*4,j*4);
      }
    }
  }
}

void rule_check(){
  if 
}