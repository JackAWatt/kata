/*
 * To change this template, choose Tools | Templates
 * and open the template in the editor.
 */
package sample.pkg2012sep17;

/**
 *
 * @author 2014617
 */
public class Sample2012sep17 {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        // TODO code application logic here
        double doWork = 10;
        double doWorkInitial = doWork;
        
        int iteration = 0;
        System.out.println("Current value is" + doWork + " We will square this"
                + "number until it is 10,000 or higher");
        calculateAnswer(doWork , iteration, doWorkInitial);
        
        
    }
    
    public static void calculateAnswer(double doWork, int iteration,
            double doWorkInitial) {
    //do the calculation here
        
        if (doWork < 10000) {
            doWork = doWork * doWorkInitial;
            iteration++;
            System.out.println("Current value is " + doWork + " We will square this"
                + "number until it is 10,000 or higher");
            calculateAnswer(doWork, iteration, doWorkInitial);
        }
        else {
            System.out.println("it took " + iteration +
                    " times to reach 10,000+");
            
            
         
        }
    }
}
