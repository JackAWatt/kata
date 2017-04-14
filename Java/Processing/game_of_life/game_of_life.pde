PFont f;
int x = 100;
int y = x;
int[][] board = new int[x][x];

int start = 1;
void setup() {
  size(1000,1000, P3D);
  frameRate(4);
  random_inject();
  for (int i = 0; i<14;i++){
    board_setup();
  }
}

void board_setup(){
  int x = int(random(width/10));
  int y = int(random(width/10));
  board[x/2][y/2] = 1;
  board[x/2][y/2-1] = 1;
  board[x/2][y/2-2] = 1;
  board[x/2-1][y/2-2] = 1;
  board[x/2-2][y/2-1] = 1;
}

void draw() {
  background(134);
  stroke(0);
  lights();
  strokeWeight(4);
  f = createFont("Arial",16,true);
  text("point x/2,y/2 neighbors " +  boolean(board[x/2+1][y/2+1]) + " " + neighbors(x/2,y/2) ,width/4,height-height/4);
  if (start == 0) {
    int[][] next_board = new int[x][x];
    for (int i = 0; i<x;i++){
      for (int j=0;j<x;j++){
        int n = neighbors(i,j);
        if (board[i][j] == 1){
          if (n == 2 || n == 3 ){
            next_board[i][j] = 1;
          }
        } else {
            if (n == 3){
              next_board[i][j]=1;
            }
        }
      }
    }
    board = next_board;
  }
  
  for (int i = 0; i<x;i++){
    for (int j=0;j<x;j++){
      if (board[i][j] == 1) {
        point(i*10,j*10);
      }
    }
  }
  start = 0;
}


void random_inject() {
  for (int i = x*12;i>=0;i--) {
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
  if (y != 100 -1){
    if (board[x][y+1] == 1){
      neighbor_count++;
    }
  }
  if (x != 0){
    if (board[x-1][y] == 1){
      neighbor_count++;
    }
  }
  if (x != 100-1){
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
  if (x != 100-1){
    if (y != 100-1){
      if (board[x+1][y+1] == 1){
        neighbor_count++;
      }
    }
  }
  if (x != 100-1){
    if (y != 0){
      if (board[x+1][y-1] == 1){
        neighbor_count++;
      }
    }
  }
  if (y != 100-1){
    if (x != 0){
      if (board[x-1][y+1] == 1){
        neighbor_count++;
      }
    }
  }
  return neighbor_count; 
}