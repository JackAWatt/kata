
int xx = 800;
int yy = 950;
int[][] board = new int[xx][yy];
//import peasy.*;

//PeasyCam cam;
boolean start = true;
void setup() {
  size(800,950, P3D);
  //cam = new PeasyCam(this, 500);
  frameRate(90);
  for (int i = 0; i<150;i+= 40){
    board_setupx(i,0);
    board_setupx(i+200 + i,100);
    board_setupx(i+150,i+300);
    board_setupx(i+300,i+360);
    board_setupx(i/2+100,i/2+100);
    board_setupx(i/2+xx/2,i/2+xx/2);
    board_setupx(xx-50,xx-xx/9*8);
    board_setupx(xx-xx/4,xx-xx/4);
    //board_setupx(xx-xx/4-40,xx-xx/4-40);
    board_setupx(xx-xx/4,xx-xx/4);
    board_setupx(i/2,i/2);
    random_inject();
    board_setup();
  }
  
  
}

void random_inject() {
  for (int i = xx*8*2;i>=0;i--) {
    board[int(random(xx))][int(random(yy))] = 1;
  }
}

void board_setupx(int n,int j){
  board[n+2][6+j] = 1;  
  board[2+n][7+j] = 1;
  board[3+n][6+j] = 1; 
  board[3+n][7+j] = 1;
  
  board[12+n][6+j] = 1;
  board[12+n][7+j] = 1;
  board[12+n][8+j] = 1;
  
  board[13+n][5+j] = 1;
  board[13+n][9+j] = 1;
  
  board[14+n][4+j] = 1;
  board[14+n][10+j] = 1;
  
  board[15+n][4+j] = 1;
  board[15+n][10+j] = 1;
  
  board[16+n][7+j] = 1;
  
  board[17+n][5+j] = 1;
  board[17+n][9+j] = 1;
  
  board[18+n][6+j] = 1;
  board[18+n][7+j] = 1;
  board[18+n][8+j] = 1;
  
  board[19+n][7+j] = 1;
  
  board[22+n][4+j] = 1;
  board[22+n][5+j] = 1;
  board[22+n][6+j] = 1;
  
  board[23+n][4+j] = 1;
  board[23+n][5+j] = 1;
  board[23+n][6+j] = 1;
  
  board[24+n][3+j] = 1;
  board[24+n][7+j] = 1;
  
  board[26+n][2+j] = 1;
  board[26+n][3+j] = 1;
  board[26+n][7+j] = 1;
  board[26+n][8+j] = 1;
  
  board[36+n][4+j] = 1;
  board[36+n][5+j] = 1;
  
  
  board[37+n][4+j] = 1;
  board[37+n][5+j] = 1;
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
  strokeWeight(2);
  if (start == false) {
    int[][] next_board = new int[xx][yy];
    for (int i = 0; i<xx;i++){
      for (int j=0;j<yy;j++){
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
    start = false;

  
  for (int i = 0; i<xx;i++){
    for (int j=0;j<yy;j++){
      if (board[i][j] == 1) {
        point(i,j);
      }
    }
  }

}


int neighbors(int x,int y){
  int neighbor_count = 0;
  if (y != 0){
    if (board[x][y-1] == 1) {
      neighbor_count++;
    }
  } else {
    if (board[x][yy-1]==1){
      neighbor_count++;
    }
  }
  if (y != yy -1){
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
    if (board[xx-1][y] == 1){
      neighbor_count++;
    }
  }
  if (x != xx-1){
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
      if (board[x-1][yy-1] == 1){
        neighbor_count++;
      }
    }
  } else {
    if (y !=0){
      if (board[xx-1][y-1] == 1){
        neighbor_count++;
      }
    } else {
      if (board[xx-1][yy-1]==1){
        neighbor_count++;
      }
    }
  }
  if (x != xx-1){
    if (y != yy-1){
      if (board[x+1][y+1] == 1){
        neighbor_count++;
      } else {
        if (board[x+1][0] == 1){
         neighbor_count++;
        }
      }
    }
  } else {
    if (y != yy-1){
      if (board[0][y+1] == 1){
        neighbor_count++;
      } else {
        if (board[0][0] == 1){
          neighbor_count++;
        }
      }
    }
  }
  if (x != xx-1){
    if (y != 0){
      if (board[x+1][y-1] == 1){
        neighbor_count++;
      }
    } else {
        if (board[0][yy-1] == 1){
          neighbor_count++;
        }
    }
  } else { 
    if (y != 0){
      if (board[0][y-1] == 1){
        neighbor_count++;
      }
    } else {
      if (board[0][yy-1] == 1){
        neighbor_count++;
      }
    }
  }
  if (y != yy-1){
    if (x != 0){
      if (board[x-1][y+1] == 1){
        neighbor_count++;
      }
    } else {
      if (board[xx-1][0] == 1){
        neighbor_count++;
      }
    }
  } else {
      if (x != 0){
        if (board[x-1][0] == 1){
          neighbor_count++;
        } else {
          if (board[xx-1][0] == 1){
            neighbor_count++;
          }
        }
      }  
    }
  return neighbor_count; 
}