even = ->(x){ (x % 2) == 0 }
p even.call(2)
p even.call(3)

p "\n"

p even === 2
p even === 3