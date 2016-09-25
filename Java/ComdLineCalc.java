/*
 * To change this template, choose Tools | Templates
 * and open the template in the editor.
 * Jack Watt
 */
package comdlinecalc;
/**
 *
 * @author jack
 */
public class ComdLineCalc {
    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
  
        double average = 0;
       boolean isValid = true;
        int i = 0;
        
        //runs through array of args
        //stops if reaches non numeric value
        if(args.length == 0) {
            
         isValid = false;
         //outputs instructions to end user on proper syntax
         System.out.println("Usage: java ComdLineCalc <double> <double> <double>");
            
        }
        while (isValid && i <= args.length - 1) {
            
            //casts arg to double
            try {
               
               Double.parseDouble(args[i]);
               average += Double.parseDouble(args[i]);
           //if arg can't be cast to double stops program
            } catch (NumberFormatException e) {
                System.out.println("STOPPED - Arg # " + (i + 1) + ": " + args[i] + " is not a number");
                isValid = false;
        }
               //iterate the counter
            i++;
        }
        //given nothing has gone wrong yet it outputs the data to the screen
        if (isValid) {
            for (i = 0; i < args.length - 1; i++) {
                System.out.print(args[i] + "+ ");
             
            }
            //Displays average
            System.out.println(args[args.length - 1] + " = " + average);
            System.out.println("average = " + average + "/" + args.length + " = " + average/3);

        }
    }
}