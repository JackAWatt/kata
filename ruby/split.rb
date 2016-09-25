arr = ['alpha', 'beta','gamma','delta','epsilon','zeta','eta','theta','iota','kappa','lambda','mu','nu','xi','omicron','pi','rho','sigma','tau','upsilon','phi','chi','psi','omega']
a = []
ar = []
p 'before', arr , 'after', 'map().flatten'
#two different ways to do the same job
p arr.map(&:chars).flatten, 'join.split'

p arr.join.split('')

arr.each {|x| a << x;a.each {|i| ar << i << x}}
arr.each {|x| p x}
a.each {|x| p x}
ar.each {|x| p x}
p 'first array length ' + arr.length.to_s
p 'second array length ' + a.length.to_s
p 'third array length ' + ar.length.to_s

