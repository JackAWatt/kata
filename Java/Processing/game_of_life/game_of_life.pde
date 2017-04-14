
int x = 400;
int y = x;
int[][] board = new int[x][x];

int start = 1;
void setup() {
  size(800,800, P3D);
  frameRate(20);
  for (int i = 0; i<200;i+= 40){
    board_setupx(i);
  }
  
  
}
void board_setupx(int n){
  board[n+2][6] = 1;  
  board[2+n][7] = 1;
  board[3+n][6] = 1; 
  board[3+n][7] = 1;
  
  board[12+n][6] = 1;
  board[12+n][7] = 1;
  board[12+n][8] = 1;
  
  board[13+n][5] = 1;
  board[13+n][9] = 1;
  
  board[14+n][4] = 1;
  board[14+n][10] = 1;
  
  board[15+n][4] = 1;
  board[15+n][10] = 1;
  
  board[16+n][7] = 1;
  
  board[17+n][5] = 1;
  board[17+n][9] = 1;
  
  board[18+n][6] = 1;
  board[18+n][7] = 1;
  board[18+n][8] = 1;
  
  board[19+n][7] = 1;
  
  board[22+n][4] = 1;
  board[22+n][5] = 1;
  board[22+n][6] = 1;
  
  board[23+n][4] = 1;
  board[23+n][5] = 1;
  board[23+n][6] = 1;
  
  board[24+n][3] = 1;
  board[24+n][7] = 1;
  
  board[26+n][2] = 1;
  board[26+n][3] = 1;
  board[26+n][7] = 1;
  board[26+n][8] = 1;
  
  board[36+n][4] = 1;
  board[36+n][5] = 1;
  
  
  board[37+n][4] = 1;
  board[37+n][5] = 1;
}
void board_setup(){
  int x = int(random(10,width/5));
  int y = int(random(10,width/5));
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
        //stroke(random(255),random(255),random(255));
        point(i*4,j*4);
      }
    }
  }
  start = 0;
}


int neighbors(int x,int y){
  int neighbor_count = 0;
  if (y != 0){
    if (board[x][y-1] == 1) {
      neighbor_count++;
    }
  } else {
    if (board[x][399]==1){
      neighbor_count++;
    }
  }
  if (y != 400 -1){
    if (board[x][y+1] == 1){
      neighbor_count++;
    }
  } else {
    if (board[x][0]==1){
      neighbor_count++;
    }
  }
  if (x != 0){
    if (board[x-1][y] == 1){
      neighbor_count++;
    }
  } else {
    if (board[399][y] == 1){
      neighbor_count++;
    }
  }
  if (x != 400-1){
    if (board[x+1][y] == 1){
      neighbor_count++;
    }
  } else {
    if (board[0][y] == 1){
      neighbor_count++;
    }
  }
  if (x != 0){
    if (y !=0){
      if (board[x-1][y-1] == 1){
        neighbor_count++;
      }
    } else {
      if (board[x-1][399] == 1){
        neighbor_count++;
      }
    }
  } else {
    if (y !=0){
      if (board[399][y-1] == 1){
        neighbor_count++;
      }
    } else {
      if (board[399][399]==1){
        neighbor_count++;
      }
    }
  }
  if (x != 400-1){
    if (y != 400-1){
      if (board[x+1][y+1] == 1){
        neighbor_count++;
      } else {
        if (board[x+1][0] == 1){
         neighbor_count++;
        }
      }
    }
  } else {
    if (y != 400-1){
      if (board[0][y+1] == 1){
        neighbor_count++;
      } else {
        if (board[0][0] == 1){
          neighbor_count++;
        }
      }
    }
  }
  if (x != 400-1){
    if (y != 0){
      if (board[x+1][y-1] == 1){
        neighbor_count++;
      }
    } else {
        if (board[0][399] == 1){
          neighbor_count++;
        }
    }
  } else { 
    if (y != 0){
      if (board[0][y-1] == 1){
        neighbor_count++;
      }
    } else {
      if (board[0][399] == 1){
        neighbor_count++;
      }
    }
  }
  if (y != 400-1){
    if (x != 0){
      if (board[x-1][y+1] == 1){
        neighbor_count++;
      }
    } else {
      if (board[399][y+1] == 1){
        neighbor_count++;
      }
    }
  } else {
      if (x != 0){
        if (board[x-1][0] == 1){
          neighbor_count++;
        } else {
          if (board[399][0] == 1){
            neighbor_count++;
          }
        }
      }  
    }
  return neighbor_count; 
}