greeter_p = proc do |name|
    puts "Hello, #{name}"
end

greeter_l = lambda do |name|
    puts "Hello, #{name}"
end

#doesn't care about extra info
greeter_p.call("hello", "there")

#reports error
greeter_l.call("hey", "you")
