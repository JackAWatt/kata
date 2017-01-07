#!/bin/ruby

a0,a1,a2 = gets.strip.split(' ')
a0 = a0.to_i
a1 = a1.to_i
a2 = a2.to_i
b0,b1,b2 = gets.strip.split(' ')
b0 = b0.to_i
b1 = b1.to_i
b2 = b2.to_i
bob = 0
alice = 0
if a0 > b0
    alice += 1
elsif b0 > a0
    bob += 1    
end

if a1 > b1
    alice += 1
elsif b1 > a1
    bob += 1    
end

if a2 > b2
    alice += 1
elsif b2 > a2
    bob += 1    
end

puts alice.to_s << " " << bob.to_s
