/*
 * To change this template, choose Tools | Templates
 * and open the template in the editor.
 */
package shapetest;

/**
 *Extends shape class
 * used for Circle shapes
 * @author Jack Watt
 */
public class Circle extends Shape {
	private double radius;
  	/**
         * outputs that a Circle is being drawn
         */
	public void draw() { 
		System.out.println("Circle.draw()"); 
  	}
        /**
         * outputs that a Circle has been erased
         */
	public void erase() { 
		System.out.println("Circle.erase()"); 
  	}
        /**
         * Calculate area of Circle
         * @return area
         */
        public  double computeArea() {
            double area = Math.PI * (getRadius() * getRadius());
		return area;  // not implemented at this level
	}  

	/**
         * calculates perimeter of Circle
         * @return perimeter
         */
	public double computePerimeter() {
            double perimeter = 2 * Math.PI * getRadius();
		return perimeter;  // not implemented at this level
	}
        
        /**
         * Default constructor
         * @param radius 
         */
        public Circle(double radius){
            this.radius = radius;
        }

    /**
     * @return the radius
     */
    public double getRadius() {
        return radius;
    }

    /**
     * @param radius the radius to set
     */
    public void setRadius(double radius) {
        this.radius = radius;
    }
}

