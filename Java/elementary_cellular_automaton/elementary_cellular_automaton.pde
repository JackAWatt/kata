int xx = 200, yy = 200;
int[][] board = new int[xx][yy];
int [][] next_board = new int[xx][yy];
int[] ruleSet = new int[8];
int run = 0;
void setup(){
  size(1000,1000,P3D);
  board[xx/2][yy-1] = 1;
  for (int i = 0; i < 8;i++){
    ruleSet[i] = int(random(16)% 2);
    System.out.print(ruleSet[i]);
  }
}

void draw(){
  background(111);
  stroke(1);
  strokeWeight(4);
  if (run > 500){
    for (int i = 0; i < 8;i++){
      ruleSet[i] = int(random(16)% 2);
      System.out.println(ruleSet[i]);
      run = 0;
    }
  } else {
    run++;
  }
  for (int i = 0; i <xx;i++){
    for (int j = 0; j<yy;j++){
      if (j == yy-1){
        if (rule_check(i,j-1)){
          next_board[i][j] = 1;
        } else {
          next_board[i][j] = 0; 
        }
      } else {
        next_board[i][j] = board[i][j+1];
      }

    }
  }
  board = next_board;
  for (int i = 0; i<xx;i++){
    for (int j = 0; j<yy;j++){
      if (board[i][j] == 1){
        point(i*4,j*4);
      }
    }
  }
  
}

boolean rule_check(int x, int y){
  boolean alive = false;
  if (x == 0 || x == xx-1){
    
  } else {
    if (board[x-1][y-1] == 1 && board[x][y-1] == 1 && board[x+1][y-1] == 1){
      if (ruleSet[7] == 1){
        alive = true;
      }
    } else if (board[x-1][y-1] == 1 && board[x][y-1] == 1 && board[x+1][y-1] == 0){
      if (ruleSet[6] == 1){
        alive = true;
      }
    } else if (board[x-1][y-1] == 1 && board[x][y-1] == 0 && board[x+1][y-1] == 1){
      if (ruleSet[5] == 1){
        alive = true;
      }  
    } else if (board[x-1][y-1] == 1 && board[x][y-1] == 0 && board[x+1][y-1] == 0){
      if (ruleSet[4] == 1){
        alive = true;
      }  
    } else if (board[x-1][y-1] == 0 && board[x][y-1] == 1 && board[x+1][y-1] == 1){
      if (ruleSet[3] == 1){
        alive = true;
      }  
    } else if (board[x-1][y-1] == 0 && board[x][y-1] == 1 && board[x+1][y-1] == 0){
      if (ruleSet[2] == 1){
        alive = true;
      }  
    } else if (board[x-1][y-1] == 0 && board[x][y-1] == 0 && board[x+1][y-1] == 1){
       if (ruleSet[1] == 1){
        alive = true;
      } 
    } else if (board[x-1][y-1] == 0 && board[x][y-1] == 0 && board[x+1][y-1] == 0){
      if (ruleSet[0] == 1){
        alive = true;
      }  
    } 
  }
 return alive;

}