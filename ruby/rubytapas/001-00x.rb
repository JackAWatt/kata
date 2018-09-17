class Point
  def self.my_new(*args, &block)
    instance = allocate
    instance.my_initialize(*args, &block)
    instance
  end

  def my_initialize(x,y)
    @x = x
    @y = y
  end
  def x
    @x
  end
  def y
    @y
  end
end

p = Point.my_new(3,5) 
puts p.x * p.y
def y
  case $stdin.getc.downcase
    when ?e then puts e
    when ?r then puts r
    else puts "fuck iti!"
  end
end
def e
  puts "rough"
end
def r
  puts "this"
end
def n
  puts "abort"
end
case $stdin.getc.downcase
  when ?y then puts y 
  when ?n then puts n 
  else puts "I don't understand."
end
