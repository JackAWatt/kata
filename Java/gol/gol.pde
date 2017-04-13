//import peasy.*;
//PeasyCam cam;

int x = 1000;
int y = x;
int[][] board = new int[x][x];
int start = 1;
void setup() {
  size(1000,1000, P3D);
  //cam = new PeasyCam(this, 500);
  random_inject();
}

void draw() {
  background(134);
  stroke(0);
  lights();
  strokeWeight(1);
  if (start == 0) {
    for (int i = 0; i<x;i++){
      for (int j=0;j<x;j++){
        int n = neighbors(i,j);
        if (board[i][j] == 1){
          if (n < 2 || n > 3){
            board[i][j] =0;
          }
        } else {
            if (n == 3){
              board[i][j]=1;
            }
        }
      }
    }
  }
  for (int i = 0; i<x;i++){
    for (int j=0;j<x;j++){
      if (board[i][j] == 1) {
        point(i,j);
      }
    }
  }
  start = 0;
}


void random_inject() {
  for (int i = x*8;i>=0;i--) {
    board[int(random(x))][int(random(x))] = 1;
  }
}


int neighbors(int x,int y){
  int neighbor_count = 0;
  if (y != 0){
    if (board[x][y-1] == 1) {
      neighbor_count++;
    }
  }
  if (y != height-1){
    if (board[x][y+1] == 1){
      neighbor_count++;
    }
  }
  if (x != 0){
    if (board[x-1][y] == 1){
      neighbor_count++;
    }
  }
  if (x != width-1){
    if (board[x+1][y] == 1){
      neighbor_count++;
    }
  }
  if (x != 0){
    if (y !=0){
      if (board[x-1][y-1] == 1){
        neighbor_count++;
      }
    }
  }
  if (x != width-1){
    if (y != height-1){
      if (board[x+1][y+1] == 1){
        neighbor_count++;
      }
    }
  }
  if (x != width-1){
    if (y != 0){
      if (board[x+1][y-1] == 1){
        neighbor_count++;
      }
    }
  }
  if (y != height-1){
    if (x != 0){
      if (board[x-1][y+1] == 1){
        neighbor_count++;
      }
    }
  }
  return neighbor_count; 
}