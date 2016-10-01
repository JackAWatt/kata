/*
 * To change this template, choose Tools | Templates
 * and open the template in the editor.
 */

package testscoreapp;
import java.util.Scanner;
import java.text.NumberFormat;
/**
 *
 * @author Jack Watt
 */
public class TestScoreApp {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        // TODO code application logic here
         int scoreTotal = 0;
        int scoreCount = 0;
        int testScore = 0;
        double averageScore = 0;

        Scanner sc = new Scanner(System.in);
        
        String choice = "y";
        while (!choice.equalsIgnoreCase("n"))
        {
            // get the input from the user
           // System.out.print("Enter score: ");
           // testScore = sc.nextInt();
            //checks for valid range
            testScore = getIntWithinRange(sc, "Enter score: ", 0, 100);
            
            scoreCount += 1;
            scoreTotal += testScore;
            averageScore = (double) scoreTotal / (double) scoreCount;
            
            // see if the user wants to enter more test scores
            //System.out.print("Enter another test score? (y/n): ");
           //choice = sc.next();
            //added call to custom function to find if user wants to enter another score
            choice = getValidInput(sc, "y", "n", "Enter another test score? (y/n): ");
            sc.nextLine();
        }

        NumberFormat number = NumberFormat.getNumberInstance();
        number.setMaximumFractionDigits(1);
        String message = "\n" +
                         "Score count:   " + scoreCount + "\n"
                       + "Score total:   " + scoreTotal + "\n"
                       + "Average score: " + number.format(averageScore) + "\n";
        System.out.println(message);
    } 
	//generic function provided by Murach
     public static int getIntWithinRange(Scanner sc, String prompt,
    int min, int max)
    {
        int i = 0;
        boolean isValid = false;
        while (isValid == false)
        {
            i = getInt(sc, prompt);
            if (i <= min)
                System.out.println(
                    "Error! Number must be greater than " + min + ".");
            else if (i >= max)
                System.out.println(
                    "Error! Number must be less than " + max + ".");
            else
                isValid = true;
        }
        return i;
    }
	//generic function provided by Murach
    public static int getInt(Scanner sc, String prompt)
    {
        int i = 0;
        boolean isValid = false;
        while (isValid == false)
        {
            System.out.print(prompt);
            if (sc.hasNextInt())
            {
                i = sc.nextInt();
                isValid = true;
            }
            else
            {
                System.out.println("Error! Invalid integer value. Try again.");
            }
            sc.nextLine();  // discard any other data entered on the line
        }
        return i;
    }//function used to see if user wants to go again
    //only accepts Y or N - (not case sensitive )
	  private static String getValidInput(Scanner sc, String valid, String invalid, String output) {
            String customerType = " ";
            while (!customerType.equalsIgnoreCase(valid) && !customerType.equalsIgnoreCase(invalid))
            { //entry point for comparision loop based on if customerType isNot r OR "c"
                System.out.print(output);
                customerType = sc.next();
                if (customerType.equalsIgnoreCase(valid) || customerType.equalsIgnoreCase(invalid)) 
                {//entry point if customerType meets criteria
                  
                }  
                 else 
                {//entry point if input does not meet criteria
                 
                 System.out.println("Error: Invalid input\n");
                 
                }
                
            }
        
        return customerType;
    }
    
    
    
    
}

