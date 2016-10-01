/*
 * To change this template, choose Tools | Templates
 * and open the template in the editor.
 */
package shapetest;

/**
 * extends shape
 * 
 * @author Jack Watt
 */
public class Triangle extends Shape {
	// for simplicity we'll assume it is a right angle triangle
	private double base;
	private double height;
  	
        
         /**
         * outputs that a Rectangle is being drawn
         */
	public void draw() { 
		System.out.println("Triangle.draw()"); 
  	}
  	 /**
         * outputs that a Rectangle is being erased
         */
	public void erase() { 
		System.out.println("Triangle.erase()");
  	}
        
         /**
         * Calculate area of Triangle
         * @return area
         */
        public  double computeArea() {
            double area = (getBase() / 2) * getHeight();
		return area;  // not implemented at this level
	}  
        
        /**
         * default constructor
         * @param base
         * @param height 
         */
        public Triangle(double base, double height) {
            this.base = base;
            this.height = height;
            
        }

    /**
     * @return the base
     */
    public double getBase() {
        return base;
    }

    /**
     * @param base the base to set
     */
    public void setBase(double base) {
        this.base = base;
    }

    /**
     * @return the height
     */
    public double getHeight() {
        return height;
    }

    /**
     * @param height the height to set
     */
    public void setHeight(double height) {
        this.height = height;
    }
}
