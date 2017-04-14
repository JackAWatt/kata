def setup():
    size(400, 400)

def draw():
    if  mousePressed:
        fill(111)
        stroke(1)
        strokeWeight(6)
        point(mouseX,mouseY)
    else:
        fill(255)
    frameRate(12)
    println(str(mouseX) + " : " + str(mouseY))
