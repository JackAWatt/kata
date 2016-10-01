/*
 * To change this template, choose Tools | Templates
 * and open the template in the editor.
 */
package shapetest;

/**
 *
 * @author 2014617
 */
import java.util.Random;

//ShapeTest.java - THIS AND RELATED FILES ADAPTED FROM:
//'Thinking in Java, 2nd ed.' by Bruce Eckel
//www.BruceEckel.com. See copyright notice in CopyRight.txt.
//Polymorphism in Java

public class ShapeTest {

	private static Random generator = new Random(1);
	
	public static void main(String[] args) {
		final int MAX_SHAPES = 10;
		Shape[] shapeArray = new Shape[MAX_SHAPES];
		//shapeArray[0] = new Shape();
 		// Fill up the array with shapes:
		for(int i = 0; i < shapeArray.length; i++)
			shapeArray[i] = randomShape();

		// Make polymorphic method calls:
		for(int i = 0; i < shapeArray.length; i++)  {
			System.out.print("\n\nshapeArray[" + i + "]:\n");
			shapeArray[i].draw();
			shapeArray[i].erase();
			
			// TUDO: Uncomment the next two lines once you have properly overridden the methods
			System.out.println("Area = " + shapeArray[i].computeArea());
			System.out.println("Perimeter = " + shapeArray[i].computePerimeter());

		}
	}
	
	private static Shape randomShape() {
		switch((int)(generator.nextInt(3))) {
			default:
			case 0:
				return new Circle(10);  // TUDO: later put 10 as parameter
			case 1:
				return new Rectangle(8, 12); // TUDO: later put 8, 12 as parameters
			case 2:
				return new Triangle(10, 5);  // TUDO: later put 10, 5 as parameters
		}
	}	
} 

